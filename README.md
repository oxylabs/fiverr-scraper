# Fiverr Scraper API

[![Oxylabs promo code](https://user-images.githubusercontent.com/129506779/250792357-8289e25e-9c36-4dc0-a5e2-2706db797bb5.png)](https://oxylabs.go2cloud.org/aff_c?offer_id=7&aff_id=877&url_id=112)

Oxylabs’ [Fiverr Scraper](https://oxylabs.io/products/scraper-api/web/fiverr?utm_source=github&utm_medium=repositories&utm_campaign=product) is a data gathering solution allowing you to extract real-time information from an Fiverr website effortlessly. This brief guide explains how an Fiverr Scraper works and provides code examples to understand better how you can use it hassle-free.

### How it works

You can get Fiverr results by providing your own URLs to our service. We can return the HTML for any Fiverr page you like.

#### Python code example

The example below illustrates how you can get HTML of Fiverr page.

```python
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
```
Find code examples for other programming languages [**here**](https://github.com/oxylabs/fiverr-scraper/tree/main/code%20examples)

#### Output Example
```json
{
  "results": [
    {
      "content": "<!DOCTYPE html>\n<html xmlns=\"http://www.w3.org/1999/xhtml\" prefix=\"og:https://ogp.me/ns# fb:http://o ... </html>",
      "created_at": "2023-12-18 10:39:29",
      "updated_at": "2023-12-18 10:39:49",
      "page": 1,
      "url": "https://www.fiverr.com/categories/programming-tech?source=category_tree&utm_source=google&utm_medium=cpc-brand&utm_campaign=g_row-en_brand&utm_term=one-fiverr_(exact)&utm_content=adid^553700574654^keyword^fiverr^placement^^device^c&caid=406997588&agid=33518326868&ad_id=553700574654&kw=fiverr&lpcat=br_general&show_join=true&gad_source=1&gclid=cj0kcqiayewrbhddarisagp1mwtihv9kyf30tagb9bqxwvo1eydzfxza0qti9_idtnirpiou_htg1wwaal19ealw_wcb",
      "job_id": "7142463374956241921",
      "status_code": 200
    }
  ]
}
```
With our Fiverr Scraper, you can easily gather valuable public data from any Fiverr web page. Extract essential gig-related information, like gig price, ratings, or detailed descriptions to study your market and stay ahead of your competition. For any inquiries, feel free to reach out to our support team via live chat or email us at hello@oxylabs.io.