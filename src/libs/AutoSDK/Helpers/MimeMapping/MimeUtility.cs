// MIT: https://github.com/zone117x/MimeMapping

using System.Collections.ObjectModel;

#pragma warning disable CA1308 // Normalize strings to uppercase

// ReSharper disable once CheckNamespace
namespace MimeMapping;

/// <summary>
/// MIME type utility to lookup by file extension
/// </summary>
public static class MimeUtility
{
    /// <summary>
    /// The "octet-stream" subtype is used to indicate that a body contains arbitrary binary data.
    /// See <a href="https://www.iana.org/assignments/media-types/application/octet-stream">application/octet-stream</a>
    /// </summary>
    public const string UnknownMimeType = "application/octet-stream";

    private static readonly Lazy<ReadOnlyDictionary<string, string?>> LazyDictExtensions = new(
        () => new ReadOnlyDictionary<string, string?>(KnownMimeTypes.ALL_EXTS.Value.ToDictionary(e => e, e => KnownMimeTypes.LookupType(e)))
    );

    private static readonly Lazy<ReadOnlyDictionary<string, string[]?>> LazyDictMimeTypes = new(
        () => new ReadOnlyDictionary<string, string[]?>(KnownMimeTypes.ALL_MIMETYPES.Value.Distinct().ToDictionary(e => e, e => KnownMimeTypes.LookupMimeType(e)))
    );

    /// <summary>
    /// Dictionary of all available types by extension (lazy loaded on first call)
    /// </summary>
    public static ReadOnlyDictionary<string, string?> TypeMap => LazyDictExtensions.Value;
        
    /// <summary>
    /// Dictionary of all available types by mimetype (lazy loaded on first call)
    /// </summary>
    public static ReadOnlyDictionary<string, string[]?> TypeToExtensionsMap => LazyDictMimeTypes.Value;

    /// <param name="file">The file extensions (ex: "zip"), the file name, or file path</param>
    /// <returns>The mime type string, returns "application/octet-stream" if no known type was found</returns>
    public static string GetMimeMapping(string file)
    {
        file = file ?? throw new ArgumentNullException(nameof(file));

        if (string.IsNullOrEmpty(file))
            return UnknownMimeType;

        var fileExtension = file.Contains(".") 
            ? GetExtension(file)
            : file;

        return KnownMimeTypes.LookupType(fileExtension.ToLowerInvariant()) ?? UnknownMimeType;
    }

    /// <param name="mimeType">The mime type string, e.g. "application/json"</param>
    /// <returns>One or more extensions matching the mime type or null if no match</returns>
    public static string[]? GetExtensions(string mimeType)
    {
        if (string.IsNullOrEmpty(mimeType)) throw new ArgumentNullException(mimeType);

        return KnownMimeTypes.LookupMimeType(mimeType);
    }

    private static string GetExtension(string path)
    {
        var extension = Path.GetExtension(path);
        if (string.IsNullOrEmpty(extension))
            return string.Empty; 

        return extension.Substring(1);
    }
}