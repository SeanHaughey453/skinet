using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria{get;}
        
        List<Expression<Func<T, object>>> Includes {get;}

        Expression<Func<T, object>>OrderBy{get;}

        Expression<Func<T, object>>OrderByDescending{get;}

        int Take {get;} //this is for pagination ie if i wanted to take 5 products and display them on the page

        int Skip {get;}//again for pagination ie if i take 5 page and choose to skip 0 it will take the first 5 products or if i choose to take 5 and skip 5 it will skip the first 5 products and display the next 5 etc

        bool IsPagingEnabled {get;}
        
    }
}