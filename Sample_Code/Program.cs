using neta3;
namespace sample_code
{

    public class Main_class
    {


        public static void Main(string[] args)
        {
            //[Initialize the Object]

            AliceBlue Alice = new AliceBlue();

            #region [Session_ID]
            string User_ID = "";
            string API_Key = "";
            Boolean log = true; //Log file 
            Console.WriteLine("The session :" + Alice.session_ID(User_ID, API_Key, log));
            #endregion

            #region[Holding,Trade_Book,Fund,Profile,Order_Book]
            Console.WriteLine("The Holdings :" + Alice.Holdings());
            Console.WriteLine("The Trade_book :" + Alice.Trade_book());
            Console.WriteLine("The Fund :" + Alice.Funds());
            Console.WriteLine("The profile :" + Alice.Profile());
            Console.WriteLine("The order_book :" + Alice.Order_Book());
            #endregion


            #region[Historical_Data]
            string token = "1594";
            string resolution = "D";
            string from = "1660128489000";
            string to = "1660221861000";
            string exchange = "NSE";
            Console.WriteLine("The Historical_Data :" + Alice.Historical_Data(token, resolution, from, to, exchange));
            #endregion

            #region[Position_Book]
            string ret = "DAY";
            Console.WriteLine("The Position_Book:" + Alice.Position_book(ret));
            #endregion

            #region [Place_Order]
            //string complexty = "regular";
            //string discqty = "0";
            //string exch = "NSE";
            //string pcode = "cnc";
            //string prctyp = "l";
            //string price = "520.0";
            //string qty = "1";
            //string ret = "DAY";
            //string symbol_id = "3045";
            //string transtype = "buy";
            //string trigprice = "";
            //string ordertag = "order1";            
            //string trading_symbol = "SBIN-EQ";
            //Console.WriteLine("the PlaceOrder:" + Alice.Place_Order(complexty, discqty, exch, pcode, prctyp, price, qty, ret, symbol_id, trading_symbol, transtype, trigprice, ordertag));
            #endregion

            #region [Order_Histroy]
            string nestOrderNumber = "221012000096119";
            Console.WriteLine("The Order_histroy :" + Alice.Order_Histroy(nestOrderNumber));
            #endregion

            #region [Cancle_Order]
            //string exch = "NSE";
            //string nestOrderNumber = "221012000081870";
            //string trading_symbol = "SBIN-EQ";
            //Console.WriteLine("The Cancle Order:" + Alice.Cancel_Order( exch,nestOrderNumber,trading_symbol));
            #endregion



            #region[Modify_Order]
            //string transtype = "buy";
            //string discqty = "0";
            //string exch = "nse";
            //string trading_symbol = "sbin-eq";
            //string nestOrderNumber = "221012000081870";
            //string prctyp = "l";
            //string price = "520.0";
            //string qty = "1";
            //string trigprice = "";
            //string filledquantity = "0";
            //Console.WriteLine("The Modify_Order:" + Alice.Modify_Order(transtype,discqty, exch, trading_symbol, nestOrderNumber, prctyp, price, qty,trigPrice, filledQuantity));
            #endregion
        }
    }
}

