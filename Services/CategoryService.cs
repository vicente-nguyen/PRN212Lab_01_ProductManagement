﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class CategoryService : ICatergoryService
    {
        private readonly CategoryRepository iCategoryRepository;
        public CategoryService()
        {
            iCategoryRepository = new CategoryRepository();
        }
        public List<Category> GetCategories()
        {
            return iCategoryRepository.GetCategories();
        }
    }
}
