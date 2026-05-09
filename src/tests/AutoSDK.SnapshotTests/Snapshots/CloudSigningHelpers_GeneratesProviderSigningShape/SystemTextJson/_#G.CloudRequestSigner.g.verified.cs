//HintName: G.CloudRequestSigner.g.cs
#nullable enable

namespace G
{
    public enum CloudSigningProvider
    {
        None = 0,
        AwsSigV4 = 1,
        AzureApiKey = 2,
        AzureTokenCredential = 3,
        TencentTc3 = 4,
    }

    public sealed class CloudSigningMetadata
    {
        public CloudSigningProvider Provider { get; set; }

        public string? Region { get; set; }

        public string? Service { get; set; }

        public string? ApiKeyHeaderName { get; set; }

        public string? TokenScope { get; set; }

        public global::System.Collections.Generic.IList<string> CredentialEnvironmentVariables { get; } =
            new global::System.Collections.Generic.List<string>();
    }

    public sealed class CloudCredential
    {
        public CloudCredential(
            string accessKeyId,
            string secretAccessKey,
            string? sessionToken = null)
        {
            if (string.IsNullOrWhiteSpace(accessKeyId))
            {
                throw new global::System.ArgumentException("Access key id must be non-empty.", nameof(accessKeyId));
            }

            if (string.IsNullOrWhiteSpace(secretAccessKey))
            {
                throw new global::System.ArgumentException("Secret access key must be non-empty.", nameof(secretAccessKey));
            }

            AccessKeyId = accessKeyId;
            SecretAccessKey = secretAccessKey;
            SessionToken = string.IsNullOrWhiteSpace(sessionToken) ? null : sessionToken;
        }

        public string AccessKeyId { get; }

        public string SecretAccessKey { get; }

        public string? SessionToken { get; }

        public static CloudCredential FromAwsEnvironment()
        {
            return new CloudCredential(
                RequireEnvironmentVariable("AWS_ACCESS_KEY_ID"),
                RequireEnvironmentVariable("AWS_SECRET_ACCESS_KEY"),
                GetEnvironmentVariable("AWS_SESSION_TOKEN"));
        }

        public static CloudCredential FromTencentEnvironment()
        {
            return new CloudCredential(
                RequireEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                RequireEnvironmentVariable("TENCENTCLOUD_SECRET_KEY"),
                GetEnvironmentVariable("TENCENTCLOUD_TOKEN"));
        }

        private static string? GetEnvironmentVariable(
            string name)
        {
            var value = global::System.Environment.GetEnvironmentVariable(name);
            return string.IsNullOrWhiteSpace(value) ? null : value;
        }

        private static string RequireEnvironmentVariable(
            string name)
        {
            return GetEnvironmentVariable(name) ??
                throw new global::System.InvalidOperationException($"Environment variable '{name}' is required for cloud request signing.");
        }
    }

    public interface ICloudRequestSigner
    {
        global::System.Threading.Tasks.Task SignAsync(
            global::System.Net.Http.HttpRequestMessage request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }

    public static class CloudRequestSigner
    {
        public static AwsSigV4RequestSigner CreateAwsSigV4(
            CloudCredential credential,
            string region,
            string service)
        {
            return new AwsSigV4RequestSigner(credential, region, service);
        }

        public static AzureApiKeyRequestSigner CreateAzureApiKey(
            string apiKey,
            string headerName = "api-key")
        {
            return new AzureApiKeyRequestSigner(apiKey, headerName);
        }

        public static AzureBearerTokenRequestSigner CreateAzureBearerToken(
            global::System.Func<global::System.Collections.Generic.IReadOnlyList<string>, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<string>> tokenProvider,
            global::System.Collections.Generic.IEnumerable<string>? scopes = null)
        {
            return new AzureBearerTokenRequestSigner(tokenProvider, scopes);
        }

        public static TencentTc3RequestSigner CreateTencentTc3(
            CloudCredential credential,
            string region,
            string service)
        {
            return new TencentTc3RequestSigner(credential, region, service);
        }

        public static CloudRequestSigningHook CreateHook(
            ICloudRequestSigner signer)
        {
            return new CloudRequestSigningHook(signer);
        }
    }

    public sealed class CloudRequestSigningHook : AutoSDKHook
    {
        private readonly ICloudRequestSigner _signer;

        public CloudRequestSigningHook(
            ICloudRequestSigner signer)
        {
            _signer = signer ?? throw new global::System.ArgumentNullException(nameof(signer));
        }

        public override global::System.Threading.Tasks.Task OnBeforeRequestAsync(
            global::G.AutoSDKHookContext context)
        {
            if (context is null)
            {
                throw new global::System.ArgumentNullException(nameof(context));
            }

            return _signer.SignAsync(context.Request, context.CancellationToken);
        }
    }

    public sealed class AwsSigV4RequestSigner : ICloudRequestSigner
    {
        private readonly CloudCredential _credential;
        private readonly string _region;
        private readonly string _service;
        private readonly global::System.Func<global::System.DateTimeOffset> _clock;

        public AwsSigV4RequestSigner(
            CloudCredential credential,
            string region,
            string service,
            global::System.Func<global::System.DateTimeOffset>? clock = null)
        {
            _credential = credential ?? throw new global::System.ArgumentNullException(nameof(credential));
            _region = CloudSigningUtilities.RequireNonEmpty(region, nameof(region));
            _service = CloudSigningUtilities.RequireNonEmpty(service, nameof(service));
            _clock = clock ?? (() => global::System.DateTimeOffset.UtcNow);
        }

        public async global::System.Threading.Tasks.Task SignAsync(
            global::System.Net.Http.HttpRequestMessage request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new global::System.ArgumentNullException(nameof(request));
            }

            cancellationToken.ThrowIfCancellationRequested();

            var uri = request.RequestUri ?? throw new global::System.InvalidOperationException("RequestUri is required for AWS SigV4 signing.");
            var timestamp = _clock().ToUniversalTime();
            var amzDate = timestamp.ToString("yyyyMMdd'T'HHmmss'Z'", global::System.Globalization.CultureInfo.InvariantCulture);
            var date = timestamp.ToString("yyyyMMdd", global::System.Globalization.CultureInfo.InvariantCulture);
            var payloadHash = await CloudSigningUtilities.ComputePayloadHashAsync(request.Content).ConfigureAwait(false);
            var host = CloudSigningUtilities.GetHostHeader(uri);

            CloudSigningUtilities.SetHeader(request, "host", host);
            CloudSigningUtilities.SetHeader(request, "x-amz-date", amzDate);
            CloudSigningUtilities.SetHeader(request, "x-amz-content-sha256", payloadHash);
            if (!string.IsNullOrWhiteSpace(_credential.SessionToken))
            {
                CloudSigningUtilities.SetHeader(request, "x-amz-security-token", _credential.SessionToken!);
            }

            var canonicalHeaders = new global::System.Collections.Generic.SortedDictionary<string, string>(global::System.StringComparer.Ordinal)
            {
                ["host"] = host,
                ["x-amz-content-sha256"] = payloadHash,
                ["x-amz-date"] = amzDate,
            };
            if (!string.IsNullOrWhiteSpace(_credential.SessionToken))
            {
                canonicalHeaders["x-amz-security-token"] = _credential.SessionToken!;
            }

            var signedHeaders = CloudSigningUtilities.BuildSignedHeaders(canonicalHeaders);
            var canonicalRequest = request.Method.Method.ToUpperInvariant() + "\n" +
                CloudSigningUtilities.CanonicalizePath(uri) + "\n" +
                CloudSigningUtilities.CanonicalizeQuery(uri.Query) + "\n" +
                CloudSigningUtilities.BuildCanonicalHeaders(canonicalHeaders) + "\n" +
                signedHeaders + "\n" +
                payloadHash;
            var credentialScope = date + "/" + _region + "/" + _service + "/aws4_request";
            var stringToSign = "AWS4-HMAC-SHA256\n" +
                amzDate + "\n" +
                credentialScope + "\n" +
                CloudSigningUtilities.Sha256Hex(canonicalRequest);
            var signingKey = CloudSigningUtilities.Hmac(
                CloudSigningUtilities.Hmac(
                    CloudSigningUtilities.Hmac(
                        CloudSigningUtilities.Hmac(
                            global::System.Text.Encoding.UTF8.GetBytes("AWS4" + _credential.SecretAccessKey),
                            date),
                        _region),
                    _service),
                "aws4_request");
            var signature = CloudSigningUtilities.ToHex(CloudSigningUtilities.Hmac(signingKey, stringToSign));
            var authorization = "AWS4-HMAC-SHA256 Credential=" + _credential.AccessKeyId + "/" + credentialScope +
                ", SignedHeaders=" + signedHeaders +
                ", Signature=" + signature;
            CloudSigningUtilities.SetHeader(request, "Authorization", authorization);
        }
    }

    public sealed class AzureApiKeyRequestSigner : ICloudRequestSigner
    {
        private readonly string _apiKey;
        private readonly string _headerName;

        public AzureApiKeyRequestSigner(
            string apiKey,
            string headerName = "api-key")
        {
            _apiKey = CloudSigningUtilities.RequireNonEmpty(apiKey, nameof(apiKey));
            _headerName = CloudSigningUtilities.RequireNonEmpty(headerName, nameof(headerName));
        }

        public global::System.Threading.Tasks.Task SignAsync(
            global::System.Net.Http.HttpRequestMessage request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new global::System.ArgumentNullException(nameof(request));
            }

            cancellationToken.ThrowIfCancellationRequested();
            CloudSigningUtilities.SetHeader(request, _headerName, _apiKey);
            return global::System.Threading.Tasks.Task.CompletedTask;
        }
    }

    public sealed class AzureBearerTokenRequestSigner : ICloudRequestSigner
    {
        private readonly global::System.Func<global::System.Collections.Generic.IReadOnlyList<string>, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<string>> _tokenProvider;
        private readonly global::System.Collections.Generic.IReadOnlyList<string> _scopes;

        public AzureBearerTokenRequestSigner(
            global::System.Func<global::System.Collections.Generic.IReadOnlyList<string>, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<string>> tokenProvider,
            global::System.Collections.Generic.IEnumerable<string>? scopes = null)
        {
            _tokenProvider = tokenProvider ?? throw new global::System.ArgumentNullException(nameof(tokenProvider));
            _scopes = scopes is null
                ? new global::System.Collections.Generic.List<string> { "https://cognitiveservices.azure.com/.default" }
                : new global::System.Collections.Generic.List<string>(scopes);
        }

        public async global::System.Threading.Tasks.Task SignAsync(
            global::System.Net.Http.HttpRequestMessage request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new global::System.ArgumentNullException(nameof(request));
            }

            var token = await _tokenProvider(_scopes, cancellationToken).ConfigureAwait(false);
            request.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                "Bearer",
                CloudSigningUtilities.RequireNonEmpty(token, "token"));
        }
    }

    public sealed class TencentTc3RequestSigner : ICloudRequestSigner
    {
        private readonly CloudCredential _credential;
        private readonly string _region;
        private readonly string _service;
        private readonly global::System.Func<global::System.DateTimeOffset> _clock;

        public TencentTc3RequestSigner(
            CloudCredential credential,
            string region,
            string service,
            global::System.Func<global::System.DateTimeOffset>? clock = null)
        {
            _credential = credential ?? throw new global::System.ArgumentNullException(nameof(credential));
            _region = CloudSigningUtilities.RequireNonEmpty(region, nameof(region));
            _service = CloudSigningUtilities.RequireNonEmpty(service, nameof(service));
            _clock = clock ?? (() => global::System.DateTimeOffset.UtcNow);
        }

        public async global::System.Threading.Tasks.Task SignAsync(
            global::System.Net.Http.HttpRequestMessage request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (request is null)
            {
                throw new global::System.ArgumentNullException(nameof(request));
            }

            cancellationToken.ThrowIfCancellationRequested();

            var uri = request.RequestUri ?? throw new global::System.InvalidOperationException("RequestUri is required for Tencent TC3 signing.");
            var timestamp = _clock().ToUniversalTime();
            var unixTimestamp = timestamp.ToUnixTimeSeconds().ToString(global::System.Globalization.CultureInfo.InvariantCulture);
            var date = timestamp.ToString("yyyy-MM-dd", global::System.Globalization.CultureInfo.InvariantCulture);
            var payloadHash = await CloudSigningUtilities.ComputePayloadHashAsync(request.Content).ConfigureAwait(false);
            var host = CloudSigningUtilities.GetHostHeader(uri);

            CloudSigningUtilities.SetHeader(request, "host", host);
            CloudSigningUtilities.SetHeader(request, "x-tc-date", unixTimestamp);
            CloudSigningUtilities.SetHeader(request, "x-tc-region", _region);
            if (!string.IsNullOrWhiteSpace(_credential.SessionToken))
            {
                CloudSigningUtilities.SetHeader(request, "x-tc-token", _credential.SessionToken!);
            }

            var canonicalHeaders = new global::System.Collections.Generic.SortedDictionary<string, string>(global::System.StringComparer.Ordinal)
            {
                ["host"] = host,
                ["x-tc-date"] = unixTimestamp,
                ["x-tc-region"] = _region,
            };
            if (!string.IsNullOrWhiteSpace(_credential.SessionToken))
            {
                canonicalHeaders["x-tc-token"] = _credential.SessionToken!;
            }

            var signedHeaders = CloudSigningUtilities.BuildSignedHeaders(canonicalHeaders);
            var canonicalRequest = request.Method.Method.ToUpperInvariant() + "\n" +
                CloudSigningUtilities.CanonicalizePath(uri) + "\n" +
                CloudSigningUtilities.CanonicalizeQuery(uri.Query) + "\n" +
                CloudSigningUtilities.BuildCanonicalHeaders(canonicalHeaders) + "\n" +
                signedHeaders + "\n" +
                payloadHash;
            var credentialScope = date + "/" + _service + "/tc3_request";
            var stringToSign = "TC3-HMAC-SHA256\n" +
                unixTimestamp + "\n" +
                credentialScope + "\n" +
                CloudSigningUtilities.Sha256Hex(canonicalRequest);
            var signingKey = CloudSigningUtilities.Hmac(
                CloudSigningUtilities.Hmac(
                    CloudSigningUtilities.Hmac(
                        global::System.Text.Encoding.UTF8.GetBytes("TC3" + _credential.SecretAccessKey),
                        date),
                    _service),
                "tc3_request");
            var signature = CloudSigningUtilities.ToHex(CloudSigningUtilities.Hmac(signingKey, stringToSign));
            var authorization = "TC3-HMAC-SHA256 Credential=" + _credential.AccessKeyId + "/" + credentialScope +
                ", SignedHeaders=" + signedHeaders +
                ", Signature=" + signature;
            CloudSigningUtilities.SetHeader(request, "Authorization", authorization);
        }
    }

    internal static class CloudSigningUtilities
    {
        public static string RequireNonEmpty(
            string value,
            string parameterName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new global::System.ArgumentException("Value must be non-empty.", parameterName);
            }

            return value;
        }

        public static void SetHeader(
            global::System.Net.Http.HttpRequestMessage request,
            string name,
            string value)
        {
            request.Headers.Remove(name);
            request.Headers.TryAddWithoutValidation(name, value);
        }

        public static string GetHostHeader(
            global::System.Uri uri)
        {
            return uri.IsDefaultPort
                ? uri.Host
                : uri.Host + ":" + uri.Port.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
        }

        public static async global::System.Threading.Tasks.Task<string> ComputePayloadHashAsync(
            global::System.Net.Http.HttpContent? content)
        {
            if (content is null)
            {
                return Sha256Hex(global::System.Array.Empty<byte>());
            }

            var bytes = await content.ReadAsByteArrayAsync().ConfigureAwait(false);
            return Sha256Hex(bytes);
        }

        public static string Sha256Hex(
            string value)
        {
            return Sha256Hex(global::System.Text.Encoding.UTF8.GetBytes(value));
        }

        public static string Sha256Hex(
            byte[] bytes)
        {
            using var sha256 = global::System.Security.Cryptography.SHA256.Create();
            return ToHex(sha256.ComputeHash(bytes));
        }

        public static byte[] Hmac(
            byte[] key,
            string value)
        {
            using var hmac = new global::System.Security.Cryptography.HMACSHA256(key);
            return hmac.ComputeHash(global::System.Text.Encoding.UTF8.GetBytes(value));
        }

        public static string ToHex(
            byte[] bytes)
        {
            var builder = new global::System.Text.StringBuilder(bytes.Length * 2);
            for (var i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2", global::System.Globalization.CultureInfo.InvariantCulture));
            }

            return builder.ToString();
        }

        public static string CanonicalizePath(
            global::System.Uri uri)
        {
            var path = string.IsNullOrEmpty(uri.AbsolutePath) ? "/" : uri.AbsolutePath;
            var segments = path.Split('/');
            var builder = new global::System.Text.StringBuilder(path.Length + 8);
            for (var i = 0; i < segments.Length; i++)
            {
                if (i > 0)
                {
                    builder.Append('/');
                }

                builder.Append(Escape(global::System.Uri.UnescapeDataString(segments[i])));
            }

            return builder.Length == 0 ? "/" : builder.ToString();
        }

        public static string CanonicalizeQuery(
            string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                return string.Empty;
            }

            var trimmed = query[0] == '?' ? query.Substring(1) : query;
            if (trimmed.Length == 0)
            {
                return string.Empty;
            }

            var parameters = new global::System.Collections.Generic.List<CanonicalQueryParameter>();
            var parts = trimmed.Split('&');
            for (var i = 0; i < parts.Length; i++)
            {
                var part = parts[i];
                var equalsIndex = part.IndexOf('=');
                var name = equalsIndex < 0 ? part : part.Substring(0, equalsIndex);
                var value = equalsIndex < 0 ? string.Empty : part.Substring(equalsIndex + 1);
                parameters.Add(new CanonicalQueryParameter(
                    Escape(global::System.Uri.UnescapeDataString(name.Replace("+", " "))),
                    Escape(global::System.Uri.UnescapeDataString(value.Replace("+", " ")))));
            }

            parameters.Sort((left, right) =>
            {
                var nameComparison = global::System.StringComparer.Ordinal.Compare(left.Name, right.Name);
                return nameComparison != 0
                    ? nameComparison
                    : global::System.StringComparer.Ordinal.Compare(left.Value, right.Value);
            });

            var builder = new global::System.Text.StringBuilder(trimmed.Length);
            for (var i = 0; i < parameters.Count; i++)
            {
                if (i > 0)
                {
                    builder.Append('&');
                }

                builder.Append(parameters[i].Name);
                builder.Append('=');
                builder.Append(parameters[i].Value);
            }

            return builder.ToString();
        }

        public static string BuildCanonicalHeaders(
            global::System.Collections.Generic.SortedDictionary<string, string> headers)
        {
            var builder = new global::System.Text.StringBuilder();
            foreach (var header in headers)
            {
                builder.Append(header.Key);
                builder.Append(':');
                builder.Append(NormalizeHeaderValue(header.Value));
                builder.Append('\n');
            }

            return builder.ToString();
        }

        public static string BuildSignedHeaders(
            global::System.Collections.Generic.SortedDictionary<string, string> headers)
        {
            var builder = new global::System.Text.StringBuilder();
            var index = 0;
            foreach (var header in headers)
            {
                if (index > 0)
                {
                    builder.Append(';');
                }

                builder.Append(header.Key);
                index++;
            }

            return builder.ToString();
        }

        private static string NormalizeHeaderValue(
            string value)
        {
            var trimmed = value.Trim();
            var builder = new global::System.Text.StringBuilder(trimmed.Length);
            var previousWhitespace = false;
            for (var i = 0; i < trimmed.Length; i++)
            {
                var c = trimmed[i];
                if (char.IsWhiteSpace(c))
                {
                    if (!previousWhitespace)
                    {
                        builder.Append(' ');
                    }

                    previousWhitespace = true;
                    continue;
                }

                builder.Append(c);
                previousWhitespace = false;
            }

            return builder.ToString();
        }

        private static string Escape(
            string value)
        {
            return global::System.Uri.EscapeDataString(value).Replace("%7E", "~");
        }

        private sealed class CanonicalQueryParameter
        {
            public CanonicalQueryParameter(
                string name,
                string value)
            {
                Name = name;
                Value = value;
            }

            public string Name { get; }

            public string Value { get; }
        }
    }
}
