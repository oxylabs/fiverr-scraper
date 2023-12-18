<?php

$params = [
    'source' => 'universal',
    'url' => 'https://www.fiverr.com/categories/programming-tech?source=category_tree&utm_source=google&utm_medium=cpc-brand&utm_campaign=g_row-en_brand&utm_term=one-fiverr_(exact)&utm_content=adid^553700574654^keyword^fiverr^placement^^device^c&caid=406997588&agid=33518326868&ad_id=553700574654&kw=fiverr&lpcat=br_general&show_join=true&gad_source=1&gclid=cj0kcqiayewrbhddarisagp1mwtihv9kyf30tagb9bqxwvo1eydzfxza0qti9_idtnirpiou_htg1wwaal19ealw_wcb'];

$ch = curl_init();

curl_setopt($ch, CURLOPT_URL, "https://realtime.oxylabs.io/v1/queries");
curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);
curl_setopt($ch, CURLOPT_POSTFIELDS, json_encode($params));
curl_setopt($ch, CURLOPT_POST, 1);
curl_setopt($ch, CURLOPT_USERPWD, "user" . ":" . "pass1");

$headers = array();
$headers[] = "Content-Type: application/json";
curl_setopt($ch, CURLOPT_HTTPHEADER, $headers);

$result = curl_exec($ch);
echo $result;

if (curl_errno($ch)) {
    echo 'Error:' . curl_error($ch);
}
curl_close ($ch);
?>