package main

import (
	"encoding/xml"
	"fmt"
	"net"
	"os"
)

type info struct {
	MyName string `xml:"MyName"`
	Phone  string `xml:"Phone"`
}

func resolveXML(buf []byte, i *info) error {
	err := xml.Unmarshal(buf, &i)
	return err
}

func handleClient(conn net.Conn) {
	//conn.SetReadDeadline(time.Now().Add(5 * time.Minute))
	defer conn.Close()
	buf := make([]byte, 65535)
	var i info
	if l, err := conn.Read(buf); l > 0 && err == nil {
		fmt.Printf("Read %d bytes\n", l)
		dt := buf[0 : l-1]
		if err := resolveXML(dt, &i); err != nil {
			fmt.Println(i)
		} else {
			fmt.Println(err.Error())
		}
	}
}

func main() {
	servicePort := "0.0.0.0:7777"

	listener, err := net.Listen("tcp", servicePort)
	checkerr(err)
	for {
		conn, err := listener.Accept()
		fmt.Println("Test connection...")
		if err != nil {
			panic("Error accept:" + err.Error())
		}
		fmt.Println("Client connect.", conn.RemoteAddr())
		go handleClient(conn)
	}
}

func checkerr(err error) {
	if err != nil {
		fmt.Fprintf(os.Stderr, "Fatal error: %s", err.Error())
		os.Exit(1)
	}
}
