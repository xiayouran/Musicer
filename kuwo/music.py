# -*- coding: utf-8 -*-
# @Time    : 2021/5/16 22:41
# @Author  : XiaYouRan
# @Email   : youran.xia@foxmail.com
# @File    : music.py
# @Software: PyCharm


import time
from hashlib import md5
import json
import requests
import re
import os
from urllib import parse


def precess_time(func):
    def wrapper(*args):
        minutes, seconds = divmod(int(args[0]), 60)
        result = str(minutes).zfill(2) + ':' + str(seconds).zfill(2)
        return result

    return wrapper


@precess_time
def get_songtime(time_str):
    return time_str


class KuWoMusic(object):
    def __init__(self):
        self.headers = {'User-Agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) '
                                      'AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36',
                        'Cookie': '_ga=GA1.2.136730414.1610802835; _gid=GA1.2.80092114.1621072767; Hm_lvt_cdb524f'
                                  '42f0ce19b169a8071123a4797=1621072767; Hm_lpvt_cdb524f42f0ce19b169a8071123a4797'
                                  '=1621073279; _gat=1; kw_token=C713RK6IJ8J',
                        'csrf': 'C713RK6IJ8J',
                        'Host': 'www.kuwo.cn',
                        'Referer': ''}

    def get_html(self, url, search_key=None, mid=None):
        if 'mid' not in url:
            self.headers['Referer'] = 'http://www.kuwo.cn/search/list?key=' + search_key
        else:
            # del self.headers['Referer']
            self.headers['Referer'] = 'http://www.kuwo.cn/play_detail/{}'.format(mid)
            del self.headers['csrf']
        try:
            response = requests.get(url, headers=self.headers, verify=False)
            response.raise_for_status()
            response.encoding = 'utf-8'
            return response.text
        except Exception as err:
            print(err)
            return '请求异常'

    def parse_text(self, text):
        print('{:*^80}'.format('搜索结果如下'))
        print('{0:{5}<5}{1:{5}<15}{2:{5}<10}{3:{5}<10}{4:{5}<20}'.format('序号', '歌名', '歌手', '时长(s)', '专辑', chr(12288)))
        print('{:-^84}'.format('-'))
        song_list = json.loads(text)['data']['list']
        info_list = []
        for count, song in enumerate(song_list):
            singer_name = song['artist']
            song_name = song['name']
            album_name = song['album']
            rid = song['rid']
            time_str = get_songtime(song['duration'])
            info_list.append([rid, song_name, singer_name])
            print('{0:{5}<5}{1:{5}<20}{2:{5}<10}{3:{5}<10}{4:{5}<20}'.format(count, song_name, singer_name, time_str, album_name, chr(12288)))
            # count += 1
            # if count == 10:
            #     break
        print('{:*^80}'.format('*'))
        return info_list

    def save_file(self, song_text, download_info):
        filepath = './download'
        if not os.path.exists(filepath):
            os.mkdir(filepath)
        song_url = json.loads(song_text)['data']['url']
        del self.headers['Host']
        response = requests.get(song_url, headers=self.headers)
        audio_name = download_info[2] + ' - ' + download_info[1]
        with open(os.path.join(filepath, audio_name) + '.mp3', 'wb') as f:
            f.write(response.content)
            print("下载完毕!")


def kw_main():
    kw = KuWoMusic()
    search_info = input("请输入歌名或歌手: ")
    search_key = parse.quote(search_info)
    # pn表示页数, 默认一页30条歌曲信息
    search_url = 'http://www.kuwo.cn/api/www/search/searchMusicBykeyWord?key={}&pn=1&rn=30'.format(search_key)
    search_text = kw.get_html(search_url, search_key)
    info_list = kw.parse_text(search_text)

    while True:
        input_index = eval(input("请输入要下载歌曲的序号(-1退出): "))
        if input_index == -1:
            break
        download_info = info_list[input_index]
        # 流畅音质  128k
        # 高频音质  192k
        # 超品音质  320k
        # song_info_url = 'http://www.kuwo.cn/url?rid={0}&type=convert_url3&br=128kmp3'.format(download_info[0])
        song_info_url = 'http://www.kuwo.cn/api/v1/www/music/playUrl?mid={}&type=music&httpsStatus=1&br=128kmp3'.format(download_info[0])
        song_text = kw.get_html(song_info_url, mid=download_info[0])
        kw.save_file(song_text, download_info)


if __name__ == '__main__':
    kw_main()
