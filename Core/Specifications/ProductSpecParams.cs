namespace Core.Specifications
{
    public class ProductSpecParams
    {
        private const int MaxPageSize = 50;

        public int PageIndex {get; set;} = 1;

        private int _pageSize = 6;

        public int PageSize
        {
            get => _pageSize;

            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value; // if the value being passed in is greater than the max page size then we will return the max page size if not then we will return the value
        
        }

        public int? BrandId {get; set;}

        public int? TypeId {get; set;}

        public string? Sort {get; set;}

        private string? _search;

        public string? Search
        { 
            get => _search;
            set => _search = value.ToLower();
         }
    }
}