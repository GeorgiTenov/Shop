using System;
namespace Shop_homework13_GeorgiTenov
{
    public class Menu
    {
        public string Title { get; private set; }

        public PositionEnum Position { get; private set; }

        public Page[] Pages { get; private set; }

        public Menu(string title,PositionEnum position,int pagesNumber,Page page)
        {
            this.Title = title;

            this.Position = position;

            this.Pages = new Page[pagesNumber];
        }

        public void AddPage(Page page)
        {
            try
            {
                if (this.Pages != null)
                {
                    for (int i = 0; i < this.Pages.Length; i++)
                    {
                        if (this.Pages[i] == null)
                        {
                            this.Pages[i] = page;
                        }

                        break;
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Pages out of size");
            }
        }
    }
}
