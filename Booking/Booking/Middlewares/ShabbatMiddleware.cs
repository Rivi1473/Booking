namespace Booking.API.Middlewares
{
    public class ShabbatMiddleware
    {
        private readonly RequestDelegate _next;
        public ShabbatMiddleware(RequestDelegate next)
        {
            _next= next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            if(DateTime.Now.DayOfWeek == DayOfWeek.Saturday) 
            {
                await context.Response.WriteAsync(new HttpResponseMessage
                {
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Content = new StringContent("today is Shabbos we are closed", System.Text.Encoding.UTF8, "application/json")
                }.ToString());
            }
            else
            {
                await _next(context);
            }
        }
    }
}
