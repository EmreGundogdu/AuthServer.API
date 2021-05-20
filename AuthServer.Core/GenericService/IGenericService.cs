﻿using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.GenericService
{
    public interface IGenericService<TEntity, TDto> where TEntity : class where TDto : class
    {
        Task<Response<TDto>> GetByIdAsync(int id);
        Task<Response<IEnumerable<TDto>>> GetAllAsync();
        Task<Response<TDto>> AddAsync(TDto entity);
        Task<Response<NoDataDto>> Remove(int id);
        Task<Response<NoDataDto>> Update(TDto entity,int id);
        Task<Response<IEnumerable<TDto>>> Where(Expression<Func<TEntity, bool>> predicate);
    }
}
