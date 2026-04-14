using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateOptionsSupport(
        CSharpSettings settings,
        bool includePollingSupport = false,
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

        /// <summary>
        /// Reusable hooks invoked for every generated SDK request.
        /// </summary>
        public global::System.Collections.Generic.List<global::{settings.Namespace}.IAutoSDKHook> Hooks {{ get; }} =
            new global::System.Collections.Generic.List<global::{settings.Namespace}.IAutoSDKHook>();

        /// <summary>
        /// Registers a hook for all requests issued by this client.
        /// </summary>
        /// <param name=""hook""></param>
        /// <returns>The current options instance.</returns>
        public global::{settings.Namespace}.AutoSDKClientOptions AddHook(
            global::{settings.Namespace}.IAutoSDKHook hook)
        {{
            Hooks.Add(hook ?? throw new global::System.ArgumentNullException(nameof(hook)));
            return this;
        }}
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

        internal global::System.Uri? AbsoluteRequestUriOverride {{ get; set; }}
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

{(includePollingSupport ? GeneratePollingOptionsSurface(settings) : TrimmedLine)}

    /// <summary>
    /// Runtime hook interface for generated SDK lifecycle events.
    /// </summary>
    public interface IAutoSDKHook
    {{
        /// <summary>
        /// Runs before a request is sent.
        /// </summary>
        /// <param name=""context""></param>
        global::System.Threading.Tasks.Task OnBeforeRequestAsync(
            global::{settings.Namespace}.AutoSDKHookContext context);

        /// <summary>
        /// Runs after a successful HTTP response is received.
        /// </summary>
        /// <param name=""context""></param>
        global::System.Threading.Tasks.Task OnAfterSuccessAsync(
            global::{settings.Namespace}.AutoSDKHookContext context);

        /// <summary>
        /// Runs after an error response or transport failure is observed.
        /// </summary>
        /// <param name=""context""></param>
        global::System.Threading.Tasks.Task OnAfterErrorAsync(
            global::{settings.Namespace}.AutoSDKHookContext context);
    }}

    /// <summary>
    /// Convenience base type for request hooks with no-op defaults.
    /// </summary>
    public abstract class AutoSDKHook : global::{settings.Namespace}.IAutoSDKHook
    {{
        /// <inheritdoc />
        public virtual global::System.Threading.Tasks.Task OnBeforeRequestAsync(
            global::{settings.Namespace}.AutoSDKHookContext context)
        {{
            return global::System.Threading.Tasks.Task.CompletedTask;
        }}

        /// <inheritdoc />
        public virtual global::System.Threading.Tasks.Task OnAfterSuccessAsync(
            global::{settings.Namespace}.AutoSDKHookContext context)
        {{
            return global::System.Threading.Tasks.Task.CompletedTask;
        }}

        /// <inheritdoc />
        public virtual global::System.Threading.Tasks.Task OnAfterErrorAsync(
            global::{settings.Namespace}.AutoSDKHookContext context)
        {{
            return global::System.Threading.Tasks.Task.CompletedTask;
        }}
    }}

    /// <summary>
    /// Runtime metadata passed to generated SDK hooks.
    /// </summary>
    public sealed class AutoSDKHookContext
    {{
        /// <summary>
        /// The source OpenAPI operation id or generated fallback id.
        /// </summary>
        public string OperationId {{ get; set; }} = string.Empty;

        /// <summary>
        /// The generated C# method name.
        /// </summary>
        public string MethodName {{ get; set; }} = string.Empty;

        /// <summary>
        /// The OpenAPI path template for the operation.
        /// </summary>
        public string PathTemplate {{ get; set; }} = string.Empty;

        /// <summary>
        /// The HTTP method used for the request.
        /// </summary>
        public string HttpMethod {{ get; set; }} = string.Empty;

        /// <summary>
        /// The client's resolved base URI.
        /// </summary>
        public global::System.Uri? BaseUri {{ get; set; }}

        /// <summary>
        /// The outgoing HTTP request for the current attempt.
        /// </summary>
        public global::System.Net.Http.HttpRequestMessage Request {{ get; set; }} = null!;

        /// <summary>
        /// The HTTP response when one was received.
        /// </summary>
        public global::System.Net.Http.HttpResponseMessage? Response {{ get; set; }}

        /// <summary>
        /// The transport or processing exception when one was observed.
        /// </summary>
        public global::System.Exception? Exception {{ get; set; }}

        /// <summary>
        /// The client-wide runtime options.
        /// </summary>
        public global::{settings.Namespace}.AutoSDKClientOptions ClientOptions {{ get; set; }} = null!;

        /// <summary>
        /// The per-request runtime options.
        /// </summary>
        public global::{settings.Namespace}.AutoSDKRequestOptions? RequestOptions {{ get; set; }}

        /// <summary>
        /// The current attempt number, starting at 1.
        /// </summary>
        public int Attempt {{ get; set; }}

        /// <summary>
        /// The total number of attempts allowed for this request.
        /// </summary>
        public int MaxAttempts {{ get; set; }}

        /// <summary>
        /// Indicates whether the generated client will retry after this hook invocation.
        /// </summary>
        public bool WillRetry {{ get; set; }}

        /// <summary>
        /// The effective cancellation token for the current request attempt.
        /// </summary>
        public global::System.Threading.CancellationToken CancellationToken {{ get; set; }}
    }}

{GenerateObjectPathRuntimeSupport(settings)}
{(includePollingSupport ? GeneratePollingRuntimeSupport(settings) : TrimmedLine)}

    internal static class AutoSDKRequestOptionsSupport
    {{
        internal static global::{settings.Namespace}.AutoSDKHookContext CreateHookContext(
            string operationId,
            string methodName,
            string pathTemplate,
            string httpMethod,
            global::System.Uri? baseUri,
            global::System.Net.Http.HttpRequestMessage request,
            global::System.Net.Http.HttpResponseMessage? response,
            global::System.Exception? exception,
            global::{settings.Namespace}.AutoSDKClientOptions clientOptions,
            global::{settings.Namespace}.AutoSDKRequestOptions? requestOptions,
            int attempt,
            int maxAttempts,
            bool willRetry,
            global::System.Threading.CancellationToken cancellationToken)
        {{
            return new global::{settings.Namespace}.AutoSDKHookContext
            {{
                OperationId = operationId ?? string.Empty,
                MethodName = methodName ?? string.Empty,
                PathTemplate = pathTemplate ?? string.Empty,
                HttpMethod = httpMethod ?? string.Empty,
                BaseUri = baseUri,
                Request = request,
                Response = response,
                Exception = exception,
                ClientOptions = clientOptions,
                RequestOptions = requestOptions,
                Attempt = attempt,
                MaxAttempts = maxAttempts,
                WillRetry = willRetry,
                CancellationToken = cancellationToken,
            }};
        }}

        internal static global::System.Threading.Tasks.Task OnBeforeRequestAsync(
            global::{settings.Namespace}.AutoSDKClientOptions clientOptions,
            global::{settings.Namespace}.AutoSDKHookContext context)
        {{
            return InvokeHooksAsync(clientOptions, static (hook, hookContext) => hook.OnBeforeRequestAsync(hookContext), context);
        }}

        internal static global::System.Threading.Tasks.Task OnAfterSuccessAsync(
            global::{settings.Namespace}.AutoSDKClientOptions clientOptions,
            global::{settings.Namespace}.AutoSDKHookContext context)
        {{
            return InvokeHooksAsync(clientOptions, static (hook, hookContext) => hook.OnAfterSuccessAsync(hookContext), context);
        }}

        internal static global::System.Threading.Tasks.Task OnAfterErrorAsync(
            global::{settings.Namespace}.AutoSDKClientOptions clientOptions,
            global::{settings.Namespace}.AutoSDKHookContext context)
        {{
            return InvokeHooksAsync(clientOptions, static (hook, hookContext) => hook.OnAfterErrorAsync(hookContext), context);
        }}

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

        internal static global::{settings.Namespace}.AutoSDKRequestOptions CloneRequestOptions(
            global::{settings.Namespace}.AutoSDKRequestOptions? requestOptions)
        {{
            var clone = new global::{settings.Namespace}.AutoSDKRequestOptions
            {{
                Timeout = requestOptions?.Timeout,
                ReadResponseAsString = requestOptions?.ReadResponseAsString,
                AbsoluteRequestUriOverride = requestOptions?.AbsoluteRequestUriOverride,
                Retry = requestOptions?.Retry == null
                    ? null
                    : new global::{settings.Namespace}.AutoSDKRetryOptions
                    {{
                        MaxAttempts = requestOptions.Retry.MaxAttempts,
                        Delay = requestOptions.Retry.Delay,
                    }},
            }};

            if (requestOptions == null)
            {{
                return clone;
            }}

            foreach (var header in requestOptions.Headers)
            {{
                clone.Headers[header.Key] = header.Value;
            }}

            foreach (var parameter in requestOptions.QueryParameters)
            {{
                clone.QueryParameters[parameter.Key] = parameter.Value;
            }}

            return clone;
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

        private static async global::System.Threading.Tasks.Task InvokeHooksAsync(
            global::{settings.Namespace}.AutoSDKClientOptions clientOptions,
            global::System.Func<global::{settings.Namespace}.IAutoSDKHook, global::{settings.Namespace}.AutoSDKHookContext, global::System.Threading.Tasks.Task> callback,
            global::{settings.Namespace}.AutoSDKHookContext context)
        {{
            if (clientOptions.Hooks == null || clientOptions.Hooks.Count == 0)
            {{
                return;
            }}

            foreach (var hook in clientOptions.Hooks)
            {{
                if (hook == null)
                {{
                    continue;
                }}

                await callback(hook, context).ConfigureAwait(false);
            }}
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    private static string GenerateObjectPathRuntimeSupport(CSharpSettings settings)
    {
        return $@"
    internal static class AutoSDKObjectPathSupport
    {{
        internal static bool TryResolveValue(
            object? source,
            string path,
            out object? value)
        {{
            value = source;
            if (source == null)
            {{
                return string.IsNullOrWhiteSpace(path);
            }}

            if (string.IsNullOrWhiteSpace(path))
            {{
                return true;
            }}

            foreach (var rawSegment in path.Split(new[] {{ '/' }}, global::System.StringSplitOptions.RemoveEmptyEntries))
            {{
                var segment = rawSegment.Replace(""~1"", ""/"").Replace(""~0"", ""~"");
                if (!TryGetSegmentValue(value, segment, out value))
                {{
                    return false;
                }}
            }}

            return true;
        }}

        internal static string? ConvertValueToString(object? value)
        {{
            if (value == null)
            {{
                return ""null"";
            }}

            if (value is string stringValue)
            {{
                return stringValue;
            }}

            if (TryGetWireValue(value, out var wireValue))
            {{
                return wireValue;
            }}

            if (value is bool booleanValue)
            {{
                return booleanValue ? ""true"" : ""false"";
            }}

            if (value is global::System.IFormattable formattable)
            {{
                return formattable.ToString(null, global::System.Globalization.CultureInfo.InvariantCulture);
            }}

            return value.ToString();
        }}

        private static bool TryGetSegmentValue(
            object? current,
            string segment,
            out object? value)
        {{
            value = null;
            if (current == null)
            {{
                return false;
            }}

            if (current is global::System.Collections.IDictionary dictionary)
            {{
                foreach (global::System.Collections.DictionaryEntry entry in dictionary)
                {{
                    if (entry.Key is string key &&
                        string.Equals(key, segment, global::System.StringComparison.OrdinalIgnoreCase))
                    {{
                        value = entry.Value;
                        return true;
                    }}
                }}
            }}

            if (current is global::System.Collections.IList list)
            {{
                if (segment == ""[-1]"")
                {{
                    if (list.Count == 0)
                    {{
                        return false;
                    }}

                    value = list[list.Count - 1];
                    return true;
                }}

                if (int.TryParse(segment, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out var index) &&
                    index >= 0 &&
                    index < list.Count)
                {{
                    value = list[index];
                    return true;
                }}
            }}

            var property = FindMatchingProperty(current.GetType(), segment);
            if (property == null)
            {{
                return false;
            }}

            value = property.GetValue(current, null);
            return true;
        }}

        private static global::System.Reflection.PropertyInfo? FindMatchingProperty(
            global::System.Type type,
            string segment)
        {{
            var properties = type.GetProperties(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public);
            foreach (var property in properties)
            {{
                if (property.GetIndexParameters().Length != 0)
                {{
                    continue;
                }}

                if (string.Equals(property.Name, segment, global::System.StringComparison.OrdinalIgnoreCase) ||
                    TryMatchesJsonPropertyName(property, segment))
                {{
                    return property;
                }}
            }}

            return null;
        }}

        private static bool TryMatchesJsonPropertyName(
            global::System.Reflection.PropertyInfo property,
            string segment)
        {{
            foreach (var attribute in property.GetCustomAttributes(inherit: true))
            {{
                var attributeType = attribute.GetType();
                if (!string.Equals(attributeType.FullName, ""System.Text.Json.Serialization.JsonPropertyNameAttribute"", global::System.StringComparison.Ordinal) &&
                    !string.Equals(attributeType.FullName, ""Newtonsoft.Json.JsonPropertyAttribute"", global::System.StringComparison.Ordinal))
                {{
                    continue;
                }}

                var propertyNameProperty = attributeType.GetProperty(""Name"") ??
                                           attributeType.GetProperty(""PropertyName"");
                if (propertyNameProperty?.GetValue(attribute, null) is string propertyName &&
                    string.Equals(propertyName, segment, global::System.StringComparison.OrdinalIgnoreCase))
                {{
                    return true;
                }}
            }}

            return false;
        }}

        private static bool TryGetWireValue(object value, out string? wireValue)
        {{
            wireValue = null;
            var type = value.GetType();

            var valueProperty = type.GetProperty(""Value"", global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public);
            if (valueProperty?.PropertyType == typeof(string))
            {{
                wireValue = valueProperty.GetValue(value, null) as string;
                return wireValue != null;
            }}

            if (!type.IsEnum)
            {{
                return false;
            }}

            var extensionTypeName = string.IsNullOrWhiteSpace(type.Namespace)
                ? type.Name + ""Extensions""
                : type.Namespace + ""."" + type.Name + ""Extensions"";
            var extensionType = type.Assembly.GetType(extensionTypeName, throwOnError: false, ignoreCase: false);
            var method = extensionType?.GetMethod(
                ""ToValueString"",
                global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.Static,
                binder: null,
                types: new[] {{ type }},
                modifiers: null);
            if (method?.ReturnType != typeof(string))
            {{
                return false;
            }}

            wireValue = method.Invoke(null, new[] {{ value }}) as string;
            return wireValue != null;
        }}
    }}";
    }

    private static string GeneratePollingOptionsSurface(CSharpSettings settings)
    {
        return $@"
    /// <summary>
    /// Optional overrides for generated polling helper methods.
    /// </summary>
    public sealed class AutoSDKPollingOptions
    {{
        /// <summary>
        /// Optional delay before the first poll attempt.
        /// </summary>
        public global::System.TimeSpan? InitialDelay {{ get; set; }}

        /// <summary>
        /// Optional delay between poll attempts.
        /// </summary>
        public global::System.TimeSpan? Interval {{ get; set; }}

        /// <summary>
        /// Optional maximum number of poll attempts.
        /// </summary>
        public int? MaxAttempts {{ get; set; }}
    }}

    /// <summary>
    /// Raised when a generated polling helper matches a failure criterion or exhausts its attempts.
    /// </summary>
    public sealed class AutoSDKPollingException : global::System.Exception
    {{
        /// <summary>
        /// Initializes a new instance of the <see cref=""AutoSDKPollingException""/> class.
        /// </summary>
        public AutoSDKPollingException(
            string message,
            global::{settings.Namespace}.AutoSDKHttpResponse? response = null,
            global::System.Exception? innerException = null)
            : base(message, innerException)
        {{
            Response = response;
        }}

        /// <summary>
        /// Gets the last successful HTTP response observed by the polling helper.
        /// </summary>
        public global::{settings.Namespace}.AutoSDKHttpResponse? Response {{ get; }}
    }}";
    }

    private static string GeneratePollingRuntimeSupport(CSharpSettings settings)
    {
        return $@"
    internal readonly struct AutoSDKResolvedPollingOptions
    {{
        public AutoSDKResolvedPollingOptions(
            global::System.TimeSpan initialDelay,
            global::System.TimeSpan interval,
            int maxAttempts)
        {{
            InitialDelay = initialDelay;
            Interval = interval;
            MaxAttempts = maxAttempts < 1 ? 1 : maxAttempts;
        }}

        public global::System.TimeSpan InitialDelay {{ get; }}

        public global::System.TimeSpan Interval {{ get; }}

        public int MaxAttempts {{ get; }}
    }}

    internal static class AutoSDKPollingSupport
    {{
        internal static global::{settings.Namespace}.AutoSDKResolvedPollingOptions ResolvePollingOptions(
            global::{settings.Namespace}.AutoSDKPollingOptions? pollingOptions,
            global::System.TimeSpan defaultInitialDelay,
            global::System.TimeSpan defaultInterval,
            int defaultMaxAttempts)
        {{
            var initialDelay = pollingOptions?.InitialDelay ?? defaultInitialDelay;
            if (initialDelay < global::System.TimeSpan.Zero)
            {{
                initialDelay = global::System.TimeSpan.Zero;
            }}

            var interval = pollingOptions?.Interval ?? defaultInterval;
            if (interval < global::System.TimeSpan.Zero)
            {{
                interval = global::System.TimeSpan.Zero;
            }}

            var maxAttempts = pollingOptions?.MaxAttempts ?? defaultMaxAttempts;
            if (maxAttempts < 1)
            {{
                maxAttempts = 1;
            }}

            return new global::{settings.Namespace}.AutoSDKResolvedPollingOptions(
                initialDelay: initialDelay,
                interval: interval,
                maxAttempts: maxAttempts);
        }}

        internal static global::System.Threading.Tasks.Task DelayAsync(
            global::System.TimeSpan delay,
            global::System.Threading.CancellationToken cancellationToken)
        {{
            return delay <= global::System.TimeSpan.Zero
                ? global::System.Threading.Tasks.Task.CompletedTask
                : global::System.Threading.Tasks.Task.Delay(delay, cancellationToken);
        }}

        internal static string GetStatusCodeValue(global::System.Net.HttpStatusCode statusCode)
        {{
            return ((int)statusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture);
        }}

        internal static bool MatchesStatusCode(
            global::System.Net.HttpStatusCode statusCode,
            string @operator,
            string expectedValue)
        {{
            return CompareValues(GetStatusCodeValue(statusCode), @operator, expectedValue);
        }}

        internal static bool MatchesSimpleCondition(
            object? body,
            string jsonPointer,
            string @operator,
            string expectedValue)
        {{
            return global::{settings.Namespace}.AutoSDKObjectPathSupport.TryResolveValue(body, jsonPointer, out var resolvedValue) &&
                   CompareValues(global::{settings.Namespace}.AutoSDKObjectPathSupport.ConvertValueToString(resolvedValue), @operator, expectedValue);
        }}

        internal static bool MatchesRegexCondition(
            object? body,
            string jsonPointer,
            string pattern)
        {{
            return global::{settings.Namespace}.AutoSDKObjectPathSupport.TryResolveValue(body, jsonPointer, out var resolvedValue) &&
                   MatchesRegexValue(global::{settings.Namespace}.AutoSDKObjectPathSupport.ConvertValueToString(resolvedValue), pattern);
        }}

        internal static bool MatchesRegexValue(
            string? value,
            string pattern)
        {{
            if (value == null || string.IsNullOrWhiteSpace(pattern))
            {{
                return false;
            }}

            try
            {{
                return global::System.Text.RegularExpressions.Regex.IsMatch(value, pattern);
            }}
            catch (global::System.ArgumentException)
            {{
                return false;
            }}
        }}

        private static bool CompareValues(
            string? actualValue,
            string @operator,
            string expectedValue)
        {{
            var normalizedActual = actualValue ?? ""null"";
            return @operator switch
            {{
                ""=="" => string.Equals(normalizedActual, expectedValue ?? string.Empty, global::System.StringComparison.Ordinal),
                ""!="" => !string.Equals(normalizedActual, expectedValue ?? string.Empty, global::System.StringComparison.Ordinal),
                _ => false,
            }};
        }}
    }}";
    }
}
