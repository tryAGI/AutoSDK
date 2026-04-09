namespace AutoSDK.Extensions;

public static class MimeTypeExtensions
{
    public static string NormalizeMimeType(this string? mimeType)
    {
        return string.IsNullOrWhiteSpace(mimeType)
            ? string.Empty
            : mimeType!.Split(';')[0].Trim();
    }

    public static bool IsMimeType(this string? mimeType, string expectedMimeType)
    {
        return mimeType.NormalizeMimeType().Equals(expectedMimeType, StringComparison.OrdinalIgnoreCase);
    }

    public static bool IsJsonMimeType(this string? mimeType)
    {
        var normalizedMimeType = mimeType.NormalizeMimeType();
        return normalizedMimeType.Equals("application/json", StringComparison.OrdinalIgnoreCase) ||
               normalizedMimeType.EndsWith("+json", StringComparison.OrdinalIgnoreCase);
    }

    public static bool IsSequentialJsonMimeType(this string? mimeType)
    {
        var normalizedMimeType = mimeType.NormalizeMimeType();
        return normalizedMimeType.Equals("application/x-ndjson", StringComparison.OrdinalIgnoreCase) ||
               normalizedMimeType.Equals("application/jsonl", StringComparison.OrdinalIgnoreCase) ||
               normalizedMimeType.Equals("application/json-seq", StringComparison.OrdinalIgnoreCase);
    }

    public static bool IsServerSentEventsMimeType(this string? mimeType)
    {
        return mimeType.IsMimeType("text/event-stream");
    }

    public static bool IsBinaryResponseMimeType(this string? mimeType)
    {
        var normalizedMimeType = mimeType.NormalizeMimeType();
        if (string.IsNullOrWhiteSpace(normalizedMimeType))
        {
            return false;
        }

        return normalizedMimeType.Equals("application/octet-stream", StringComparison.OrdinalIgnoreCase) ||
               normalizedMimeType.Equals("application/zip", StringComparison.OrdinalIgnoreCase) ||
               normalizedMimeType.StartsWith("audio/", StringComparison.OrdinalIgnoreCase);
    }
}
