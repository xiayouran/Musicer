# -*- coding: utf-8 -*-
# @Time    : 2021/4/20 20:32
# @Author  : XiaYouRan
# @Email   : youran.xia@foxmail.com
# @File    : main.py
# @Software: PyCharm


from wangyiyun.music import wyy_main
from kugou.music import kg_main
from kuwo.music import kw_main
from utils.util import welcome


def select():
    print('目前支持的播放器类型: 1. 网易云\t2. 酷狗\t3. 酷我')
    input_str = input('请选择播放器类型(-1退出): ')
    if input_str == '-1':
        exit()
    elif input_str == '1':
        wyy_main()
    elif input_str == '2':
        kg_main()
    elif input_str == '3':
        kw_main()
    else:
        print('输入无效!!!')


if __name__ == '__main__':
    welcome()
    select()

