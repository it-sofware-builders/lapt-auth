namespace lapt_auth.Auth;

public class Response
{
    public string? Status { get; set; }
    public string? Message { get; set; }

    // add data to the response
    public object? Data { get; set; }
}