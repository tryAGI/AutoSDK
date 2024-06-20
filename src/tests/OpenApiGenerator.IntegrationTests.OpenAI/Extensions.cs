namespace OpenApiGenerator.IntegrationTests;

internal static class Extensions
{
    public static async Task<byte[]> DownloadAsBytesAsync(
        this Uri uri,
        CancellationToken cancellationToken = default)
    {
        using var client = new HttpClient();
        
        return await client.GetByteArrayAsync(uri, cancellationToken).ConfigureAwait(false);
    }
    
    public static string GetMimeType(
        string path)
    {
        // https://platform.openai.com/docs/guides/vision/what-type-of-files-can-i-upload
        return Path.GetExtension(path.ToUpperInvariant()) switch
        {
            ".JPG" => "image/jpeg",
            ".JPEG" => "image/jpeg",
            ".WEBP" => "image/webp",
            ".PNG" => "image/png",
            ".GIF" => "image/gif",
            _ => throw new NotSupportedException("Unsupported image format"),
        };
    }
    
    public static string ToBase64Url(
        this byte[] bytes,
        string mimeType)
    {
        return $"data:{mimeType};base64,{Convert.ToBase64String(bytes)}";
    }
    
    public static async Task<string> DownloadAsBase64UrlAsync(
        this Uri uri,
        string? mimeType = null,
        CancellationToken cancellationToken = default)
    {
        var bytes = await uri.DownloadAsBytesAsync(cancellationToken).ConfigureAwait(false);
        mimeType ??= GetMimeType(uri.ToString());
        
        return bytes.ToBase64Url(mimeType);
    }
}