using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    private static string GetDynamicMultipartHelperClassName(
        CSharpSettings settings)
    {
        var configuredClassName = settings.DynamicMultipartHelperClassName;
        if (string.IsNullOrWhiteSpace(configuredClassName))
        {
            configuredClassName = "DynamicMultipartContentBuilder";
        }

        return configuredClassName
            .ToPropertyName()
            .UseWordSeparator('.', '-', '_', '/');
    }

    public static string GenerateDynamicMultipartHelpers(
        CSharpSettings settings,
        string className,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var attachmentClassName = className + "Attachment";

        return $@"#nullable enable

namespace {settings.Namespace}
{{
    /// <summary>
    /// Represents a dynamically named multipart attachment part.
    /// </summary>
    public sealed class {attachmentClassName}
    {{
        internal {attachmentClassName}(
            string runId,
            string attachmentKey,
            string partName,
            global::System.Net.Http.HttpContent content,
            string? fileName,
            string? contentType)
        {{
            RunId = runId;
            AttachmentKey = attachmentKey;
            PartName = partName;
            Content = content;
            FileName = fileName;
            ContentType = contentType;
        }}

        /// <summary>
        /// Parent trace, run, or event identifier used to build the dynamic multipart name.
        /// </summary>
        public string RunId {{ get; }}

        /// <summary>
        /// Attachment key used to build the dynamic multipart name.
        /// </summary>
        public string AttachmentKey {{ get; }}

        /// <summary>
        /// Computed multipart part name.
        /// </summary>
        public string PartName {{ get; }}

        /// <summary>
        /// Optional file name sent with the multipart part.
        /// </summary>
        public string? FileName {{ get; }}

        /// <summary>
        /// Optional content type sent with the multipart part.
        /// </summary>
        public string? ContentType {{ get; }}

        /// <summary>
        /// Multipart HTTP content for this attachment.
        /// </summary>
        public global::System.Net.Http.HttpContent Content {{ get; }}
    }}

    /// <summary>
    /// Builds multipart/form-data content with part names computed from run ids and attachment keys.
    /// </summary>
    public sealed class {className} : global::System.IDisposable
    {{
        private readonly global::System.Collections.Generic.List<{attachmentClassName}> _attachments =
            new global::System.Collections.Generic.List<{attachmentClassName}>();
        private bool _built;
        private bool _contentOwnershipTransferred;
        private bool _disposed;

        /// <summary>
        /// Attachments that will be added to the generated multipart content.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<{attachmentClassName}> Attachments => _attachments;

        /// <summary>
        /// Adds an attachment from bytes.
        /// </summary>
        public {className} AddBytes(
            string runId,
            string attachmentKey,
            byte[] bytes,
            string? fileName = null,
            string? contentType = null)
        {{
            if (bytes is null)
            {{
                throw new global::System.ArgumentNullException(nameof(bytes));
            }}

            var copy = new byte[bytes.Length];
            global::System.Buffer.BlockCopy(bytes, 0, copy, 0, bytes.Length);

            return AddContent(
                runId,
                attachmentKey,
                new global::System.Net.Http.ByteArrayContent(copy),
                fileName,
                contentType);
        }}

        /// <summary>
        /// Adds an attachment from a stream.
        /// </summary>
        public {className} AddStream(
            string runId,
            string attachmentKey,
            global::System.IO.Stream stream,
            string? fileName = null,
            string? contentType = null)
        {{
            if (stream is null)
            {{
                throw new global::System.ArgumentNullException(nameof(stream));
            }}

            return AddContent(
                runId,
                attachmentKey,
                new global::System.Net.Http.StreamContent(stream),
                fileName,
                contentType);
        }}

        /// <summary>
        /// Adds a text attachment.
        /// </summary>
        public {className} AddString(
            string runId,
            string attachmentKey,
            string value,
            string? contentType = ""text/plain"",
            global::System.Text.Encoding? encoding = null)
        {{
            if (value is null)
            {{
                throw new global::System.ArgumentNullException(nameof(value));
            }}

            var effectiveContentType = string.IsNullOrWhiteSpace(contentType)
                ? ""text/plain""
                : contentType!;

            return AddContent(
                runId,
                attachmentKey,
                new global::System.Net.Http.StringContent(
                    value,
                    encoding ?? global::System.Text.Encoding.UTF8,
                    effectiveContentType),
                fileName: null,
                contentType: effectiveContentType);
        }}

        /// <summary>
        /// Adds an external attachment URL as a text/uri-list part.
        /// </summary>
        public {className} AddExternalUrl(
            string runId,
            string attachmentKey,
            global::System.Uri url,
            string? contentType = ""text/uri-list"")
        {{
            if (url is null)
            {{
                throw new global::System.ArgumentNullException(nameof(url));
            }}

            return AddString(
                runId,
                attachmentKey,
                url.ToString(),
                string.IsNullOrWhiteSpace(contentType) ? ""text/uri-list"" : contentType!);
        }}

        /// <summary>
        /// Builds multipart/form-data content. The returned content owns the attachment content objects.
        /// </summary>
        public global::System.Net.Http.MultipartFormDataContent Build()
        {{
            ThrowIfDisposed();
            if (_built)
            {{
                throw new global::System.InvalidOperationException(""Multipart content can only be built once."");
            }}

            _built = true;
            _contentOwnershipTransferred = true;

            var multipart = new global::System.Net.Http.MultipartFormDataContent();
            foreach (var attachment in _attachments)
            {{
                if (string.IsNullOrEmpty(attachment.FileName))
                {{
                    multipart.Add(attachment.Content, attachment.PartName);
                }}
                else
                {{
                    multipart.Add(attachment.Content, attachment.PartName, attachment.FileName);
                }}
            }}

            return multipart;
        }}

        /// <summary>
        /// Creates the default attachment part name from a parent run id and attachment key.
        /// </summary>
        public static string CreateAttachmentPartName(
            string runId,
            string attachmentKey)
        {{
            return CreatePartName(runId, attachmentKey);
        }}

        /// <summary>
        /// Creates a dynamic multipart part name by joining validated segments with dots.
        /// </summary>
        public static string CreatePartName(
            params string[] segments)
        {{
            if (segments is null)
            {{
                throw new global::System.ArgumentNullException(nameof(segments));
            }}
            if (segments.Length == 0)
            {{
                throw new global::System.ArgumentException(""At least one multipart part name segment is required."", nameof(segments));
            }}

            var builder = new global::System.Text.StringBuilder();
            for (var i = 0; i < segments.Length; i++)
            {{
                var segment = ValidatePartNameSegment(segments[i], nameof(segments));
                if (builder.Length > 0)
                {{
                    builder.Append('.');
                }}

                builder.Append(segment);
            }}

            return builder.ToString();
        }}

        private {className} AddContent(
            string runId,
            string attachmentKey,
            global::System.Net.Http.HttpContent content,
            string? fileName,
            string? contentType)
        {{
            ThrowIfDisposed();
            if (_built)
            {{
                throw new global::System.InvalidOperationException(""Attachments cannot be added after multipart content is built."");
            }}

            var partName = CreateAttachmentPartName(runId, attachmentKey);
            if (!string.IsNullOrWhiteSpace(contentType))
            {{
                content.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(contentType!);
            }}

            _attachments.Add(new {attachmentClassName}(
                runId,
                attachmentKey,
                partName,
                content,
                fileName,
                GetContentType(content, contentType)));

            return this;
        }}

        private static string ValidatePartNameSegment(
            string? value,
            string parameterName)
        {{
            if (string.IsNullOrWhiteSpace(value))
            {{
                throw new global::System.ArgumentException(""Multipart part name segments must be non-empty."", parameterName);
            }}
            if (value.IndexOf('\r') >= 0 ||
                value.IndexOf('\n') >= 0 ||
                value.IndexOf('""') >= 0)
            {{
                throw new global::System.ArgumentException(""Multipart part name segments must not contain quotes or line breaks."", parameterName);
            }}

            return value;
        }}

        private static string? GetContentType(
            global::System.Net.Http.HttpContent content,
            string? configuredContentType)
        {{
            if (!string.IsNullOrWhiteSpace(configuredContentType))
            {{
                return configuredContentType;
            }}

            return content.Headers.ContentType?.MediaType;
        }}

        private void ThrowIfDisposed()
        {{
            if (_disposed)
            {{
                throw new global::System.ObjectDisposedException(nameof({className}));
            }}
        }}

        public void Dispose()
        {{
            if (_disposed)
            {{
                return;
            }}

            if (!_contentOwnershipTransferred)
            {{
                foreach (var attachment in _attachments)
                {{
                    attachment.Content.Dispose();
                }}
            }}

            _disposed = true;
        }}
    }}
}}
";
    }
}
