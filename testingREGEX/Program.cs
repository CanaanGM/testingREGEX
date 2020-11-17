using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace testingREGEX
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tests = {

"111",



"3M",



"A50Roll",



"A50xx",



"A50yy",



"Activision Blizzard",



"Adidas",



"Adobe",



"AIG",



"Air France",



"Airbus",



"Alexion",



"Alibaba",



"Allianz",



"AllState",



"Alphabet",



"Amazon",



"Ambev",



"AMD",



"Amercia",



"American Airlines",



"AMEX",



"Amgen",



"AON",



"Apple",



"ArcherDan",



"AstraZeneca",



"AU200xx",



"AU200yy",



"AUDCAD",



"AUDCHF",



"AUDCNH",



"AUDHKD",



"AUDJPY",



"AUDMXN",



"AUDNZD",



"AUDSGD",



"AUDUSD",



"AUDZAR",



"AUS200Roll",



"Aviva",



"Azul",



"Bachoco",



"BaeSystems",



"BancoCol",



"Barclays",



"BAT",



"Bayer",



"BCHUSD",



"BerkshireH",



"Biogen",



"BMW",



"BNP",



"Boeing",



"Booking",



"BP",



"Bradesco",



"BRENT",



"Broadcom",



"BT",



"BTCUSD",



"CADCHF",



"CADJPY",



"CADMXN",



"CADSGD",



"CADZAR",



"Campbell Soup",



"CAN60Roll",



"Canopy",



"Carnival",



"CAT",



"CCFemsa",



"Cemex",



"CF",



"Chevron",



"Chewy",



"CHFJPY",



"CHFMXN",



"CHFRUB",



"CHFSGD",



"CHFZAR",



"CHshares",



"Cisco",



"Citigroup",



"Clorox",



"CLxx",



"CLyy",



"CLzz",



"CNHJPY",



"CocaCola",



"COCOA",



"COFFEE",



"COFFEExx",



"COFFEEyy",



"CopaHolding",



"Corning",



"Cosan",



"Costco",



"COTTON",



"COTTONxx",



"COTTONyy",



"Cresud",



"Crowdstrike",



"CZKMXN",



"CZKZAR",



"Daimler",



"DE30Roll",



"DE30xx",



"DE30yy",



"Deere",



"Delta",



"Despergar",



"Diageo",



"Disney",



"DKKMXN",



"DKKZAR",



"Docusign",



"DraftKings",



"Dropbox",



"Earts",



"EasyJet",



"eBay",



"Ecopetrol",



"Edenor",



"EON",



"ESP35Roll",



"ESP35xx",



"ESP35yy",



"ETHUSD",



"EU50Roll",



"EURAUD",



"EURCAD",



"EURCHF",



"EURCNH",



"EURCZK",



"EURDKK",



"EURGBP",



"EURHKD",



"EURHUF",



"EURILS",



"EURJPY",



"EURMXN",



"EURNOK",



"EURNZD",



"EURPLN",



"EURRUB",



"EURSEK",



"EURSGD",



"EURTRY",



"EURUSD",



"EURZAR",



"Expedia",



"Exxon",



"Facebook",



"Farfetch",



"FedEx",



"Ferrari",



"Fitbit",



"Fox",



"FR40xx",



"FR40yy",



"FRA40Roll",



"GameStop",



"GBPAUD",



"GBPCAD",



"GBPCHF",



"GBPCNH",



"GBPEUR",



"GBPHKD",



"GBPJPY",



"GBPMXN",



"GBPNOK",



"GBPNZD",



"GBPPLN",



"GBPRUB",



"GBPSEK",



"GBPSGD",



"GBPTRY",



"GBPUSD",



"GBPZAR",



"GCxx",



"GCyy",



"Generac",



"Gerdau",



"Gilead Sciences",



"GlaxoSmith",



"Glencore",



"Globant",



"Goldmans",



"GrupoAreo",



"GrupoAval",



"HERO",



"HGxx",



"HGyy",



"HGzz",



"HK50Roll",



"HK50xx",



"HK50yy",



"HKDCNH",



"HKDJPY",



"HKDMXN",



"HKDZAR",



"HomeDepot",



"Hormel Foods",



"HSBC",



"Hyatt",



"IAG",



"IBM",



"ICAP",



"INDIA50Roll",



"INDIA50xx",



"INDIA50yy",



"Intel",



"Iridium",



"Itau",



"ITV",



"J&J",



"JP225Roll",



"JPMorgan",



"Jumia",



"JustEat",



"Kering",



"Kimberly-Clark Corp",



"LCOxx",



"LCOyy",



"LCOzz",



"LegalGen",



"Lloyds",



"LOreal",



"LTCUSD",



"Lufthansa",



"LVMH",



"Marriott",



"MarvellTech",



"Mastercard",



"McDonalds",



"Mercadolibre",



"Merck",



"MGM",



"Micron",



"Microsoft",



"Moderna",



"Morrison",



"Mosaic",



"MS",



"MXNJPY",



"MXNZAR",



"NatGrid",



"Nautilus",



"NET25Roll",



"Netflix",



"newSymbol",



"NGxx",



"NGyy",



"NGzz",



"NIKE",



"Nikola",



"NIO",



"NOKJPY",



"NOKMXN",



"NOKSEK",



"NOKSGD",



"NOKZAR",



"NOR25Roll",



"NortonLife",



"NorwCruise",



"Novartis",



"NVIDIA",



"NZDCAD",



"NZDCHF",



"NZDCNH",



"NZDJPY",



"NZDMXN",



"NZDSGD",



"NZDUSD",



"NZDZAR",



"ORANGE",



"P&G",



"PayPal",



"Peloton",



"Pepsi",



"Petrobras",



"Petrolera",



"Pfizer",



"PLNMXN",



"PLNZAR",



"Progressive",



"Prudential",



"Qualcom",



"RBS",



"ReckittBenckiser",



"Regeneron",



"RioTinto",



"Roku",



"RollsRoyce",



"RoyalMail",



"RUSS2000",



"RyanAir",



"SA40Roll",



"Salesforce",



"Santander",



"SEKJPY",



"SEKMXN",



"SEKZAR",



"SGDJPY",



"SGDMXN",



"SGDZAR",



"Shell",



"Shopify",



"SING30xx",



"SING30yy",



"SIxx",



"SIyy",



"Slack",



"Sony",



"Spotify",



"Square",



"Starbucks",



"Stoneco",



"SUGAR",



"Target",



"TaylorWimp",



"Teladoc",



"Televisa",



"Tenaris",



"Tesco",



"Tesla",



"TGS",



"The Kroger Company",



"Tigo",



"TMobile",



"Travelers",



"TRYMXN",



"TRYZAR",



"Twitter",



"UBER",



"UK100Roll",



"UK100xx",



"UK100yy",



"UnHealth",



"United Airlines",



"UnTech",



"US30Roll",



"US30xx",



"US30yy",



"US500Roll",



"US500xx",



"US500yy",



"USCOCOA",



"USCOCOAxx",



"USCOCOAyy",



"USDAED",



"USDCAD",



"USDCHF",



"USDCNH",



"USDCNY",



"USDCZK",



"USDDKK",



"USDHKD",



"USDHUF",



"USDILS",



"USDINDEXxx",



"USDINDEXyy",



"USDINR",



"USDJPY",



"USDKES",



"USDMXN",



"USDNOK",



"USDPLN",



"USDRUB",



"USDSAR",



"USDSEK",



"USDSGD",



"USDTRY",



"USDZAR",



"UT100Roll",



"UT100xx",



"UT100yy",



"Vale",



"Verizon",



"Vertex",



"VGalactic",



"Visa",



"VIXRoll",



"VIXxx",



"VIXyy",



"Vodafone",



"VW",



"Walmart",



"WellsFargo",



"WTI",



"XAGEUR",



"XAGUSD",



"XAUEUR",



"XAUTRY",



"XAUUSD",



"XPDUSD",



"XPTUSD",



"XRPUSD",



"ZARMXN",



"Zoom Video Communication",
"CHINA50V0",

"CHINA50X0",

"Activision",

"AU200Z0",

"AU200U0",

"USOILF1",

"USOILV0",

"USOILZ0",

"COFFEEU0",

"COFFEEZ0",

"COTTONV0",

"COTTONZ0",

"DE30U0",

"DE30Z0",

"ESP35V0",

"ESP35X0",

"FRA40V0",

"FRA40X0",

"GCZ0",

"GCQ0",

"HGZ0",

"HGU0",

"HK50N0",

"HK50Q0",

"INDIA50V0",

"INDIA50X0",

"UKOILF1",

"UKOILX0",

"UKOILG1",

"NGX0",

"NGZ0",

"SING30V0",

"SING30X0",

"SIU0",

"SIZ0",

"UK100Z0",

"UK100U0",

"US30U0",

"US30Z0",

"US500U0",

"US500Z0",

"USCOCOAH1",

"USCOCOAZ0",

"USDINDEXZ0",

"USDINDEXU0",

"UT100U0",

"UT100Z0",

"VIXV0",

"VIXX0"





            };

            foreach (string symbol in tests)
            {
                string group = GetGroup(symbol.ToUpper());

                if (group.Length > 5 && group == symbol)
                    if (!StringEndsWithMoreThanOneDigit(group))
                        group = GetGroupByRegex(symbol);


                AddToGroup(group, symbol);

            }
            Console.ReadLine();

            //Console.WriteLine("TESTING REGEX FOR THE SYMBOLS(CFD)");
            //Console.WriteLine("=== === === === === === === === ===  ===  ===  === === === === ===");
            //// Get the current NumberFormatInfo object to build the regular 
            //// expression pattern dynamically.
            //NumberFormatInfo nfi = NumberFormatInfo.CurrentInfo;

            //// Define the regular expression pattern.
            ////string pattern;
            ////pattern = @"^[A-Z][^\d]+";

            ////Regex rgx = new Regex(pattern);

            //// Define some test strings.

            //// Check each test string against the regular expression.
            //foreach (string test in tests)
            //{
            //    //if (rgx.IsMatch(test))
            //    {
            //        string text = "ImageDimension=655x0;ThumbnailDimension=0x0";


            //        Regex pattern = new Regex(@"^[A-Z][^\d](?<imageWidth>[A-Z][^\d])");
            //        //Regex pattern = new Regex(@"ImageDimension=(?<imageWidth>\d+)x(?<imageHeight>\d+);ThumbnailDimension=(?<thumbWidth>\d+)x(?<thumbHeight>\d+)");
            //        Match match = pattern.Match(test.ToUpper());
            //        int imageWidth = int.Parse(match.Groups["imageWidth"].Value);

            //        //string canan = Regex.Replace(test, pattern,(e => e.Name));
            //        //string[] canaan = Regex.Split(test, pattern);
            //        //for (int i = 0; i < 2; i++)
            //        //{
            //        //    Console.WriteLine($"{test} taken of {canaan[1]}");
            //        //}
            //        //Console.WriteLine("{0} is a currency value.", test);
            //        //Console.WriteLine("*** *** *** *** *** *** *** *** *** ***");

            //    }

            //    //else
            //    //{
            //    //    Console.WriteLine("{0} is not a currency value.", test);
            //    //    Console.WriteLine("*** *** *** *** *** *** *** *** *** ***");
            //    //}
            //}
        }
        static Dictionary<string, List<string>> groupsssss = new Dictionary<string, List<string>>();
        private static void AddToGroup(string group, string symbol)
        {
            if (groupsssss.ContainsKey(group))
                groupsssss[group].Add(symbol);
            else
            {
                List<string> lst = new List<string>();
                lst.Add(symbol);
                groupsssss.Add(group, lst);

            }

        }

        private static bool StringEndsWithMoreThanOneDigit(string group)
        {
            var array = Regex.Matches(group, @"\D+|\d+")
                           .Cast<Match>()
                           .Select(m => m.Value)
                           .ToArray();
            if (array.Length == 0)
                return false;
            int val = 0;
            if (int.TryParse(array[array.Length - 1], out val))
            {
                if (val < 10)
                    return false;
                return true;
            }
            else
                return true;
        }

        private static string GetGroupByRegex(string test)
        {
            Regex pattern = new Regex(@"^(?<contractname>[A-Z]+)[^\d]+");
            Match match = pattern.Match(test.ToUpper());
            return match.Groups["contractname"].Value;
        }

        private static string GetGroup2(string symbol, string[] tests)
        {
            string ret = symbol;
            char[] vs = symbol.ToCharArray();
            for (int i = 0; i < vs.Length; i++)
            {
                int count = CountCharInList(i, vs[i], tests);
                if (count > 2)
                    ret = symbol.Substring(0, count);
            }
            return ret;


        }

        private static int CountCharInList(int index, char v, string[] tests)
        {
            int retCount = 0;
            foreach (string test in tests)
            {
                if (test[index] == v)
                    retCount++;
            }
            return retCount;
        }



        private static string GetGroup(string test)
        {
            string ret = test;
            bool alphapassed = false, numericpassed = false;
            char[] vs = test.ToCharArray();
            for (int i = 0; i < vs.Length; i++)
            {
                if (IsAlpha(vs[i]))
                    alphapassed = true;
                if (IsNumeric(vs[i]))
                    numericpassed = true;
                if (alphapassed && numericpassed)
                {
                    if (IsAlpha(vs[i]))
                    {
                        ret = test.Substring(0, i);
                        break;
                    }
                }
            }

            return ret;
        }

        private static bool IsAlpha(char ch)
        {
            return (ch >= 65 && ch <= 90);

        }
        private static bool IsNumeric(char ch)
        {
            return (ch >= 48 && ch <= 57);

        }
        // The example displays the following output:
        //       -42 is a currency value.
        //       19.99 is a currency value.
        //       0.001 is not a currency value.
        //       100 USD is not a currency value.
        //       .34 is a currency value.
        //       0.34 is a currency value.
        //       1,052.21 is not a currency value.
        //       $10.62 is a currency value.
        //       +1.43 is a currency value.
        //       -$0.23 is a currency value.
    }
}
