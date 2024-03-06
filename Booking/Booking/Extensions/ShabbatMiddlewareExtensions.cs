using Booking.API.Middlewares;

namespace Booking.API.Extensions
{
    public static class ShabbatMiddlewareExtensions
    {
        public static IApplicationBuilder UseShabbat(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ShabbatMiddleware>();
        }
    }
}
