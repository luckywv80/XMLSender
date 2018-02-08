package main

import (
	"encoding/xml"
	"fmt"
	"net"
)

type info struct {
	MyName string `xml:"MyName"`
	Phone  string `xml:"Phone"`
}

func sendInfo(conn net.Conn, i *info) bool {
	if buf, err := xml.Marshal(i); err != nil {
		conn.Write(buf)
		return true
	}
	return false
}
func main() {
	i := info{MyName: "Mr.Go", Phone: "1199"}

	conn, err := net.Dial("tcp", "127.0.0.1:7777")
	if err != nil {
		for iCount := 0; iCount < 5; iCount++ {
			sendInfo(conn, &i)
			fmt.Printf("Send to server %03d.\n", iCount)
		}
	} else {
		panic(err.Error())
	}

}
