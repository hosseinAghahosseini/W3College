using Microsoft.EntityFrameworkCore;
using RealProject.Entities;

namespace RealProject.Services
{
    public enum ResposneCode
    {
        Success = 0,
        DatabaseError = -2,
        InputError = -1
    }

    public abstract class BaseService<T> where T : Base
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;
        public BaseService(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public int Create(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                return _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return (int)ResposneCode.DatabaseError;
            }
        }

        public int Update(T entity)
        {
            try
            {
                _dbSet.Update(entity);
                return _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return (int)ResposneCode.DatabaseError;
            }

        }

        public int Delete(T entity)
        {
            try
            {
                _dbSet.Remove(entity);
                return _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return (int)ResposneCode.DatabaseError;
            }

        }

        public int DeleteById(int Id)
        {
            try
            {
                var entity = _dbSet.First(c => c.Id == Id);
                _dbSet.Remove(entity);
                return _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return (int)ResposneCode.DatabaseError;
            }
        }

        public List<T> ReadAll()
        {
            try
            {
                return _dbSet.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public T ReadSingle(int Id)
        {
            try
            {
                var entity = _dbSet.First(c => c.Id == Id);
                return entity;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int GetCount()
        {
            try
            {
                var entity = _dbSet.Count();
                return entity;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
