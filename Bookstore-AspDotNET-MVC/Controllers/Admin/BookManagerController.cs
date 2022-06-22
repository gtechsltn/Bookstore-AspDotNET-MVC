﻿using Bookstore_AspDotNET_MVC.Data;
using Bookstore_AspDotNET_MVC.DTO;
using Bookstore_AspDotNET_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore_AspDotNET_MVC.Controllers.Admin
{
    public class BookManagerController : Controller
    {
        private readonly ILogger<BookManagerController> _logger;
        private readonly BOOKSTOREContext _context;

        public BookManagerController(ILogger<BookManagerController> logger, BOOKSTOREContext context)
        {
            _logger = logger;
            _context = context;
        }
        // GET: BookManagerController
        public ActionResult Index(int currentPageIndex=1)
        {
            return View("/Views/Admin/BookManager.cshtml",this.GetBooks(currentPageIndex));
        }

        private BookPagineDTO GetBooks(int currentPage)
        {
            int maxRows = 10;
            var books = _context.Books.ToList();

            BookPagineDTO bookPagine = new BookPagineDTO();
            bookPagine.Books = books.OrderBy(book => book.IdBook)
                        .Skip((currentPage - 1) * maxRows)
                        .Take(maxRows).ToList();

            double pageCount = (double)((decimal)books.Count() / Convert.ToDecimal(maxRows));

            bookPagine.PageCount = (int)Math.Ceiling(pageCount);

            bookPagine.CurrentPageIndex = currentPage;

            return bookPagine;
        }

        // GET: BookManagerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookManagerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookManagerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookManagerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookManagerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookManagerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookManagerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
