﻿using Bookstore_AspDotNET_MVC.Data;
using Bookstore_AspDotNET_MVC.DTO;
using Bookstore_AspDotNET_MVC.IService;
using Bookstore_AspDotNET_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore_AspDotNET_MVC.Service
{
    public class DiscountService : IDiscountService
    {
        private readonly BOOKSTOREContext _context;

        public DiscountService(BOOKSTOREContext context)
        {
            _context = context;
        }

        public DiscountPagineDTO GetDiscounts(int currentPage, int status = -1)
        {
            int maxRows = 10;
            List<Discount> discounts;

            //nếu status =-1 thì lấy tất cả đơn hàng (default)
            if (status == -1)
            {
                discounts = _context.Discounts.Include(d=>d.BookDiscounts).ToList();
            }
            else//ngược lại thì lấy theo status đã yêu cầu
            {
                discounts = _context.Discounts.Include(d => d.BookDiscounts).Where(d => d.Status == status).ToList();
            }

            DiscountPagineDTO discountPagine= new DiscountPagineDTO();

            discountPagine.Discounts = discounts.OrderBy(d => d.StartTime)
                        .Skip((currentPage - 1) * maxRows)
                        .Take(maxRows).ToList();

            double pageCount = (double)((decimal)discounts.Count() / Convert.ToDecimal(maxRows));

            discountPagine.Status = status;

            discountPagine.PageCount = (int)Math.Ceiling(pageCount);

            discountPagine.CurrentPageIndex = currentPage;

            return discountPagine;
        }

        public async Task<bool> updateDiscount(Discount discount)
        {
            _context.Update(discount); 
             await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> addDiscount(Discount discount)
        {
            _context.Add(discount);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> deleteDiscount(Discount discount)
        {
            try
            {
                _context.Remove(discount);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Discount findDiscountById(long id)
        {
            return _context.Discounts.Find(id);
        }


        //Book Discount
        public Discount findDiscountWithBookById(long id)
        {
            return _context.Discounts.Include(d=>d.BookDiscounts)
                                      .ThenInclude(bd=>bd.IdBookNavigation).First(b=>b.IdDiscount==id);
        }


        public List<Book> getAllBookNotHaveDiscount(long id)
        {
            List<long> idBooks= _context.BookDiscounts.Where(bd => bd.IdDiscount == id).Select(bd => bd.IdBook).ToList();

            List<Book> listBook = _context.Books.Where(b => !idBooks.Contains(b.IdBook)).ToList();

            return listBook;
        }

        public BookDiscount findBookDiscountById( long idBook,long idDiscount)
        {
            return _context.BookDiscounts.Find(idBook, idDiscount);
        }

        public async Task<bool> addBookDiscount(BookDiscount bookDiscount)
        {
            _context.Add(bookDiscount);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> deleteBookDiscount(BookDiscount bookDiscount)
        {
            try
            {
                _context.Remove(bookDiscount);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
