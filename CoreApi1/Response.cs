namespace CoreApi1
{
    public class Response
    {
        public bool IsSuccess { get; set; } = false;
        public string Message { get; set; } = "";
        public object ? Data { get; set; }
    }
}
