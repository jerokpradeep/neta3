# dneta3-ALICEBLUE

# Official .Net SDK for Alice Blue API

The Official .Net library for communicating with the Alice Blue APIs.

Alice Blue .Net library provides an easy to use wrapper over the HTTPS APIs.

The HTTP calls have been converted to methods and JSON responses are wrapped into .Net-compatible objects.


* __Author: [CodiFi](https://github.com/jerokpradeep)__


## Installation
#### Use Visual Sudio code
```
NuGet\Install-Package neta3 -Version 1.1.2
```

### Install Client Library

Using NuGet
Execute in Tools » NuGet Package Manager » Package Manager Console

NuGet\Install-Package neta3 -Version 1.1.2

### Prerequisites
dneta3 Library Connect the  .NET Core 6.0,net6.0-android,net6.0-ios,net6.0-maccatalyst ,net6.0-macos,net6.0-tvos,net6.0-windows

### Add Header

```base
using neta3;
```


## Getting started with API

### Overview
There is AliceBlue in the whole library: `AliceBlue` . The `session_ID` static method is used to retrieve a Session ID from the alice blue server. A Session ID is valid until the trading account logout.
With a Session ID, you can instantiate an AliceBlue object. Ideally you only need to create a Session ID once every time login the trading account with password. After you have the Session ID, you can store it
separately for re-use.

### Create AliceBlue Object
1. You can create an AliceBlue object with your `UserID` and `API Key` and `log`.
```
AliceBlue Alice = new AliceBlue();
```

2. You can get a Session ID by running following command. Store it once a day. The API_Key available from Trading Application.

```
 string User_ID = "User_ID";
 string API_Key = "API_Key";
 ```
#### 3.Log File
#### Having log file set the log is true , otherwise false.
#### Check the log file  from Root directory(/bin/debug)

```
Boolean log = true;
```
#### 4.Initialize the session_ID
```base
 Console.WriteLine("The session :" + Alice.session_ID(User_ID, API_Key, log));
 ```

#### 5. You can run commands here to check your APIs
```
Console.WriteLine("The Holdings :" + Alice.Holdings());
Console.WriteLine("The Trade_book :" + Alice.Trade_book());
Console.WriteLine("The Fund :" + Alice.Funds());
Console.WriteLine("The profile :" + Alice.Profile());
Console.WriteLine("The order_book :" + Alice.Order_Book());
```

#### 6. Check the  Position_book(Open/Close) :
### various retention orders are available Day and End of Session Order
```
string ret = "DAY";
Console.WriteLine("The position_book :" + Alice.Position_book(ret));
```
#### 7. Order History response:
#### nestOrderNumber is a Unique number and get the number from Place_Order
```commandline
string nestOrderNumber = "220923000197349";
Console.WriteLine("The Order_histroy :" + Alice.Order_Histroy(nestOrderNumber));
```

#### 8. Cancle Order response :
#### Trading Symbol of the Instrument.A Trading symbol is an arrangement of characters
#### nestOrderNumber means Place Number
```commandline
string exch = "MCX";
string trading_symbol = "CRUDEOILM19JULFUT";
string nestOrderNumber = "221012000081870";
Console.WriteLine("The Cancle_Order :" + Alice.Cancel_Order(exch, nestOrderNumber, trading_symbol));
```

#### 9. Historical_Data response :
#### Exchange supports Right now, only, NSE, NFO, CDS and MCX .
#### Get the tokens from Contract master files or API
```commandline
string token= "1594";
string resolution = "D";
string from = "1660128489000";
string to = "1660221861000";
string exchange = "NSE";
Console.WriteLine("The Historical_Data :" + Alice.Historical_Data(token,resolution,from,to,exchange));
```
### 10.Place an order
#### Place limit, market, SL, SL-M, AMO, BO, CO orders
#### complexty include bracket orders or OCO (One Cancels the Other), cover orders and After Market Orders

```base
string complexty = "regular";
string discqty = "0";
string exch = "NSE";
string pcode = "cnc";
string prctyp = "l";
string price = "520.0";
string qty = "1";
string ret = "DAY";
string symbol_id = "3045";
string transtype = "buy";
string trigprice = "";
string ordertag = "order1";            
string trading_symbol = "SBIN-EQ";
Console.WriteLine("the PlaceOrder:" + Alice.Place_Order(complexty, discqty, exch, pcode, prctyp, price, qty, ret, symbol_id, trading_symbol, transtype, trigprice, ordertag));
```
### 11.Modify an order
#### Transcation Type means(BUY or SELL),while placing order the nestOrderNumber was generated 
#### Product code (MIS or CO or CNC or BO or NRML)
```base
string transtype = "buy";
string discqty = "0";
string exch = "nse";
string trading_symbol = "sbin-eq";
string nestOrderNumber = "221012000081870";
string prctyp = "l";
string price = "520.0";
string qty = "1";
string trigprice = "";
string filledquantity = "0";
Console.WriteLine("The Modify_Order:" + Alice.Modify_Order(transtype,discqty, exch, trading_symbol, nestOrderNumber, prctyp, price, qty,trigPrice, filledQuantity));
```
## Backlog

[Here](https://github.com/jerokpradeep) is an example of what I'm expecting while you are creating an issue.```

