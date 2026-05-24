using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateExceptions(CSharpSettings settings)
    {
        if (!settings.GenerateExceptions)
        {
            return string.Empty;
        }

        var hierarchy = settings.GenerateHttpExceptionHierarchy
            ? GenerateHttpExceptionHierarchy(settings)
            : TrimmedLine;

        var factoryBody = settings.GenerateHttpExceptionHierarchy
            ? $@"            switch ((int)statusCode)
            {{
                case 401: return new global::{settings.Namespace}.AuthenticationException(message, innerException);
                case 402: return new global::{settings.Namespace}.PaymentRequiredException(message, innerException);
                case 403: return new global::{settings.Namespace}.AuthorizationException(message, innerException);
                case 404: return new global::{settings.Namespace}.NotFoundException(message, innerException);
                case 408: return new global::{settings.Namespace}.RequestTimeoutException(message, innerException);
                case 409: return new global::{settings.Namespace}.ConflictException(message, innerException);
                case 422: return new global::{settings.Namespace}.ValidationException(message, innerException);
                case 429:
                {{
                    var retryAfter = global::{settings.Namespace}.ApiException.TryParseRetryAfter(responseHeaders);
                    return new global::{settings.Namespace}.RateLimitException(message, innerException) {{ RetryAfter = retryAfter }};
                }}
            }}

            if ((int)statusCode >= 500 && (int)statusCode <= 599)
            {{
                return new global::{settings.Namespace}.ServerException(message, innerException, statusCode);
            }}

            return new global::{settings.Namespace}.ApiException(message, innerException, statusCode);"
            : $@"            return new global::{settings.Namespace}.ApiException(message, innerException, statusCode);";

        var typedFactoryBody = settings.GenerateHttpExceptionHierarchy
            ? $@"            switch ((int)statusCode)
            {{
                case 401: return new global::{settings.Namespace}.AuthenticationException<T>(message, innerException);
                case 402: return new global::{settings.Namespace}.PaymentRequiredException<T>(message, innerException);
                case 403: return new global::{settings.Namespace}.AuthorizationException<T>(message, innerException);
                case 404: return new global::{settings.Namespace}.NotFoundException<T>(message, innerException);
                case 408: return new global::{settings.Namespace}.RequestTimeoutException<T>(message, innerException);
                case 409: return new global::{settings.Namespace}.ConflictException<T>(message, innerException);
                case 422: return new global::{settings.Namespace}.ValidationException<T>(message, innerException);
                case 429:
                {{
                    var retryAfter = global::{settings.Namespace}.ApiException.TryParseRetryAfter(responseHeaders);
                    return new global::{settings.Namespace}.RateLimitException<T>(message, innerException) {{ RetryAfter = retryAfter }};
                }}
            }}

            if ((int)statusCode >= 500 && (int)statusCode <= 599)
            {{
                return new global::{settings.Namespace}.ServerException<T>(message, innerException, statusCode);
            }}

            return new global::{settings.Namespace}.ApiException<T>(message, innerException, statusCode);"
            : $@"            return new global::{settings.Namespace}.ApiException<T>(message, innerException, statusCode);";

        return $@"#nullable enable

namespace {settings.Namespace}
{{
    /// <summary>
    /// Represents an exception thrown by the API.
    /// </summary>
    [global::System.Serializable]
    public partial class ApiException : global::System.Exception
    {{
        /// <summary>
        /// The HTTP status code of the response.
        /// </summary>
        public global::System.Net.HttpStatusCode StatusCode {{ get; }}

        /// <summary>
        /// The response body as a string, or <c>null</c> if the body could not be read.
        /// This is always populated for error responses regardless of the <c>ReadResponseAsString</c> setting.
        /// For success-path failures (e.g. deserialization errors), the client attempts a best-effort read.
        /// </summary>
        public string? ResponseBody {{ get; set; }}

        /// <summary>
        /// The response headers.
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IEnumerable<string>>? ResponseHeaders {{ get; set; }}

        /// <summary>
        /// Initializes a new instance of the <see cref=""ApiException""/> class.
        /// </summary>
        public ApiException()
        {{
        }}

        /// <summary>
        /// Initializes a new instance of the <see cref=""ApiException""/> class with a specified error message.
        /// </summary>
        /// <param name=""message"">The message that describes the error.</param>
        /// <param name=""statusCode"">The HTTP status code of the response.</param>
        public ApiException(string message, global::System.Net.HttpStatusCode statusCode) : base(message)
        {{
            StatusCode = statusCode;
        }}

        /// <summary>
        /// Initializes a new instance of the <see cref=""ApiException""/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name=""message"">The error message that explains the reason for the exception.</param>
        /// <param name=""innerException"">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        /// <param name=""statusCode"">The HTTP status code of the response.</param>
        public ApiException(string message, global::System.Exception? innerException, global::System.Net.HttpStatusCode statusCode) : base(message, innerException)
        {{
            StatusCode = statusCode;
        }}

        /// <summary>
        /// Constructs an <see cref=""ApiException""/> instance whose runtime type matches the response status code when the typed exception hierarchy is enabled. Always returns a plain <see cref=""ApiException""/> when the hierarchy is disabled.
        /// </summary>
        /// <param name=""statusCode"">The HTTP status code of the response.</param>
        /// <param name=""message"">The error message.</param>
        /// <param name=""innerException"">An inner exception, when one is available.</param>
        /// <param name=""responseHeaders"">The response headers; consulted for 429 <c>Retry-After</c> parsing when present.</param>
        public static global::{settings.Namespace}.ApiException Create(
            global::System.Net.HttpStatusCode statusCode,
            string message,
            global::System.Exception? innerException = null,
            global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IEnumerable<string>>? responseHeaders = null)
        {{
{factoryBody}
        }}

        /// <summary>
        /// Convenience overload that constructs an <see cref=""ApiException""/> with response body and headers populated.
        /// </summary>
        public static global::{settings.Namespace}.ApiException Create(
            global::System.Net.HttpStatusCode statusCode,
            string message,
            global::System.Exception? innerException,
            string? responseBody,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IEnumerable<string>>? responseHeaders)
        {{
            var exception = global::{settings.Namespace}.ApiException.Create(statusCode, message, innerException, responseHeaders);
            exception.ResponseBody = responseBody;
            exception.ResponseHeaders = responseHeaders;
            return exception;
        }}

        /// <summary>
        /// Parses a <c>Retry-After</c> response header (delta-seconds or HTTP-date) into a <see cref=""global::System.TimeSpan""/>.
        /// Returns <c>null</c> when the header is missing or unparseable. Public so consumer code that observes
        /// <see cref=""ApiException""/> directly can recover the value without re-implementing the parser.
        /// </summary>
        public static global::System.TimeSpan? TryParseRetryAfter(
            global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IEnumerable<string>>? headers)
        {{
            if (headers == null)
            {{
                return null;
            }}

            global::System.Collections.Generic.IEnumerable<string>? values = null;
            foreach (var entry in headers)
            {{
                if (string.Equals(entry.Key, ""Retry-After"", global::System.StringComparison.OrdinalIgnoreCase))
                {{
                    values = entry.Value;
                    break;
                }}
            }}

            if (values == null)
            {{
                return null;
            }}

            string? raw = null;
            foreach (var value in values)
            {{
                if (!string.IsNullOrWhiteSpace(value))
                {{
                    raw = value.Trim();
                    break;
                }}
            }}

            if (string.IsNullOrEmpty(raw))
            {{
                return null;
            }}

            if (int.TryParse(
                raw,
                global::System.Globalization.NumberStyles.Integer,
                global::System.Globalization.CultureInfo.InvariantCulture,
                out var seconds) && seconds >= 0)
            {{
                return global::System.TimeSpan.FromSeconds(seconds);
            }}

            if (global::System.DateTimeOffset.TryParse(
                raw,
                global::System.Globalization.CultureInfo.InvariantCulture,
                global::System.Globalization.DateTimeStyles.AssumeUniversal | global::System.Globalization.DateTimeStyles.AdjustToUniversal,
                out var when))
            {{
                var delta = when - global::System.DateTimeOffset.UtcNow;
                return delta > global::System.TimeSpan.Zero ? delta : global::System.TimeSpan.Zero;
            }}

            return null;
        }}
    }}

    /// <summary>
    /// Represents an exception thrown by the API.
    /// </summary>
    /// <typeparam name=""T""></typeparam>
    [global::System.Serializable]
    public partial class ApiException<T> : ApiException
    {{
        /// <summary>
        /// The response object.
        /// </summary>
        public T? ResponseObject {{ get; set; }}

        /// <summary>
        /// Initializes a new instance of the <see cref=""ApiException""/> class.
        /// </summary>
        public ApiException()
        {{
        }}

        /// <summary>
        /// Initializes a new instance of the <see cref=""ApiException""/> class with a specified error message.
        /// </summary>
        /// <param name=""message"">The message that describes the error.</param>
        /// <param name=""statusCode"">The HTTP status code of the response.</param>
        public ApiException(string message, global::System.Net.HttpStatusCode statusCode) : base(message, statusCode)
        {{
        }}

        /// <summary>
        /// Initializes a new instance of the <see cref=""ApiException""/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name=""message"">The error message that explains the reason for the exception.</param>
        /// <param name=""innerException"">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        /// <param name=""statusCode"">The HTTP status code of the response.</param>
        public ApiException(string message, global::System.Exception? innerException, global::System.Net.HttpStatusCode statusCode) : base(message, innerException, statusCode)
        {{
        }}

        /// <summary>
        /// Constructs an <see cref=""ApiException{{T}}""/> whose runtime type matches the response status code when the typed exception hierarchy is enabled.
        /// </summary>
        /// <param name=""statusCode"">The HTTP status code of the response.</param>
        /// <param name=""message"">The error message.</param>
        /// <param name=""innerException"">An inner exception, when one is available.</param>
        /// <param name=""responseHeaders"">The response headers; consulted for 429 <c>Retry-After</c> parsing when present.</param>
        public static new global::{settings.Namespace}.ApiException<T> Create(
            global::System.Net.HttpStatusCode statusCode,
            string message,
            global::System.Exception? innerException = null,
            global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IEnumerable<string>>? responseHeaders = null)
        {{
{typedFactoryBody}
        }}

        /// <summary>
        /// Convenience overload that constructs an <see cref=""ApiException{{T}}""/> with response body, object, and headers populated.
        /// </summary>
        public static global::{settings.Namespace}.ApiException<T> Create(
            global::System.Net.HttpStatusCode statusCode,
            string message,
            global::System.Exception? innerException,
            string? responseBody,
            T? responseObject,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IEnumerable<string>>? responseHeaders)
        {{
            var exception = global::{settings.Namespace}.ApiException<T>.Create(statusCode, message, innerException, responseHeaders);
            exception.ResponseBody = responseBody;
            exception.ResponseObject = responseObject;
            exception.ResponseHeaders = responseHeaders;
            return exception;
        }}
    }}
{hierarchy}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    private static string GenerateHttpExceptionHierarchy(CSharpSettings settings)
    {
        return $@"
    /// <summary>Thrown for HTTP 401 (Unauthorized).</summary>
    [global::System.Serializable]
    public partial class AuthenticationException : global::{settings.Namespace}.ApiException
    {{
        /// <inheritdoc />
        public AuthenticationException() : base(""Authentication failed."", global::System.Net.HttpStatusCode.Unauthorized) {{ }}
        /// <inheritdoc />
        public AuthenticationException(string message) : base(message, global::System.Net.HttpStatusCode.Unauthorized) {{ }}
        /// <inheritdoc />
        public AuthenticationException(string message, global::System.Exception? innerException) : base(message, innerException, global::System.Net.HttpStatusCode.Unauthorized) {{ }}
    }}

    /// <summary>Thrown for HTTP 401 (Unauthorized) with a typed response body.</summary>
    [global::System.Serializable]
    public partial class AuthenticationException<T> : global::{settings.Namespace}.ApiException<T>
    {{
        /// <inheritdoc />
        public AuthenticationException() : base(""Authentication failed."", global::System.Net.HttpStatusCode.Unauthorized) {{ }}
        /// <inheritdoc />
        public AuthenticationException(string message) : base(message, global::System.Net.HttpStatusCode.Unauthorized) {{ }}
        /// <inheritdoc />
        public AuthenticationException(string message, global::System.Exception? innerException) : base(message, innerException, global::System.Net.HttpStatusCode.Unauthorized) {{ }}
    }}

    /// <summary>Thrown for HTTP 402 (Payment Required).</summary>
    [global::System.Serializable]
    public partial class PaymentRequiredException : global::{settings.Namespace}.ApiException
    {{
        /// <inheritdoc />
        public PaymentRequiredException() : base(""Payment required."", global::System.Net.HttpStatusCode.PaymentRequired) {{ }}
        /// <inheritdoc />
        public PaymentRequiredException(string message) : base(message, global::System.Net.HttpStatusCode.PaymentRequired) {{ }}
        /// <inheritdoc />
        public PaymentRequiredException(string message, global::System.Exception? innerException) : base(message, innerException, global::System.Net.HttpStatusCode.PaymentRequired) {{ }}
    }}

    /// <summary>Thrown for HTTP 402 (Payment Required) with a typed response body.</summary>
    [global::System.Serializable]
    public partial class PaymentRequiredException<T> : global::{settings.Namespace}.ApiException<T>
    {{
        /// <inheritdoc />
        public PaymentRequiredException() : base(""Payment required."", global::System.Net.HttpStatusCode.PaymentRequired) {{ }}
        /// <inheritdoc />
        public PaymentRequiredException(string message) : base(message, global::System.Net.HttpStatusCode.PaymentRequired) {{ }}
        /// <inheritdoc />
        public PaymentRequiredException(string message, global::System.Exception? innerException) : base(message, innerException, global::System.Net.HttpStatusCode.PaymentRequired) {{ }}
    }}

    /// <summary>Thrown for HTTP 403 (Forbidden).</summary>
    [global::System.Serializable]
    public partial class AuthorizationException : global::{settings.Namespace}.ApiException
    {{
        /// <inheritdoc />
        public AuthorizationException() : base(""Authorization failed."", global::System.Net.HttpStatusCode.Forbidden) {{ }}
        /// <inheritdoc />
        public AuthorizationException(string message) : base(message, global::System.Net.HttpStatusCode.Forbidden) {{ }}
        /// <inheritdoc />
        public AuthorizationException(string message, global::System.Exception? innerException) : base(message, innerException, global::System.Net.HttpStatusCode.Forbidden) {{ }}
    }}

    /// <summary>Thrown for HTTP 403 (Forbidden) with a typed response body.</summary>
    [global::System.Serializable]
    public partial class AuthorizationException<T> : global::{settings.Namespace}.ApiException<T>
    {{
        /// <inheritdoc />
        public AuthorizationException() : base(""Authorization failed."", global::System.Net.HttpStatusCode.Forbidden) {{ }}
        /// <inheritdoc />
        public AuthorizationException(string message) : base(message, global::System.Net.HttpStatusCode.Forbidden) {{ }}
        /// <inheritdoc />
        public AuthorizationException(string message, global::System.Exception? innerException) : base(message, innerException, global::System.Net.HttpStatusCode.Forbidden) {{ }}
    }}

    /// <summary>Thrown for HTTP 404 (Not Found).</summary>
    [global::System.Serializable]
    public partial class NotFoundException : global::{settings.Namespace}.ApiException
    {{
        /// <inheritdoc />
        public NotFoundException() : base(""Resource not found."", global::System.Net.HttpStatusCode.NotFound) {{ }}
        /// <inheritdoc />
        public NotFoundException(string message) : base(message, global::System.Net.HttpStatusCode.NotFound) {{ }}
        /// <inheritdoc />
        public NotFoundException(string message, global::System.Exception? innerException) : base(message, innerException, global::System.Net.HttpStatusCode.NotFound) {{ }}
    }}

    /// <summary>Thrown for HTTP 404 (Not Found) with a typed response body.</summary>
    [global::System.Serializable]
    public partial class NotFoundException<T> : global::{settings.Namespace}.ApiException<T>
    {{
        /// <inheritdoc />
        public NotFoundException() : base(""Resource not found."", global::System.Net.HttpStatusCode.NotFound) {{ }}
        /// <inheritdoc />
        public NotFoundException(string message) : base(message, global::System.Net.HttpStatusCode.NotFound) {{ }}
        /// <inheritdoc />
        public NotFoundException(string message, global::System.Exception? innerException) : base(message, innerException, global::System.Net.HttpStatusCode.NotFound) {{ }}
    }}

    /// <summary>Thrown for HTTP 408 (Request Timeout).</summary>
    [global::System.Serializable]
    public partial class RequestTimeoutException : global::{settings.Namespace}.ApiException
    {{
        /// <inheritdoc />
        public RequestTimeoutException() : base(""Request timed out."", global::System.Net.HttpStatusCode.RequestTimeout) {{ }}
        /// <inheritdoc />
        public RequestTimeoutException(string message) : base(message, global::System.Net.HttpStatusCode.RequestTimeout) {{ }}
        /// <inheritdoc />
        public RequestTimeoutException(string message, global::System.Exception? innerException) : base(message, innerException, global::System.Net.HttpStatusCode.RequestTimeout) {{ }}
    }}

    /// <summary>Thrown for HTTP 408 (Request Timeout) with a typed response body.</summary>
    [global::System.Serializable]
    public partial class RequestTimeoutException<T> : global::{settings.Namespace}.ApiException<T>
    {{
        /// <inheritdoc />
        public RequestTimeoutException() : base(""Request timed out."", global::System.Net.HttpStatusCode.RequestTimeout) {{ }}
        /// <inheritdoc />
        public RequestTimeoutException(string message) : base(message, global::System.Net.HttpStatusCode.RequestTimeout) {{ }}
        /// <inheritdoc />
        public RequestTimeoutException(string message, global::System.Exception? innerException) : base(message, innerException, global::System.Net.HttpStatusCode.RequestTimeout) {{ }}
    }}

    /// <summary>Thrown for HTTP 409 (Conflict).</summary>
    [global::System.Serializable]
    public partial class ConflictException : global::{settings.Namespace}.ApiException
    {{
        /// <inheritdoc />
        public ConflictException() : base(""Conflict."", global::System.Net.HttpStatusCode.Conflict) {{ }}
        /// <inheritdoc />
        public ConflictException(string message) : base(message, global::System.Net.HttpStatusCode.Conflict) {{ }}
        /// <inheritdoc />
        public ConflictException(string message, global::System.Exception? innerException) : base(message, innerException, global::System.Net.HttpStatusCode.Conflict) {{ }}
    }}

    /// <summary>Thrown for HTTP 409 (Conflict) with a typed response body.</summary>
    [global::System.Serializable]
    public partial class ConflictException<T> : global::{settings.Namespace}.ApiException<T>
    {{
        /// <inheritdoc />
        public ConflictException() : base(""Conflict."", global::System.Net.HttpStatusCode.Conflict) {{ }}
        /// <inheritdoc />
        public ConflictException(string message) : base(message, global::System.Net.HttpStatusCode.Conflict) {{ }}
        /// <inheritdoc />
        public ConflictException(string message, global::System.Exception? innerException) : base(message, innerException, global::System.Net.HttpStatusCode.Conflict) {{ }}
    }}

    /// <summary>Thrown for HTTP 422 (Unprocessable Entity).</summary>
    [global::System.Serializable]
    public partial class ValidationException : global::{settings.Namespace}.ApiException
    {{
        /// <inheritdoc />
        public ValidationException() : base(""Validation failed."", (global::System.Net.HttpStatusCode)422) {{ }}
        /// <inheritdoc />
        public ValidationException(string message) : base(message, (global::System.Net.HttpStatusCode)422) {{ }}
        /// <inheritdoc />
        public ValidationException(string message, global::System.Exception? innerException) : base(message, innerException, (global::System.Net.HttpStatusCode)422) {{ }}
    }}

    /// <summary>Thrown for HTTP 422 (Unprocessable Entity) with a typed response body.</summary>
    [global::System.Serializable]
    public partial class ValidationException<T> : global::{settings.Namespace}.ApiException<T>
    {{
        /// <inheritdoc />
        public ValidationException() : base(""Validation failed."", (global::System.Net.HttpStatusCode)422) {{ }}
        /// <inheritdoc />
        public ValidationException(string message) : base(message, (global::System.Net.HttpStatusCode)422) {{ }}
        /// <inheritdoc />
        public ValidationException(string message, global::System.Exception? innerException) : base(message, innerException, (global::System.Net.HttpStatusCode)422) {{ }}
    }}

    /// <summary>Thrown for HTTP 429 (Too Many Requests). Exposes the parsed <c>Retry-After</c> delay.</summary>
    [global::System.Serializable]
    public partial class RateLimitException : global::{settings.Namespace}.ApiException
    {{
        /// <summary>The parsed <c>Retry-After</c> delay, if present on the response.</summary>
        public global::System.TimeSpan? RetryAfter {{ get; set; }}

        /// <inheritdoc />
        public RateLimitException() : base(""Rate limit exceeded."", (global::System.Net.HttpStatusCode)429) {{ }}
        /// <inheritdoc />
        public RateLimitException(string message) : base(message, (global::System.Net.HttpStatusCode)429) {{ }}
        /// <inheritdoc />
        public RateLimitException(string message, global::System.Exception? innerException) : base(message, innerException, (global::System.Net.HttpStatusCode)429) {{ }}
    }}

    /// <summary>Thrown for HTTP 429 (Too Many Requests) with a typed response body. Exposes the parsed <c>Retry-After</c> delay.</summary>
    [global::System.Serializable]
    public partial class RateLimitException<T> : global::{settings.Namespace}.ApiException<T>
    {{
        /// <summary>The parsed <c>Retry-After</c> delay, if present on the response.</summary>
        public global::System.TimeSpan? RetryAfter {{ get; set; }}

        /// <inheritdoc />
        public RateLimitException() : base(""Rate limit exceeded."", (global::System.Net.HttpStatusCode)429) {{ }}
        /// <inheritdoc />
        public RateLimitException(string message) : base(message, (global::System.Net.HttpStatusCode)429) {{ }}
        /// <inheritdoc />
        public RateLimitException(string message, global::System.Exception? innerException) : base(message, innerException, (global::System.Net.HttpStatusCode)429) {{ }}
    }}

    /// <summary>Thrown for HTTP 5xx (Server Error).</summary>
    [global::System.Serializable]
    public partial class ServerException : global::{settings.Namespace}.ApiException
    {{
        /// <inheritdoc />
        public ServerException() : base(""Server error."", global::System.Net.HttpStatusCode.InternalServerError) {{ }}
        /// <inheritdoc />
        public ServerException(string message, global::System.Net.HttpStatusCode statusCode) : base(message, statusCode) {{ }}
        /// <inheritdoc />
        public ServerException(string message, global::System.Exception? innerException, global::System.Net.HttpStatusCode statusCode) : base(message, innerException, statusCode) {{ }}
    }}

    /// <summary>Thrown for HTTP 5xx (Server Error) with a typed response body.</summary>
    [global::System.Serializable]
    public partial class ServerException<T> : global::{settings.Namespace}.ApiException<T>
    {{
        /// <inheritdoc />
        public ServerException() : base(""Server error."", global::System.Net.HttpStatusCode.InternalServerError) {{ }}
        /// <inheritdoc />
        public ServerException(string message, global::System.Net.HttpStatusCode statusCode) : base(message, statusCode) {{ }}
        /// <inheritdoc />
        public ServerException(string message, global::System.Exception? innerException, global::System.Net.HttpStatusCode statusCode) : base(message, innerException, statusCode) {{ }}
    }}
";
    }
}
