using System;

namespace Shop_homework13_GeorgiTenov
{
    public class Page
    {
        public string Title { get; private set; }

        public string Content { get; private set; }

        public Page(string title,string content)
        {
            this.Title = title;

            this.Content = content;

        }

      
    }
}
