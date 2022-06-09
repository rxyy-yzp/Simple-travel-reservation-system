# Simple-travel-reservation-system
Simple travel reservation system(Operating system)
实现一个小型管理信息系统（题目可以自拟）  
掌握 Visual C++、C#、Qt、Java、PHP 或 Python 等任意语言访问数据库的方法, 设计和实现一个小型管理信息系统。要求具有数据的增加、删除、修改和查询的基本功能，并尽可能提供较多的查询功能，用户界面要友好。

如：基于MySQL，设计并实现一个简单的旅行预订系统。该系统涉及的信息有航班、大巴班车、宾馆房间和客户数据等信息。 其关系模式如下：  

FLIGHTS(String flightNum, int price, int numSeats, int numAvail, String FromCity, String ArivCity)    
HOTELS(String hotelNum, String location, int price, int numRooms, int numAvail)    
BUS(String BusNum, String location, int price, int numBus, int numAvail)  
CUSTOMERS(int custID, String custName)  
RESERVATIONS(String resvNum, String custID, int resvType, String resvKey)  

应用系统应完成如下基本功能：  
航班，大巴车，宾馆房间和客户基础数据的入库，更新（表中的属性也可以根据你的需要添加）。  
预定航班，大巴车，宾馆房间。（取消预定功能）  
查询航班，大巴车，宾馆房间，客户和预订信息。（取消预定功能）  
查询某个客户的旅行线路。  
其他任意你愿意加上的功能。  
