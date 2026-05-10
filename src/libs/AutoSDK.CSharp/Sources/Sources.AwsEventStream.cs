using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateAwsEventStreamSupport(
        CSharpSettings settings,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return $@"#pragma warning disable CS1591
#nullable enable

namespace {settings.Namespace}
{{
    /// <summary>
    /// A single AWS EventStream frame decoded from <c>application/vnd.amazon.eventstream</c>
    /// responses. Carries the message and event type headers separately from the raw payload
    /// so consumers can dispatch on event identity without re-parsing the headers.
    /// </summary>
    public sealed class AutoSDKAwsEventStreamFrame
    {{
        internal AutoSDKAwsEventStreamFrame(
            string? messageType,
            string? eventType,
            string? contentType,
            string? exceptionType,
            string? errorCode,
            string? errorMessage,
            byte[] payload)
        {{
            MessageType = messageType;
            EventType = eventType;
            ContentType = contentType;
            ExceptionType = exceptionType;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            Payload = payload ?? global::System.Array.Empty<byte>();
        }}

        /// <summary>The value of the <c>:message-type</c> header, when present.</summary>
        public string? MessageType {{ get; }}

        /// <summary>The value of the <c>:event-type</c> header, when present.</summary>
        public string? EventType {{ get; }}

        /// <summary>The value of the <c>:content-type</c> header, when present.</summary>
        public string? ContentType {{ get; }}

        /// <summary>The value of the <c>:exception-type</c> header, when the frame is an exception.</summary>
        public string? ExceptionType {{ get; }}

        /// <summary>The value of the <c>:error-code</c> header, when the frame is an error.</summary>
        public string? ErrorCode {{ get; }}

        /// <summary>The value of the <c>:error-message</c> header, when the frame is an error.</summary>
        public string? ErrorMessage {{ get; }}

        /// <summary>The raw payload bytes (without prelude or trailing CRC).</summary>
        public byte[] Payload {{ get; }}

        /// <summary>Decodes the payload as UTF-8 text — convenient for JSON-shaped payloads.</summary>
        public string PayloadAsString => global::System.Text.Encoding.UTF8.GetString(Payload);

        /// <summary>True when <see cref=""MessageType""/> indicates an exception frame.</summary>
        public bool IsException =>
            string.Equals(MessageType, ""exception"", global::System.StringComparison.OrdinalIgnoreCase) ||
            !string.IsNullOrEmpty(ExceptionType);

        /// <summary>True when <see cref=""MessageType""/> indicates an error frame.</summary>
        public bool IsError =>
            string.Equals(MessageType, ""error"", global::System.StringComparison.OrdinalIgnoreCase) ||
            !string.IsNullOrEmpty(ErrorCode);
    }}

    /// <summary>
    /// Thrown when an <c>application/vnd.amazon.eventstream</c> frame fails CRC validation,
    /// reports an exception/error payload, or contains a malformed prelude/header section.
    /// </summary>
    public sealed class AutoSDKAwsEventStreamException : global::System.Exception
    {{
        public AutoSDKAwsEventStreamException(string message)
            : base(message)
        {{
        }}

        public AutoSDKAwsEventStreamException(
            string message,
            global::{settings.Namespace}.AutoSDKAwsEventStreamFrame frame)
            : base(message)
        {{
            Frame = frame;
        }}

        /// <summary>The decoded frame that triggered the failure, when one is available.</summary>
        public global::{settings.Namespace}.AutoSDKAwsEventStreamFrame? Frame {{ get; }}
    }}

    /// <summary>
    /// A trim/AOT-friendly reader for the AWS EventStream binary frame protocol. Yields one
    /// <see cref=""AutoSDKAwsEventStreamFrame""/> per frame until the stream ends. Skips CRC
    /// validation — the AWS spec embeds two CRC32 values per frame, but the framing itself is
    /// length-prefixed so missing/invalid CRCs do not prevent decoding the payload. Consumers
    /// who require CRC validation should layer it via the official AWS SDK package.
    /// </summary>
    public static class AutoSDKAwsEventStreamReader
    {{
        // Header value type identifiers from the AWS EventStream spec.
        private const byte TypeBoolTrue = 0;
        private const byte TypeBoolFalse = 1;
        private const byte TypeByte = 2;
        private const byte TypeShort = 3;
        private const byte TypeInteger = 4;
        private const byte TypeLong = 5;
        private const byte TypeByteArray = 6;
        private const byte TypeString = 7;
        private const byte TypeTimestamp = 8;
        private const byte TypeUuid = 9;

        /// <summary>
        /// Reads <c>application/vnd.amazon.eventstream</c> frames from <paramref name=""stream""/>
        /// and yields each as an <see cref=""AutoSDKAwsEventStreamFrame""/>. Stops when the stream
        /// ends or <paramref name=""cancellationToken""/> is signaled.
        /// </summary>
        public static async global::System.Collections.Generic.IAsyncEnumerable<global::{settings.Namespace}.AutoSDKAwsEventStreamFrame> ReadAsync(
            global::System.IO.Stream stream,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation]
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            stream = stream ?? throw new global::System.ArgumentNullException(nameof(stream));

            var prelude = new byte[12];
            while (true)
            {{
                cancellationToken.ThrowIfCancellationRequested();

                var read = await ReadExactAsync(stream, prelude, 0, prelude.Length, cancellationToken).ConfigureAwait(false);
                if (read == 0)
                {{
                    yield break;
                }}
                if (read < prelude.Length)
                {{
                    throw new global::{settings.Namespace}.AutoSDKAwsEventStreamException(
                        ""AWS EventStream prelude truncated before completion."");
                }}

                var totalLength = ReadBigEndianInt32(prelude, 0);
                var headersLength = ReadBigEndianInt32(prelude, 4);
                if (totalLength < 16 || headersLength < 0 || headersLength > totalLength - 16)
                {{
                    throw new global::{settings.Namespace}.AutoSDKAwsEventStreamException(
                        $""AWS EventStream frame has invalid lengths: total={{totalLength}}, headers={{headersLength}}."");
                }}

                var remaining = totalLength - prelude.Length;
                var body = new byte[remaining];
                var bodyRead = await ReadExactAsync(stream, body, 0, body.Length, cancellationToken).ConfigureAwait(false);
                if (bodyRead < body.Length)
                {{
                    throw new global::{settings.Namespace}.AutoSDKAwsEventStreamException(
                        ""AWS EventStream frame body truncated before completion."");
                }}

                var payloadLength = body.Length - headersLength - 4;
                if (payloadLength < 0)
                {{
                    throw new global::{settings.Namespace}.AutoSDKAwsEventStreamException(
                        ""AWS EventStream frame payload length is negative; headers exceed body."");
                }}

                var headers = ParseHeaders(body, 0, headersLength);
                var payload = new byte[payloadLength];
                if (payloadLength > 0)
                {{
                    global::System.Buffer.BlockCopy(body, headersLength, payload, 0, payloadLength);
                }}

                yield return new global::{settings.Namespace}.AutoSDKAwsEventStreamFrame(
                    messageType: TryGetHeader(headers, "":message-type""),
                    eventType: TryGetHeader(headers, "":event-type""),
                    contentType: TryGetHeader(headers, "":content-type""),
                    exceptionType: TryGetHeader(headers, "":exception-type""),
                    errorCode: TryGetHeader(headers, "":error-code""),
                    errorMessage: TryGetHeader(headers, "":error-message""),
                    payload: payload);
            }}
        }}

        private static async global::System.Threading.Tasks.Task<int> ReadExactAsync(
            global::System.IO.Stream stream,
            byte[] buffer,
            int offset,
            int count,
            global::System.Threading.CancellationToken cancellationToken)
        {{
            var read = 0;
            while (read < count)
            {{
                cancellationToken.ThrowIfCancellationRequested();
                var bytes = await stream.ReadAsync(buffer, offset + read, count - read, cancellationToken)
                    .ConfigureAwait(false);
                if (bytes == 0)
                {{
                    return read;
                }}

                read += bytes;
            }}

            return read;
        }}

        private static int ReadBigEndianInt32(byte[] buffer, int offset)
        {{
            return (buffer[offset] << 24) |
                   (buffer[offset + 1] << 16) |
                   (buffer[offset + 2] << 8) |
                   buffer[offset + 3];
        }}

        private static int ReadBigEndianInt16(byte[] buffer, int offset)
        {{
            return (buffer[offset] << 8) | buffer[offset + 1];
        }}

        private static global::System.Collections.Generic.Dictionary<string, string> ParseHeaders(
            byte[] body,
            int offset,
            int length)
        {{
            var headers = new global::System.Collections.Generic.Dictionary<string, string>(
                global::System.StringComparer.Ordinal);
            var end = offset + length;
            var index = offset;
            while (index < end)
            {{
                var nameLength = body[index];
                index += 1;
                if (nameLength == 0 || index + nameLength > end)
                {{
                    throw new global::{settings.Namespace}.AutoSDKAwsEventStreamException(
                        ""AWS EventStream header name length is invalid."");
                }}

                var name = global::System.Text.Encoding.UTF8.GetString(body, index, nameLength);
                index += nameLength;

                if (index >= end)
                {{
                    throw new global::{settings.Namespace}.AutoSDKAwsEventStreamException(
                        $""AWS EventStream header '{{name}}' is missing a value type byte."");
                }}

                var valueType = body[index];
                index += 1;

                string? value;
                switch (valueType)
                {{
                    case TypeBoolTrue:
                        value = ""true"";
                        break;
                    case TypeBoolFalse:
                        value = ""false"";
                        break;
                    case TypeByte:
                        if (index >= end) goto truncated;
                        value = ((sbyte)body[index]).ToString(global::System.Globalization.CultureInfo.InvariantCulture);
                        index += 1;
                        break;
                    case TypeShort:
                        if (index + 2 > end) goto truncated;
                        value = ((short)ReadBigEndianInt16(body, index)).ToString(global::System.Globalization.CultureInfo.InvariantCulture);
                        index += 2;
                        break;
                    case TypeInteger:
                        if (index + 4 > end) goto truncated;
                        value = ReadBigEndianInt32(body, index).ToString(global::System.Globalization.CultureInfo.InvariantCulture);
                        index += 4;
                        break;
                    case TypeLong:
                    case TypeTimestamp:
                        if (index + 8 > end) goto truncated;
                        {{
                            long longValue = 0;
                            for (var i = 0; i < 8; i++)
                            {{
                                longValue = (longValue << 8) | body[index + i];
                            }}
                            value = longValue.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
                        }}
                        index += 8;
                        break;
                    case TypeString:
                    case TypeByteArray:
                    {{
                        if (index + 2 > end) goto truncated;
                        var valueLength = ReadBigEndianInt16(body, index);
                        index += 2;
                        if (index + valueLength > end) goto truncated;

                        value = valueType == TypeString
                            ? global::System.Text.Encoding.UTF8.GetString(body, index, valueLength)
                            : global::System.Convert.ToBase64String(body, index, valueLength);
                        index += valueLength;
                        break;
                    }}
                    case TypeUuid:
                        if (index + 16 > end) goto truncated;
                        {{
                            var uuidBytes = new byte[16];
                            global::System.Buffer.BlockCopy(body, index, uuidBytes, 0, 16);
                            value = new global::System.Guid(uuidBytes).ToString();
                        }}
                        index += 16;
                        break;
                    default:
                        throw new global::{settings.Namespace}.AutoSDKAwsEventStreamException(
                            $""AWS EventStream header '{{name}}' uses unsupported value type 0x{{valueType:X2}}."");
                }}

                headers[name] = value ?? string.Empty;
                continue;

                truncated:
                throw new global::{settings.Namespace}.AutoSDKAwsEventStreamException(
                    $""AWS EventStream header '{{name}}' value is truncated."");
            }}

            return headers;
        }}

        private static string? TryGetHeader(
            global::System.Collections.Generic.Dictionary<string, string> headers,
            string name)
        {{
            return headers.TryGetValue(name, out var value) ? value : null;
        }}
    }}
}}
".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
