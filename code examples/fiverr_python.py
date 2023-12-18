import requests
from pprint import pprint

# Structure payload.
payload = {
    'source': 'universal',
    'url': 'https://www.fiverr.com/categories/programming-tech?source=category_tree&utm_source=google&utm_medium=cpc-brand&utm_campaign=g_row-en_brand&utm_term=one-fiverr_(exact)&utm_content=adid^553700574654^keyword^fiverr^placement^^device^c&caid=406997588&agid=33518326868&ad_id=553700574654&kw=fiverr&lpcat=br_general&show_join=true&gad_source=1&gclid=cj0kcqiayewrbhddarisagp1mwtihv9kyf30tagb9bqxwvo1eydzfxza0qti9_idtnirpiou_htg1wwaal19ealw_wcb'
}

# Get response.
response = requests.request(
    'POST',
    'https://realtime.oxylabs.io/v1/queries',
    auth=('user', 'pass1'),
    json=payload,
)

# Instead of response with job status and results url, this will return the
# JSON response with the result.
pprint(response.json())