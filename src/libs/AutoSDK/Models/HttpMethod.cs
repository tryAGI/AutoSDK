namespace AutoSDK.Models;

/// <summary>
/// OpenAPI currently supports a subset of the HTTP protocol.
/// The following enum contains the list of supported HTTP methods.
/// </summary>
public enum HttpMethod
{
    Get,
    Post,
    Put,
    Head,
    Delete,
    Patch,
    Options,
    Trace,
}