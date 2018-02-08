package main

import (
	"encoding/xml"
	"fmt"
)

type info struct {
	MyName string `xml:"MyName"`
	Phone  string `xml:"Phone"`
}

func main() {
	ts := `<?xml version="1.0"?>
	<Info xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
	  <MyName>Johe Smith</MyName>
	  <Phone>1188</Phone>
	</Info>`
	var i info
	buf := []byte(ts)
	err := xml.Unmarshal(buf, &i)
	if err == nil {
		fmt.Println(i)
	}

}
