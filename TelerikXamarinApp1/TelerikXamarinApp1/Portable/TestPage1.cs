using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.XamarinForms.DataControls;
using Telerik.XamarinForms.DataControls.ListView;
using Xamarin.Forms;

namespace TelerikXamarinApp1.Portable
{
	public class TestPage1 : ContentPage
	{
		public TestPage1 ()
		{
            var listView = new RadListView
            {
                BackgroundColor = Color.White,
                ItemsSource = new ViewModel().Source,
                ItemTemplate = new DataTemplate(() =>
                {
                    var cell = new ListViewTextCell
                    {
                        TextColor = Color.Black,
                        DetailColor = Color.Gray,
                    };

                    cell.SetBinding(ListViewTextCell.TextProperty, new Binding(nameof(Book.Title)));
                    cell.SetBinding(ListViewTextCell.DetailProperty, new Binding(nameof(Book.Author)));

                    return cell;
                }),
                LayoutDefinition = new ListViewLinearLayout { ItemLength = 70 },
            };

            Content = new StackLayout {
				Children = {
					listView
				}
			};
		}
	}
}