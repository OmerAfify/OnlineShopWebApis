﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShopWebAPIs.Interfaces.IGeneralRepository;
using OnlineShopWebAPIs.Interfaces.IUnitOfWork;
using OnlineShopWebAPIs.Models;
using OnlineShopWebAPIs.Models.DBContext;
using OnlineShopWebAPIs.Repository.GeneralRepository;

namespace OnlineShopWebAPIs.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly OnlineShopDbContext _context;
        
        public IGeneralRepository<Product> Products { get; }
        public IGeneralRepository<Category> Categories { get; }
        public IGeneralRepository<Review> Reviews { get; }


        public UnitOfWork(OnlineShopDbContext context)
        {
            _context = context;

            Products = new GeneralRepository<Product>(context);
            Categories = new GeneralRepository<Category>(context);
            Reviews = new GeneralRepository<Review>(context);
        }


        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}