﻿using Microsoft.EntityFrameworkCore;
using SocialMediaApp.Core.RepositoriesContract;
using SocialMediaApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApp.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(ApplicationDbContext db)
        {
            _db = db;
            _dbSet = _db.Set<T>();
        }

        public async Task<T> CreateAsync(T model)
        {
            await _dbSet.AddAsync(model);
            return model;
        }

        public async Task<bool> DeleteAsync(T model)
        {
            _dbSet.Remove(model);
            return true;
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, string includeProperties = "",Expression<Func<T,T>>? orderBy = null, int pageIndex = 1, int pageSize = 10)
        {
            IQueryable<T> query = _dbSet;

            if (filter != null)
                query = query.Where(filter);

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }
            if (orderBy != null)
                query = query.OrderBy(orderBy);

            return await query.Skip(((pageIndex - 1) * pageSize)).Take(pageSize).ToListAsync();
        }

        public async Task<T> GetByAsync(Expression<Func<T, bool>>? filter = null, bool isTracked = true, string includeProperties = "")
        {
            IQueryable<T> query = _dbSet;
            if (!isTracked)
                query = query.AsNoTracking();
            if (filter != null)
                query = query.Where(filter);

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            return await query.FirstOrDefaultAsync(filter);
        }

        public async Task<T> UpdateAsync(T model)
        {
            _db.Entry(model).State = EntityState.Modified;
            return model;
        }
    
    }
}