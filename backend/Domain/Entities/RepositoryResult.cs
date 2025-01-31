namespace Domain.Entities
{
    public class RepositoryResult<T>
    {
        public List<T> Data { get; set; }
        public int TotalSize { get; set; }
        public string Message { get; set; }
        public bool Status { get; set; }
        public int TotalPages { get; set; }
        public string NextPageLink { get; set; }
        public string PreviousPageLink { get; set; }

        public RepositoryResult() { }

        public static RepositoryResult<T> Success(List<T> data) =>
            new RepositoryResult<T> { Status = true, Data = data };

        public static RepositoryResult<T> Error(string errorMessage)
        {
            return new RepositoryResult<T>
            {
                Data = new List<T>(),
                TotalSize = 0,
                TotalPages = 0,
                Message = errorMessage,
                Status = false
            };
        }
    }
}
