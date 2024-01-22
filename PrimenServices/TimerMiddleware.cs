

public class TimeMiddleware
{
    RequestDelegate next;
  

    public TimeMiddleware(RequestDelegate next, TimeService timeService)
    {
        this.next = next;
        
    }

    public async Task InvokeAsync(HttpContext context, TimeService timeService)
    {
        if(context.Request.Path == "/time")
        {
            context.Response.ContentType = "text/html;charset=utf-8";
            await context.Response.WriteAsync($"<h3>Текущее время: {timeService.Time}</h2>");
        }
        else
        {
            await next.Invoke(context);
        }
    }
}