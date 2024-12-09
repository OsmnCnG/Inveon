using Microsoft.AspNetCore.Mvc;

namespace InveonBootcamp_Part3.Services
{
    public class ServiceResult
    {
    
        public ProblemDetails? ProblemDetails { get; set; }
    
    }


    public class ServiceResult<T> : ServiceResult
    {

        public Task<T>? Data { get; set; }


    }
}
