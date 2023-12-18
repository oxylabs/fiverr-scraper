package main

import (
	"bytes"
	"encoding/json"
	"fmt"
	"io/ioutil"
	"net/http"
)

func main() {
	const Username = "YOUR_USERNAME"
	const Password = "YOUR_PASSWORD"

	payload := map[string]string{
		"source": "universal",
		"url": "https://www.fiverr.com/categories/programming-tech?source=category_tree&utm_source=google&utm_medium=cpc-brand&utm_campaign=g_row-en_brand&utm_term=one-fiverr_(exact)&utm_content=adid^553700574654^keyword^fiverr^placement^^device^c&caid=406997588&agid=33518326868&ad_id=553700574654&kw=fiverr&lpcat=br_general&show_join=true&gad_source=1&gclid=cj0kcqiayewrbhddarisagp1mwtihv9kyf30tagb9bqxwvo1eydzfxza0qti9_idtnirpiou_htg1wwaal19ealw_wcb",
	}

	jsonValue, _ := json.Marshal(payload)

	client := &http.Client{}
	request, _ := http.NewRequest("POST",
		"https://realtime.oxylabs.io/v1/queries",
		bytes.NewBuffer(jsonValue),
	)

	request.SetBasicAuth(Username, Password)
	response, _ := client.Do(request)

	responseText, _ := ioutil.ReadAll(response.Body)
	fmt.Println(string(responseText))
}