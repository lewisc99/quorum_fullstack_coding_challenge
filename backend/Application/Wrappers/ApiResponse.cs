namespace Domain.Api
{
    public class ApiResponse<T>
    {
        public List<T> Data { get; set; }
        public int TotalSize { get; set; }
        public string Message { get; set; }
        public bool Status { get; set; }
        public int TotalPages { get; set; }
        public string NextPageLink { get; set; }
        public string PreviousPageLink { get; set; }

        public ApiResponse() { }

        public static ApiResponse<T> CreateForList(List<T> data, int totalSize, int totalPages, string nextPageLink = null, string previousPageLink = null, string message = "Success", bool status = true)
        {
            return new ApiResponse<T>
            {
                Data = data,
                TotalSize = totalSize,
                TotalPages = totalPages,
                NextPageLink = nextPageLink,
                PreviousPageLink = previousPageLink,
                Message = message,
                Status = status
            };
        }

        public static ApiResponse<T> Error(string errorMessage)
        {
            return new ApiResponse<T>
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
