using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Tovar;

public partial class ProductEdit : Window
{
  //  StackPanel stackPanel = new StackPanel();
    
    public TextBlock textblock = new TextBlock();
    public TextBox textbox = new TextBox();
    public TextBox textbox2 = new TextBox();
    public List<Product> products = new List<Product>();
    public Button btnInsertOk = new Button();
    public ListBox list = new ListBox();
    public ProductEdit()
    {
        InitializeComponent();
/*
        products = new List<Product>()
            {
                new Product()
                {
                    nameProd="milk",
                    priceProd="1.33"
                }
            };
*/
      // prodList.Items = products;
    }

    public void BtnInsert_OnClick(object? sender, RoutedEventArgs e)
    {
      //  this.textbox.Text = null;
       // this.textbox2.Text = null;
        this.textblock.Text = "Введите наименование и цену товара";
        this.btnInsertOk.Content = "Ok";
        editing.Children.Add(this.textblock);
        editing.Children.Add(this.textbox);
        editing.Children.Add(this.textbox2);
        editing.Children.Add(this.btnInsertOk);
        btnInsertOk.Click += new EventHandler<RoutedEventArgs>(this.BtnInsertOk_OnClick);
     
    }

    //public void GetList()
    //{
    //    List<Product> localProducts = this.products;
    //    for (int i = 0; i< 100; i++)
    //    {
    //        localProducts.Add((new Product()
    //        {
    //            nameProd = "234234234",
    //            priceProd = "32412121233"
    //        }));
    //    }
    //    ProdList.Items = products;
    //}


    public void BtnInsertOk_OnClick(object? sender, RoutedEventArgs e)
    {
        products.Add(new Product()
        {
           nameProd = textbox.Text,
           priceProd = textbox2.Text
        });
        ProdList.Items = products;
        /// GetList();
      //  ProdList.Items.;
        editing.Children.Clear();
      
    }
}
