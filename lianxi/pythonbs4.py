from bs4 import BeautifulSoup
import requests

headers = {'User-Agent':'Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/57.0.2987.110 Safari/537.36','referer':"www.mmjpg.com" }
all_url = 'http://www.mmjpg.com/'

start_html = requests.get(all_url, headers)

Soup = BeautifulSoup(start_html.text, 'lxml')

all_a = Soup.find('div', class__='pic').find_all('a')[-2]

