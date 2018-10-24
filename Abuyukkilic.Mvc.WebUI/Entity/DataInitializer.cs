﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abuyukkilic.Mvc.WebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>() {
               new Category() {Name = "Kamera", Description = "Kamera Ürünleri" },
               new Category() {Name = "Bilgisayar", Description = "Bilgisayar Ürünleri" },
               new Category() {Name = "Elektronik", Description = "Elektronik Ürünleri" },
               new Category() {Name = "Telefon", Description = "Telefon Ürünleri" },
               new Category() {Name = "Beyaz Eşya", Description = "Beyaz Eşya Ürünleri" }
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();


            var urunler = new List<Product>() {
               new Product() {Name = "FotoMakina1", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 300 , Stock = 20, IsApproved = true , CategoryId = 1 , IsHome = true},
               new Product() {Name = "FotoMakina2", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 400 , Stock = 80, IsApproved = true , CategoryId = 1 , IsHome = true},
               new Product() {Name = "FotoMakina3", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 500 , Stock = 90, IsApproved = true , CategoryId = 1, IsHome = true},
               new Product() {Name = "FotoMakina4", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 600 , Stock = 100, IsApproved = false , CategoryId = 1},
               new Product() {Name = "FotoMakina5", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 700 , Stock = 180, IsApproved = false , CategoryId = 1},


               new Product() {Name = "Bilgisayar1", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 300 , Stock = 20, IsApproved = true , CategoryId = 2, IsHome = true},
               new Product() {Name = "Bilgisayar2", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 400 , Stock = 80, IsApproved = true , CategoryId = 2, IsHome = true},
               new Product() {Name = "Bilgisayar3", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 500 , Stock = 90, IsApproved = true , CategoryId = 2, IsHome = true},
               new Product() {Name = "Bilgisayar4", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 600 , Stock = 100, IsApproved = false , CategoryId = 2},
               new Product() {Name = "Bilgisayar5", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 700 , Stock = 180, IsApproved = false , CategoryId = 2},


               new Product() {Name = "Elektronik1", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 300 , Stock = 20, IsApproved = true , CategoryId = 3, IsHome = true},
               new Product() {Name = "Elektronik2", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 400 , Stock = 80, IsApproved = true , CategoryId = 3, IsHome = true},
               new Product() {Name = "Elektronik3", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 500 , Stock = 90, IsApproved = true , CategoryId = 3, IsHome = true},
               new Product() {Name = "Elektronik4", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 600 , Stock = 100, IsApproved = false , CategoryId = 3},
               new Product() {Name = "Elektronik5", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 700 , Stock = 180, IsApproved = false , CategoryId = 3},

               new Product() {Name = "Telefon1", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 300 , Stock = 20, IsApproved = true , CategoryId = 4, IsHome = true},
               new Product() {Name = "Telefon2", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 400 , Stock = 80, IsApproved = true , CategoryId = 4, IsHome = true},
               new Product() {Name = "Telefon3", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 500 , Stock = 90, IsApproved = true , CategoryId = 4, IsHome = true},
               new Product() {Name = "Telefon4", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 600 , Stock = 100, IsApproved = false , CategoryId = 4},
               new Product() {Name = "Telefon5", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 700 , Stock = 180, IsApproved = false , CategoryId = 4},


               new Product() {Name = "Beyaz Eşya1", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 300 , Stock = 20, IsApproved = true , CategoryId = 5},
               new Product() {Name = "Beyaz Eşya2", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 400 , Stock = 80, IsApproved = true , CategoryId = 5},
               new Product() {Name = "Beyaz Eşya3", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 500 , Stock = 90, IsApproved = true , CategoryId = 5},
               new Product() {Name = "Beyaz Eşya4", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 600 , Stock = 100, IsApproved = false , CategoryId = 5},
               new Product() {Name = "Beyaz Eşya5", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam interdum neque ut metus tincidunt consequat. Etiam vestibulum non magna nec iaculis. Ut semper gravida hendrerit. Donec malesuada ac tellus quis luctus. Cras ornare, ligula vel pulvinar convallis, eros sem tempor magna, in consequat quam lorem in mi. Maecenas et felis magna. Suspendisse ut libero dolor. Praesent vitae tristique massa, nec porttitor nisl. Aliquam condimentum urna ut neque dapibus, id malesuada tortor placerat.Morbi finibus venenatis augue, at ultricies nibh accumsan at. Pellentesque et erat augue. Ut leo sem, tincidunt vitae neque malesuada, cursus lobortis libero. Quisque id maximus diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor sagittis ligula ultricies congue vel sed dolor. Nulla malesuada orci vitae euismod laoreet. Vestibulum vitae facilisis ante, quis imperdiet elit. Praesent sodales dictum tortor nec blandit. Vivamus varius nunc nec risus molestie ornare laoreet quis turpis. Pellentesque id pretium nisl. Nullam tellus mi, tristique fringilla hendrerit sed, porttitor non dolor." , Price = 700 , Stock = 180, IsApproved = false , CategoryId = 5}

            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();







            base.Seed(context);
        }
    }
}