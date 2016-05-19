using StoreDatabase;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DataBinding
{
   /// <summary>
   /// Interaction logic for EditProductObject.xaml
   /// </summary>

   public partial class EditProductObject : System.Windows.Window
   {
      private Product product;

      public EditProductObject()
      {
         InitializeComponent();
      }

      private void cmdGetProduct_Click(object sender, RoutedEventArgs e)
      {
         int ID;
         if (Int32.TryParse(txtID.Text, out ID))
         {
            try
            {
               product = App.StoreDb.GetProduct(ID);
               gridProductDetails.DataContext = product;
            }
            catch
            {
               MessageBox.Show("Error contacting database.");
            }
         }
         else
         {
            MessageBox.Show("Invalid ID.");
         }
      }

      private void cmdUpdateProduct_Click(object sender, RoutedEventArgs e)
      {
         // Make sure update has taken place.
         FocusManager.SetFocusedElement(this, (Button)sender);

         MessageBox.Show(product.UnitCost.ToString());
      }


      private void cmdIncreasePrice_Click(object sender, RoutedEventArgs e)
      {
         product.UnitCost *= 1.1M;
      }


   }
}