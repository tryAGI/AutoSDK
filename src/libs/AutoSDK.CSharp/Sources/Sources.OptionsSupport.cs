using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateOptionsSupport(
        CSharpSettings settings,
        CancellationToken cancellationToken = default)
    {
        return $@"
#nullable enable

namespace {settings.Namespace}
{{
    /// <summary>
    /// Global defaults applied to generated SDK requests.
    /// </summary>
    public sealed class AutoSDKClientOptions
    {{
        /// <summary>
        /// Additional headers applied to every request after generated headers are set.
        /// Entries with the same key overwrite earlier header values.
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string> Headers {{ get; }} =
            new global::System.Collections.Generic.Dictionary<string, string>(global::System.StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Additional query parameters appended to every request.
        /// Request-level entries with the same key are appended after client defaults.
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string> QueryParameters {{ get; }} =
            new global::System.Collections.Generic.Dictionary<string, string>(global::System.StringComparer.Ordinal);

        /// <summary>
        /// Optional timeout applied to the full request execution.
        /// </summary>
        public global::System.TimeSpan? Timeout {{ get; set; }}

        /// <summary>
        /// Default retry behavior for generated HTTP requests.
        /// </summary>
        public global::{settings.Namespace}.AutoSDKRetryOptions Retry {{ get; set; }} = new global::{settings.Namespace}.AutoSDKRetryOptions();

        /// <summary>
        /// Overrides the client-wide response buffering mode when set.
        /// </summary>
        public bool? ReadResponseAsString {{ get; set; }}
    }}

    /// <summary>
    /// Per-request overrides applied on top of <see cref=""AutoSDKClientOptions""/>.
    /// </summary>
    public sealed class AutoSDKRequestOptions
    {{
        /// <summary>
        /// Additional headers applied after generated and client-level headers.
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string> Headers {{ get; }} =
            new global::System.Collections.Generic.Dictionary<string, string>(global::System.StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Additional query parameters appended after generated and client-level query parameters.
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string> QueryParameters {{ get; }} =
            new global::System.Collections.Generic.Dictionary<string, string>(global::System.StringComparer.Ordinal);

        /// <summary>
        /// Optional timeout override for this request.
        /// </summary>
        public global::System.TimeSpan? Timeout {{ get; set; }}

        /// <summary>
        /// Optional retry override for this request.
        /// </summary>
        public global::{settings.Namespace}.AutoSDKRetryOptions? Retry {{ get; set; }}

        /// <summary>
        /// Overrides response buffering for this request when set.
        /// </summary>
        public bool? ReadResponseAsString {{ get; set; }}
    }}

    /// <summary>
    /// Retry settings for generated HTTP requests.
    /// </summary>
    public sealed class AutoSDKRetryOptions
    {{
        /// <summary>
        /// Total number of attempts, including the initial request.
        /// Values less than 1 are normalized to 1.
        /// </summary>
        public int MaxAttempts {{ get; set; }} = 1;

        /// <summary>
        /// Optional fixed delay between retry attempts.
        /// </summary>
        public global::System.TimeSpan? Delay {{ get; set; }}
    }}

    internal static class AutoSDKRequestOptionsSupport
    {{
        internal static bool GetReadResponseAsString(
            global::{settings.Namespace}.AutoSDKClientOptions clientOptions,
            global::{settings.Namespace}.AutoSDKRequestOptions? requestOptions,
            bool fallbackValue)
        {{
            return requestOptions?.ReadResponseAsString ??
                   clientOptions.ReadResponseAsString ??
                   fallbackValue;
        }}

        internal static global::System.Threading.CancellationTokenSource? CreateTimeoutCancellationTokenSource(
            global::{settings.Namespace}.AutoSDKClientOptions clientOptions,
            global::{settings.Namespace}.AutoSDKRequestOptions? requestOptions,
            global::System.Threading.CancellationToken cancellationToken)
        {{
            var timeout = requestOptions?.Timeout ?? clientOptions.Timeout;
            if (!timeout.HasValue || timeout.Value <= global::System.TimeSpan.Zero)
            {{
                return null;
            }}

            var cancellationTokenSource = global::System.Threading.CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            cancellationTokenSource.CancelAfter(timeout.Value);
            return cancellationTokenSource;
        }}

        internal static int GetMaxAttempts(
            global::{settings.Namespace}.AutoSDKClientOptions clientOptions,
            global::{settings.Namespace}.AutoSDKRequestOptions? requestOptions,
            bool supportsRetry)
        {{
            if (!supportsRetry)
            {{
                return 1;
            }}

            var maxAttempts = requestOptions?.Retry?.MaxAttempts ??
                              clientOptions.Retry?.MaxAttempts ??
                              1;
            return maxAttempts < 1 ? 1 : maxAttempts;
        }}

        internal static async global::System.Threading.Tasks.Task DelayBeforeRetryAsync(
            global::{settings.Namespace}.AutoSDKClientOptions clientOptions,
            global::{settings.Namespace}.AutoSDKRequestOptions? requestOptions,
            global::System.Threading.CancellationToken cancellationToken)
        {{
            var delay = requestOptions?.Retry?.Delay ??
                        clientOptions.Retry?.Delay;
            if (!delay.HasValue || delay.Value <= global::System.TimeSpan.Zero)
            {{
                return;
            }}

            await global::System.Threading.Tasks.Task.Delay(delay.Value, cancellationToken).ConfigureAwait(false);
        }}

        internal static bool ShouldRetryStatusCode(
            global::System.Net.HttpStatusCode statusCode)
        {{
            return (int)statusCode switch
            {{
                408 => true,
                429 => true,
                500 => true,
                502 => true,
                503 => true,
                504 => true,
                _ => false,
            }};
        }}

        internal static string AppendQueryParameters(
            string path,
            global::System.Collections.Generic.Dictionary<string, string> clientParameters,
            global::System.Collections.Generic.Dictionary<string, string>? requestParameters)
        {{
            var hasClientParameters = clientParameters != null && clientParameters.Count > 0;
            var hasRequestParameters = requestParameters != null && requestParameters.Count > 0;
            if (!hasClientParameters && !hasRequestParameters)
            {{
                return path;
            }}

            var builder = new global::System.Text.StringBuilder(path ?? string.Empty);
            var hasQuery = builder.ToString().Contains(""?"", global::System.StringComparison.Ordinal);
            AppendParameters(builder, clientParameters, ref hasQuery);
            AppendParameters(builder, requestParameters, ref hasQuery);
            return builder.ToString();
        }}

        internal static void ApplyHeaders(
            global::System.Net.Http.HttpRequestMessage request,
            global::System.Collections.Generic.Dictionary<string, string> clientHeaders,
            global::System.Collections.Generic.Dictionary<string, string>? requestHeaders)
        {{
            ApplyHeadersCore(request, clientHeaders);
            ApplyHeadersCore(request, requestHeaders);
        }}

        private static void AppendParameters(
            global::System.Text.StringBuilder builder,
            global::System.Collections.Generic.Dictionary<string, string>? parameters,
            ref bool hasQuery)
        {{
            if (parameters == null || parameters.Count == 0)
            {{
                return;
            }}

            foreach (var parameter in parameters)
            {{
                builder.Append(hasQuery ? '&' : '?');
                builder.Append(global::System.Uri.EscapeDataString(parameter.Key));
                builder.Append('=');
                builder.Append(global::System.Uri.EscapeDataString(parameter.Value ?? string.Empty));
                hasQuery = true;
            }}
        }}

        private static void ApplyHeadersCore(
            global::System.Net.Http.HttpRequestMessage request,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {{
            if (headers == null || headers.Count == 0)
            {{
                return;
            }}

            foreach (var header in headers)
            {{
                request.Headers.Remove(header.Key);
                request.Content?.Headers.Remove(header.Key);

                if (!request.Headers.TryAddWithoutValidation(header.Key, header.Value ?? string.Empty) &&
                    request.Content != null)
                {{
                    request.Content.Headers.TryAddWithoutValidation(header.Key, header.Value ?? string.Empty);
                }}
            }}
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
