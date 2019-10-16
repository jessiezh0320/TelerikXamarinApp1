using System;
using System.Collections.Generic;
using System.Text;

namespace TelerikXamarinApp1.Portable
{
   public  class ViewModel
    {
        public ViewModel()
        {
            this.Source = new List<Book>{
            new Book{ Title = "The Fault in Our Stars ",  Author = "John Green"},
            new Book{ Title = "Divergent",  Author = "Veronica Roth"},
            new Book{ Title = "Gone Girl",  Author = "Gillian Flynn"},
            new Book{ Title = "Clockwork Angel",  Author = "Cassandra Clare"},
            new Book{ Title = "The Martian",  Author = "Andy Weir"},
            new Book{ Title = "Ready Player One",  Author = "Ernest Cline"},
            new Book{ Title = "The Lost Hero",  Author = "Rick Riordan"},
            new Book{ Title = "All the Light We Cannot See",  Author = "Anthony Doerr"},
            new Book{ Title = "Cinder",  Author = "Marissa Meyer"},
            new Book{ Title = "Me Before You",  Author = "Jojo Moyes"},
            new Book{ Title = "The Night Circus",  Author = "Erin Morgenstern"},
        };
        }

        public List<Book> Source { get; set; }
    }
}
