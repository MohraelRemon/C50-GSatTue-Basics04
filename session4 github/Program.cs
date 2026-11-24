namespace session4_github
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            double[] Prices = [25.5, 40.0, 33.75];
            Console.WriteLine(Prices[1]);
            #endregion
            #region Q2
            int[,] ShelfCopies =
            {
                {3,5 },
                {1,4 }
            };
            Console.WriteLine(ShelfCopies[1,0]);

            #endregion
            #region Q3
            void PrintWelcome()
            {
                Console.WriteLine("Welcome to the Library ");
            }
            PrintWelcome();
            #endregion
            #region Q4
            void PrintBookTitle(String title)
            {
                Console.WriteLine("Book title :"+title);

            }
            PrintBookTitle("Clean code");
            #endregion
            #region Q5
           
            void AddBonusPages(int pages)
            {
                pages += 50;
            }

            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages);


            #endregion
            #region Q6
            void ApplyDiscount(double[] prices)
            {
                prices[0] -= 5;
            }

            double[] prices = { 25.5, 40.0 };
            ApplyDiscount(prices);
            Console.WriteLine(prices[0]); // هيطبع 20.5
            #endregion
            #region Q7
            void AddBonusPagesByRef(ref int pages2)
            {
                pages2 += 50;
            }

            int pages2 = 400;
            AddBonusPagesByRef(ref pages2);
            Console.WriteLine(pages2);
            #endregion
            #region Q8
            void ReplaceArray(ref double[] prices2)
            {
                prices2 = new double[] { 10.0, 12.5, 15.0 };
            }

            double[] prices2 = { 25.5, 40.0 };
            ReplaceArray(ref prices2);
            Console.WriteLine(prices2.Length);
            #endregion
            #region Q9
           
            bool TryGetPrice(string title, out double price)
            {
                if (title == "Clean Code")
                {
                    price = 25.5;
                    return true;
                }

                price = 0;
                return false;
            }

            if (TryGetPrice("Clean Code", out double bookPrice))
            {
                Console.WriteLine($"Price: {bookPrice}");
            }

            #endregion
            #region Q10
            void PrintBookInfo(string title, int pages = 300)
            {
                Console.WriteLine($"Title: {title}, Pages: {pages}");
            }

            PrintBookInfo("Clean Code");       // هيستخدم القيمة الافتراضية 300
            PrintBookInfo("C# in Depth", 900); // هيستخدم 900
            #endregion
            #region Q11
            PrintBookInfo(pages: 450, title: "The Pragmatic Programmer");
            #endregion
            #region Q12
            PrintBookInfo(pages: 450, title: "The Pragmatic Programmer");
            #endregion
            
        }

    }
}
