using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    private static string GetMultipartUploadHelperClassName(
        CSharpSettings settings)
    {
        var configuredClassName = settings.MultipartUploadHelperClassName;
        if (string.IsNullOrWhiteSpace(configuredClassName))
        {
            configuredClassName = "AutoSDKUploadFile";
        }

        return configuredClassName
            .ToPropertyName()
            .UseWordSeparator('.', '-', '_', '/');
    }

    public static FileWithName MultipartUploadHelpers(
        CSharpSettings settings,
        CancellationToken cancellationToken = default)
    {
        if (!settings.GenerateMultipartUploadHelpers)
        {
            return FileWithName.Empty;
        }

        var className = GetMultipartUploadHelperClassName(settings);

        return new FileWithName(
            Name: $"{settings.Namespace}.{className}.g.cs",
            Text: GenerateMultipartUploadHelpers(settings, className, cancellationToken));
    }

    public static string GenerateMultipartUploadHelpers(
        CSharpSettings settings,
        string className,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return $@"#pragma warning disable CS1591
#nullable enable

namespace {settings.Namespace}
{{
    /// <summary>
    /// Typed wrapper for a multipart/form-data file upload. Bundles filename, content,
    /// and Content-Type so consumer code doesn't have to hand-roll
    /// <see cref=""global::System.Net.Http.MultipartFormDataContent""/> assemblies or
    /// repeated MIME-type guessing tables. The content is exposed as either a
    /// <see cref=""global::System.IO.Stream""/> (preferred for large files) or a
    /// <see cref=""global::System.ReadOnlyMemory{{byte}}""/> (preferred for in-memory uploads).
    ///
    /// Construct via the static factory methods <see cref=""FromBytes""/>,
    /// <see cref=""FromStream""/>, or <see cref=""FromPath""/>.
    /// </summary>
    public sealed class {className} : global::System.IDisposable
    {{
        private readonly global::System.IO.Stream? _stream;
        private readonly global::System.ReadOnlyMemory<byte> _bytes;
        private readonly bool _ownsStream;
        private readonly bool _hasStream;

        private {className}(
            string filename,
            string contentType,
            global::System.IO.Stream? stream,
            global::System.ReadOnlyMemory<byte> bytes,
            bool ownsStream,
            bool hasStream)
        {{
            Filename = filename ?? string.Empty;
            ContentType = string.IsNullOrWhiteSpace(contentType) ? ""application/octet-stream"" : contentType;
            _stream = stream;
            _bytes = bytes;
            _ownsStream = ownsStream;
            _hasStream = hasStream;
        }}

        /// <summary>The filename written into the multipart <c>Content-Disposition</c> header.</summary>
        public string Filename {{ get; }}

        /// <summary>The resolved MIME type written into <c>Content-Type</c>.</summary>
        public string ContentType {{ get; }}

        /// <summary>True when the file was constructed around a <see cref=""global::System.IO.Stream""/> (large/streaming upload path).</summary>
        public bool HasStream => _hasStream;

        /// <summary>True when the file was constructed around an in-memory byte payload.</summary>
        public bool HasBytes => !_hasStream;

        /// <summary>
        /// Returns the bytes payload. Throws when the file was constructed with a stream.
        /// </summary>
        public global::System.ReadOnlyMemory<byte> Bytes
        {{
            get
            {{
                if (_hasStream)
                {{
                    throw new global::System.InvalidOperationException(
                        $""{{nameof({className})}} was constructed with a stream; access the stream via {{nameof(OpenReadStream)}}() instead."");
                }}

                return _bytes;
            }}
        }}

        /// <summary>
        /// Returns the underlying stream for the file. Throws when the file was constructed with bytes.
        /// Callers should not dispose the stream — it is owned by the <see cref=""{className}""/> instance.
        /// </summary>
        public global::System.IO.Stream OpenReadStream()
        {{
            if (!_hasStream || _stream is null)
            {{
                throw new global::System.InvalidOperationException(
                    $""{{nameof({className})}} was constructed with bytes; access the bytes via {{nameof(Bytes)}} instead."");
            }}

            return _stream;
        }}

        /// <summary>
        /// Builds an <see cref=""global::System.Net.Http.HttpContent""/> with <c>Content-Disposition</c> and
        /// <c>Content-Type</c> headers already populated. Suitable for adding directly to a
        /// <see cref=""global::System.Net.Http.MultipartFormDataContent""/>.
        /// </summary>
        /// <param name=""formFieldName"">The multipart form-field name (e.g. <c>""file""</c>).</param>
        public global::System.Net.Http.HttpContent ToHttpContent(string formFieldName)
        {{
            if (string.IsNullOrWhiteSpace(formFieldName))
            {{
                throw new global::System.ArgumentException(""Form field name must be non-empty."", nameof(formFieldName));
            }}

            global::System.Net.Http.HttpContent content;
            if (_hasStream && _stream is not null)
            {{
                content = new global::System.Net.Http.StreamContent(_stream);
            }}
            else
            {{
                content = new global::System.Net.Http.ByteArrayContent(_bytes.ToArray());
            }}

            content.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(ContentType);
            content.Headers.ContentDisposition = new global::System.Net.Http.Headers.ContentDispositionHeaderValue(""form-data"")
            {{
                Name = ""\"""" + formFieldName + ""\"""",
                FileName = ""\"""" + Filename + ""\"""",
                FileNameStar = null,
            }};
            return content;
        }}

        /// <summary>
        /// Constructs an upload from an in-memory byte array. <paramref name=""contentType""/> is auto-detected
        /// from <paramref name=""filename""/> when null.
        /// </summary>
        public static {className} FromBytes(
            string filename,
            byte[] bytes,
            string? contentType = null)
        {{
            bytes = bytes ?? throw new global::System.ArgumentNullException(nameof(bytes));
            return FromBytes(filename, new global::System.ReadOnlyMemory<byte>(bytes), contentType);
        }}

        /// <summary>
        /// Constructs an upload from a <see cref=""global::System.ReadOnlyMemory{{byte}}""/> payload. Useful when
        /// the caller already has a slice of a larger buffer.
        /// </summary>
        public static {className} FromBytes(
            string filename,
            global::System.ReadOnlyMemory<byte> bytes,
            string? contentType = null)
        {{
            if (string.IsNullOrWhiteSpace(filename))
            {{
                throw new global::System.ArgumentException(""Filename must be non-empty."", nameof(filename));
            }}

            return new {className}(
                filename: filename,
                contentType: string.IsNullOrWhiteSpace(contentType)
                    ? AutoSDKMimeTypeGuesser.Guess(filename)
                    : contentType!,
                stream: null,
                bytes: bytes,
                ownsStream: false,
                hasStream: false);
        }}

        /// <summary>
        /// Constructs an upload from an open <see cref=""global::System.IO.Stream""/>. The stream is read on
        /// demand when the request is sent so very large files are not buffered into memory.
        /// </summary>
        /// <param name=""filename""></param>
        /// <param name=""stream""></param>
        /// <param name=""contentType""></param>
        /// <param name=""leaveOpen"">When false (default), the stream is disposed with this instance.</param>
        public static {className} FromStream(
            string filename,
            global::System.IO.Stream stream,
            string? contentType = null,
            bool leaveOpen = false)
        {{
            stream = stream ?? throw new global::System.ArgumentNullException(nameof(stream));
            if (string.IsNullOrWhiteSpace(filename))
            {{
                throw new global::System.ArgumentException(""Filename must be non-empty."", nameof(filename));
            }}

            return new {className}(
                filename: filename,
                contentType: string.IsNullOrWhiteSpace(contentType)
                    ? AutoSDKMimeTypeGuesser.Guess(filename)
                    : contentType!,
                stream: stream,
                bytes: default,
                ownsStream: !leaveOpen,
                hasStream: true);
        }}

        /// <summary>
        /// Opens <paramref name=""path""/> from disk and constructs a streaming upload around it. The file is
        /// not loaded into memory; the stream is closed when this instance is disposed.
        /// </summary>
        public static {className} FromPath(
            string path,
            string? filename = null,
            string? contentType = null)
        {{
            if (string.IsNullOrWhiteSpace(path))
            {{
                throw new global::System.ArgumentException(""Path must be non-empty."", nameof(path));
            }}

            var stream = new global::System.IO.FileStream(
                path,
                global::System.IO.FileMode.Open,
                global::System.IO.FileAccess.Read,
                global::System.IO.FileShare.Read);

            var resolvedFilename = string.IsNullOrWhiteSpace(filename)
                ? global::System.IO.Path.GetFileName(path)
                : filename!;

            return FromStream(
                filename: resolvedFilename,
                stream: stream,
                contentType: contentType,
                leaveOpen: false);
        }}

        /// <inheritdoc />
        public void Dispose()
        {{
            if (_ownsStream)
            {{
                _stream?.Dispose();
            }}
        }}
    }}

    /// <summary>
    /// Lightweight MIME-type guesser used by <see cref=""{className}""/>. Covers the file types most commonly
    /// uploaded against AI/ML APIs (audio, video, images, PDFs, text). Unknown extensions fall back to
    /// <c>application/octet-stream</c>.
    /// </summary>
    public static class AutoSDKMimeTypeGuesser
    {{
        /// <summary>Returns a best-effort MIME type for <paramref name=""filename""/>. Never returns null.</summary>
        public static string Guess(string? filename)
        {{
            if (string.IsNullOrWhiteSpace(filename))
            {{
                return ""application/octet-stream"";
            }}

            var extension = global::System.IO.Path.GetExtension(filename);
            if (string.IsNullOrEmpty(extension))
            {{
                return ""application/octet-stream"";
            }}

            return extension.ToLowerInvariant() switch
            {{
                // Documents
                "".pdf"" => ""application/pdf"",
                "".doc"" => ""application/msword"",
                "".docx"" => ""application/vnd.openxmlformats-officedocument.wordprocessingml.document"",
                "".xls"" => ""application/vnd.ms-excel"",
                "".xlsx"" => ""application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"",
                "".ppt"" => ""application/vnd.ms-powerpoint"",
                "".pptx"" => ""application/vnd.openxmlformats-officedocument.presentationml.presentation"",
                "".csv"" => ""text/csv"",
                "".tsv"" => ""text/tab-separated-values"",
                "".rtf"" => ""application/rtf"",
                // Text/markup
                "".txt"" => ""text/plain"",
                "".md"" => ""text/markdown"",
                "".html"" or "".htm"" => ""text/html"",
                "".xml"" => ""application/xml"",
                "".json"" => ""application/json"",
                "".jsonl"" or "".ndjson"" => ""application/x-ndjson"",
                "".yaml"" or "".yml"" => ""application/x-yaml"",
                // Images
                "".png"" => ""image/png"",
                "".jpg"" or "".jpeg"" => ""image/jpeg"",
                "".gif"" => ""image/gif"",
                "".webp"" => ""image/webp"",
                "".bmp"" => ""image/bmp"",
                "".svg"" => ""image/svg+xml"",
                "".tiff"" or "".tif"" => ""image/tiff"",
                "".heic"" => ""image/heic"",
                "".heif"" => ""image/heif"",
                // Audio
                "".mp3"" => ""audio/mpeg"",
                "".wav"" => ""audio/wav"",
                "".m4a"" => ""audio/mp4"",
                "".aac"" => ""audio/aac"",
                "".ogg"" or "".oga"" => ""audio/ogg"",
                "".opus"" => ""audio/opus"",
                "".flac"" => ""audio/flac"",
                "".webm"" => ""video/webm"",
                // Video
                "".mp4"" => ""video/mp4"",
                "".mov"" => ""video/quicktime"",
                "".avi"" => ""video/x-msvideo"",
                "".mkv"" => ""video/x-matroska"",
                // Archives
                "".zip"" => ""application/zip"",
                "".tar"" => ""application/x-tar"",
                "".gz"" => ""application/gzip"",
                _ => ""application/octet-stream"",
            }};
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
