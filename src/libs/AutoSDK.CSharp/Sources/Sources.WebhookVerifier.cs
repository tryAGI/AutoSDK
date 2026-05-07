using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    private static string GetWebhookVerifierClassName(
        CSharpSettings settings)
    {
        var configuredClassName = settings.WebhookVerifierClassName;
        if (string.IsNullOrWhiteSpace(configuredClassName))
        {
            configuredClassName = "WebhookVerifier";
        }

        return configuredClassName
            .ToPropertyName()
            .UseWordSeparator('.', '-', '_', '/');
    }

    public static string GenerateWebhookVerifier(
        CSharpSettings settings,
        string className,
        CancellationToken cancellationToken = default)
    {
        var idHeaderName = string.IsNullOrWhiteSpace(settings.WebhookIdHeaderName)
            ? Settings.Default.WebhookIdHeaderName
            : settings.WebhookIdHeaderName;
        var timestampHeaderName = string.IsNullOrWhiteSpace(settings.WebhookTimestampHeaderName)
            ? Settings.Default.WebhookTimestampHeaderName
            : settings.WebhookTimestampHeaderName;
        var signatureHeaderName = string.IsNullOrWhiteSpace(settings.WebhookSignatureHeaderName)
            ? Settings.Default.WebhookSignatureHeaderName
            : settings.WebhookSignatureHeaderName;
        var signatureVersion = string.IsNullOrWhiteSpace(settings.WebhookSignatureVersion)
            ? Settings.Default.WebhookSignatureVersion
            : settings.WebhookSignatureVersion;
        var timestampToleranceSeconds = settings.WebhookTimestampToleranceSeconds > 0
            ? settings.WebhookTimestampToleranceSeconds
            : Settings.Default.WebhookTimestampToleranceSeconds;

        return $@"#nullable enable

namespace {settings.Namespace}
{{
    /// <summary>
    /// Webhook verification failure category.
    /// </summary>
    public enum WebhookVerificationError
    {{
        None = 0,
        MissingHeader,
        MalformedTimestamp,
        StaleTimestamp,
        MalformedSignature,
        InvalidSignature,
    }}

    /// <summary>
    /// Result returned by webhook verification.
    /// </summary>
    public sealed class WebhookVerificationResult
    {{
        private WebhookVerificationResult(
            bool isValid,
            WebhookVerificationError error,
            string message)
        {{
            IsValid = isValid;
            Error = error;
            Message = message;
        }}

        /// <summary>
        /// True when the webhook signature is valid.
        /// </summary>
        public bool IsValid {{ get; }}

        /// <summary>
        /// Verification error category.
        /// </summary>
        public WebhookVerificationError Error {{ get; }}

        /// <summary>
        /// Human-readable verification message.
        /// </summary>
        public string Message {{ get; }}

        internal static WebhookVerificationResult Valid()
        {{
            return new WebhookVerificationResult(
                isValid: true,
                error: WebhookVerificationError.None,
                message: string.Empty);
        }}

        internal static WebhookVerificationResult Invalid(
            WebhookVerificationError error,
            string message)
        {{
            return new WebhookVerificationResult(
                isValid: false,
                error: error,
                message: message);
        }}
    }}

    /// <summary>
    /// Exception thrown by webhook verification helpers.
    /// </summary>
    public sealed class WebhookVerificationException : global::System.Exception
    {{
        internal WebhookVerificationException(
            WebhookVerificationResult result) : base(result.Message)
        {{
            Result = result;
            Error = result.Error;
        }}

        /// <summary>
        /// Verification error category.
        /// </summary>
        public WebhookVerificationError Error {{ get; }}

        /// <summary>
        /// Verification result.
        /// </summary>
        public WebhookVerificationResult Result {{ get; }}
    }}

    /// <summary>
    /// Verifies Replicate/Svix-style HMAC webhook signatures.
    /// </summary>
    public sealed class {className}
    {{
        /// <summary>
        /// Webhook id header name.
        /// </summary>
        public const string IdHeaderName = {idHeaderName.ToCSharpStringLiteral()};

        /// <summary>
        /// Webhook timestamp header name.
        /// </summary>
        public const string TimestampHeaderName = {timestampHeaderName.ToCSharpStringLiteral()};

        /// <summary>
        /// Webhook signature header name.
        /// </summary>
        public const string SignatureHeaderName = {signatureHeaderName.ToCSharpStringLiteral()};

        /// <summary>
        /// Webhook signature version prefix.
        /// </summary>
        public const string SignatureVersion = {signatureVersion.ToCSharpStringLiteral()};

        private readonly byte[] _secret;
        private global::System.Func<global::System.DateTimeOffset> _clock = static () => global::System.DateTimeOffset.UtcNow;

        /// <summary>
        /// Creates a new webhook verifier.
        /// </summary>
        public {className}(
            string secret,
            global::System.TimeSpan? timestampTolerance = null) : this(
                GetSecretBytes(secret),
                timestampTolerance)
        {{
        }}

        /// <summary>
        /// Creates a new webhook verifier.
        /// </summary>
        public {className}(
            byte[] secret,
            global::System.TimeSpan? timestampTolerance = null)
        {{
            if (secret is null)
            {{
                throw new global::System.ArgumentNullException(nameof(secret));
            }}
            if (secret.Length == 0)
            {{
                throw new global::System.ArgumentException(""Webhook signing secret must not be empty."", nameof(secret));
            }}

            _secret = new byte[secret.Length];
            global::System.Buffer.BlockCopy(secret, 0, _secret, 0, secret.Length);
            TimestampTolerance = timestampTolerance ?? global::System.TimeSpan.FromSeconds({timestampToleranceSeconds.ToString(System.Globalization.CultureInfo.InvariantCulture)});
            if (TimestampTolerance <= global::System.TimeSpan.Zero)
            {{
                throw new global::System.ArgumentOutOfRangeException(nameof(timestampTolerance), ""Timestamp tolerance must be positive."");
            }}
        }}

        /// <summary>
        /// Timestamp tolerance used to reject stale webhooks.
        /// </summary>
        public global::System.TimeSpan TimestampTolerance {{ get; }}

        /// <summary>
        /// Clock used during timestamp validation. Override in tests when deterministic time is required.
        /// </summary>
        public global::System.Func<global::System.DateTimeOffset> Clock
        {{
            get => _clock;
            set => _clock = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }}

        /// <summary>
        /// Verifies an HttpRequestMessage and raw webhook body string.
        /// </summary>
        public WebhookVerificationResult Verify(
            global::System.Net.Http.HttpRequestMessage request,
            string payload)
        {{
            return Verify(request, GetPayloadBytes(payload));
        }}

        /// <summary>
        /// Verifies an HttpRequestMessage and raw webhook body bytes.
        /// </summary>
        public WebhookVerificationResult Verify(
            global::System.Net.Http.HttpRequestMessage request,
            byte[] payload)
        {{
            if (request is null)
            {{
                throw new global::System.ArgumentNullException(nameof(request));
            }}
            if (payload is null)
            {{
                throw new global::System.ArgumentNullException(nameof(payload));
            }}

            if (!TryGetHeader(request, IdHeaderName, out var id))
            {{
                return MissingHeader(IdHeaderName);
            }}
            if (!TryGetHeader(request, TimestampHeaderName, out var timestamp))
            {{
                return MissingHeader(TimestampHeaderName);
            }}
            if (!TryGetHeader(request, SignatureHeaderName, out var signature))
            {{
                return MissingHeader(SignatureHeaderName);
            }}

            return VerifyValues(id, timestamp, signature, payload);
        }}

        /// <summary>
        /// Verifies headers and raw webhook body string.
        /// </summary>
        public WebhookVerificationResult Verify(
            global::System.Collections.Generic.IReadOnlyDictionary<string, string> headers,
            string payload)
        {{
            return Verify(headers, GetPayloadBytes(payload));
        }}

        /// <summary>
        /// Verifies headers and raw webhook body bytes.
        /// </summary>
        public WebhookVerificationResult Verify(
            global::System.Collections.Generic.IReadOnlyDictionary<string, string> headers,
            byte[] payload)
        {{
            if (headers is null)
            {{
                throw new global::System.ArgumentNullException(nameof(headers));
            }}
            if (payload is null)
            {{
                throw new global::System.ArgumentNullException(nameof(payload));
            }}

            if (!TryGetHeader(headers, IdHeaderName, out var id))
            {{
                return MissingHeader(IdHeaderName);
            }}
            if (!TryGetHeader(headers, TimestampHeaderName, out var timestamp))
            {{
                return MissingHeader(TimestampHeaderName);
            }}
            if (!TryGetHeader(headers, SignatureHeaderName, out var signature))
            {{
                return MissingHeader(SignatureHeaderName);
            }}

            return VerifyValues(id, timestamp, signature, payload);
        }}

        /// <summary>
        /// Verifies headers and throws when verification fails.
        /// </summary>
        public void VerifyOrThrow(
            global::System.Collections.Generic.IReadOnlyDictionary<string, string> headers,
            byte[] payload)
        {{
            var result = Verify(headers, payload);
            if (!result.IsValid)
            {{
                throw new WebhookVerificationException(result);
            }}
        }}

        /// <summary>
        /// Verifies an HttpRequestMessage and throws when verification fails.
        /// </summary>
        public void VerifyOrThrow(
            global::System.Net.Http.HttpRequestMessage request,
            byte[] payload)
        {{
            var result = Verify(request, payload);
            if (!result.IsValid)
            {{
                throw new WebhookVerificationException(result);
            }}
        }}

        private WebhookVerificationResult VerifyValues(
            string id,
            string timestamp,
            string signature,
            byte[] payload)
        {{
            if (!long.TryParse(timestamp, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out var unixTimestamp))
            {{
                return WebhookVerificationResult.Invalid(
                    WebhookVerificationError.MalformedTimestamp,
                    ""Webhook timestamp is not a Unix timestamp."");
            }}

            global::System.DateTimeOffset timestampValue;
            try
            {{
                timestampValue = global::System.DateTimeOffset.FromUnixTimeSeconds(unixTimestamp);
            }}
            catch (global::System.ArgumentOutOfRangeException)
            {{
                return WebhookVerificationResult.Invalid(
                    WebhookVerificationError.MalformedTimestamp,
                    ""Webhook timestamp is outside the supported range."");
            }}

            var age = Clock() - timestampValue;
            if (age < global::System.TimeSpan.Zero)
            {{
                age = -age;
            }}

            if (age > TimestampTolerance)
            {{
                return WebhookVerificationResult.Invalid(
                    WebhookVerificationError.StaleTimestamp,
                    ""Webhook timestamp is outside the configured tolerance."");
            }}

            var expectedSignature = ComputeSignature(CreateSignedPayload(id, timestamp, payload));
            if (ContainsValidSignature(signature, expectedSignature, out var malformedSignature))
            {{
                return WebhookVerificationResult.Valid();
            }}

            return malformedSignature
                ? WebhookVerificationResult.Invalid(
                    WebhookVerificationError.MalformedSignature,
                    ""Webhook signature header does not contain a valid signature value."")
                : WebhookVerificationResult.Invalid(
                    WebhookVerificationError.InvalidSignature,
                    ""Webhook signature does not match the payload."");
        }}

        private byte[] ComputeSignature(
            byte[] payload)
        {{
            using var hmac = new global::System.Security.Cryptography.HMACSHA256(_secret);
            return hmac.ComputeHash(payload);
        }}

        private static byte[] CreateSignedPayload(
            string id,
            string timestamp,
            byte[] payload)
        {{
            var idBytes = global::System.Text.Encoding.UTF8.GetBytes(id);
            var timestampBytes = global::System.Text.Encoding.UTF8.GetBytes(timestamp);
            var result = new byte[idBytes.Length + timestampBytes.Length + payload.Length + 2];

            global::System.Buffer.BlockCopy(idBytes, 0, result, 0, idBytes.Length);
            result[idBytes.Length] = (byte)'.';
            global::System.Buffer.BlockCopy(timestampBytes, 0, result, idBytes.Length + 1, timestampBytes.Length);
            result[idBytes.Length + timestampBytes.Length + 1] = (byte)'.';
            global::System.Buffer.BlockCopy(payload, 0, result, idBytes.Length + timestampBytes.Length + 2, payload.Length);

            return result;
        }}

        private static bool ContainsValidSignature(
            string signature,
            byte[] expectedSignature,
            out bool malformedSignature)
        {{
            malformedSignature = false;
            var prefix = SignatureVersion + "","";
            var sawVersion = false;
            var sawDecodedSignature = false;

            foreach (var rawPart in signature.Split(' '))
            {{
                var part = rawPart.Trim();
                if (part.Length == 0)
                {{
                    continue;
                }}
                if (!part.StartsWith(prefix, global::System.StringComparison.Ordinal))
                {{
                    continue;
                }}

                sawVersion = true;
                var encodedSignature = part.Substring(prefix.Length);
                byte[] candidateSignature;
                try
                {{
                    candidateSignature = global::System.Convert.FromBase64String(encodedSignature);
                }}
                catch (global::System.FormatException)
                {{
                    malformedSignature = true;
                    continue;
                }}

                sawDecodedSignature = true;
                if (FixedTimeEquals(expectedSignature, candidateSignature))
                {{
                    return true;
                }}
            }}

            malformedSignature = malformedSignature || !sawVersion || !sawDecodedSignature;
            return false;
        }}

        private static bool FixedTimeEquals(
            byte[] left,
            byte[] right)
        {{
            var difference = left.Length ^ right.Length;
            for (var i = 0; i < left.Length; i++)
            {{
                var rightValue = i < right.Length ? right[i] : 0;
                difference |= left[i] ^ rightValue;
            }}

            return difference == 0;
        }}

        private static WebhookVerificationResult MissingHeader(
            string headerName)
        {{
            return WebhookVerificationResult.Invalid(
                WebhookVerificationError.MissingHeader,
                ""Missing required webhook header '"" + headerName + ""'."");
        }}

        private static bool TryGetHeader(
            global::System.Net.Http.HttpRequestMessage request,
            string name,
            out string value)
        {{
            if (request.Headers.TryGetValues(name, out var headerValues) &&
                TryJoinHeaderValues(headerValues, out value))
            {{
                return true;
            }}

            if (request.Content is not null &&
                request.Content.Headers.TryGetValues(name, out headerValues) &&
                TryJoinHeaderValues(headerValues, out value))
            {{
                return true;
            }}

            value = string.Empty;
            return false;
        }}

        private static bool TryGetHeader(
            global::System.Collections.Generic.IReadOnlyDictionary<string, string> headers,
            string name,
            out string value)
        {{
            if (headers.TryGetValue(name, out var headerValue) &&
                !string.IsNullOrWhiteSpace(headerValue))
            {{
                value = headerValue;
                return true;
            }}

            foreach (var pair in headers)
            {{
                if (string.Equals(pair.Key, name, global::System.StringComparison.OrdinalIgnoreCase) &&
                    !string.IsNullOrWhiteSpace(pair.Value))
                {{
                    value = pair.Value;
                    return true;
                }}
            }}

            value = string.Empty;
            return false;
        }}

        private static bool TryJoinHeaderValues(
            global::System.Collections.Generic.IEnumerable<string> values,
            out string value)
        {{
            var builder = new global::System.Text.StringBuilder();
            foreach (var item in values)
            {{
                if (string.IsNullOrWhiteSpace(item))
                {{
                    continue;
                }}

                if (builder.Length > 0)
                {{
                    builder.Append(' ');
                }}

                builder.Append(item);
            }}

            value = builder.ToString();
            return value.Length > 0;
        }}

        private static byte[] GetSecretBytes(
            string secret)
        {{
            if (string.IsNullOrEmpty(secret))
            {{
                throw new global::System.ArgumentException(""Webhook signing secret must not be empty."", nameof(secret));
            }}

            const string encodedSecretPrefix = ""whsec_"";
            if (secret.StartsWith(encodedSecretPrefix, global::System.StringComparison.OrdinalIgnoreCase))
            {{
                try
                {{
                    return global::System.Convert.FromBase64String(secret.Substring(encodedSecretPrefix.Length));
                }}
                catch (global::System.FormatException ex)
                {{
                    throw new global::System.ArgumentException(""Webhook signing secret is not valid base64."", nameof(secret), ex);
                }}
            }}

            return global::System.Text.Encoding.UTF8.GetBytes(secret);
        }}

        private static byte[] GetPayloadBytes(
            string payload)
        {{
            if (payload is null)
            {{
                throw new global::System.ArgumentNullException(nameof(payload));
            }}

            return global::System.Text.Encoding.UTF8.GetBytes(payload);
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
