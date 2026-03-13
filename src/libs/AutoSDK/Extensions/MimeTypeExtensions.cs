namespace AutoSDK.Extensions;

public static class MimeTypeExtensions
{
    public static bool IsBinaryResponseMimeType(this string? mimeType)
    {
        if (string.IsNullOrWhiteSpace(mimeType))
        {
            return false;
        }

        var normalizedMimeType = mimeType!.Split(';')[0].Trim();

        return normalizedMimeType.Equals("application/octet-stream", StringComparison.OrdinalIgnoreCase) ||
               normalizedMimeType.Equals("application/zip", StringComparison.OrdinalIgnoreCase) ||
               normalizedMimeType.StartsWith("audio/", StringComparison.OrdinalIgnoreCase);
    }
}
