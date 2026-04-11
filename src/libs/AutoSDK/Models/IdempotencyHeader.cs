namespace AutoSDK.Models;

public sealed class IdempotencyHeader
{
    public IdempotencyHeader(
        string headerName,
        string parameterName)
    {
        HeaderName = headerName;
        ParameterName = parameterName;
    }

    public string HeaderName { get; set; }
    public string ParameterName { get; set; }
}
