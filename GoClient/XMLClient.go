package main

import (
	"time"
	"encoding/xml"
	"fmt"
	"net"
	"time"
)

type info struct {
	MyName string `xml:"MyName"`
	Phone  string `xml:"Phone"`
}

func sendInfo(conn net.Conn, i *info) bool {
	if buf, err := xml.Marshal(i); err == nil {
		conn.Write(buf)
		return true
	}
	return false
}
func main() {
	i := info{MyName: "Mr.Go", Phone: "1199"}
<<<<<<< HEAD

	conn, err := net.Dial("tcp", "127.0.0.1:7777")
	if err != nil {
		panic(err.Error())
	}

	defer conn.Close()
	for iCount := 0; iCount < 5; iCount++ {
		sendInfo(conn, &i)
		fmt.Printf("Send to server %03d.\n", iCount)
		time.Sleep(time.Second)
	}

=======
	for iCount := 0; iCount < 5; iCount++ {
		conn, err := net.Dial("tcp", "127.0.0.1:7777")
		if err != nil {
			panic(err.Error())
		}

		success := sendInfo(conn, &i)
		fmt.Printf("Send to server %03d. %s\n", iCount, success)
		time.Sleep(time.Second)
		conn.Close()
	}
>>>>>>> 83e5d866d4e2e9ecc764ba73189898aa8f0356a0
}
