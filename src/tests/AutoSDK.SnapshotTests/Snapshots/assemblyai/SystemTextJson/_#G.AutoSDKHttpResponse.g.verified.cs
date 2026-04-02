//HintName: G.AutoSDKHttpResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a successful HTTP response with status code and headers.
    /// </summary>
    public partial class AutoSDKHttpResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKHttpResponse"/> class.
        /// </summary>
        public AutoSDKHttpResponse(
            global::System.Net.HttpStatusCode statusCode,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IEnumerable<string>> headers)
        {
            StatusCode = statusCode;
            Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
        }

        /// <summary>
        /// Gets the HTTP status code.
        /// </summary>
        public global::System.Net.HttpStatusCode StatusCode { get; }
        /// <summary>
        /// Gets the response headers.
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IEnumerable<string>> Headers { get; }

        internal static global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IEnumerable<string>> CreateHeaders(
            global::System.Net.Http.HttpResponseMessage response)
        {
            response = response ?? throw new global::System.ArgumentNullException(nameof(response));

            var headers = global::System.Linq.Enumerable.ToDictionary(
                response.Headers,
                static header => header.Key,
                static header => (global::System.Collections.Generic.IEnumerable<string>)global::System.Linq.Enumerable.ToArray(header.Value),
                global::System.StringComparer.OrdinalIgnoreCase);

            if (response.Content?.Headers == null)
            {
                return headers;
            }

            foreach (var header in response.Content.Headers)
            {
                if (headers.TryGetValue(header.Key, out var existingValues))
                {
                    headers[header.Key] = global::System.Linq.Enumerable.ToArray(
                        global::System.Linq.Enumerable.Concat(existingValues, header.Value));
                }
                else
                {
                    headers[header.Key] = global::System.Linq.Enumerable.ToArray(header.Value);
                }
            }

            return headers;
        }
    }

    /// <summary>
    /// Represents a successful HTTP response with status code, headers, and body.
    /// </summary>
    public partial class AutoSDKHttpResponse<T> : AutoSDKHttpResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKHttpResponse{T}"/> class.
        /// </summary>
        public AutoSDKHttpResponse(
            global::System.Net.HttpStatusCode statusCode,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IEnumerable<string>> headers,
            T body)
            : base(statusCode, headers)
        {
            Body = body;
        }

        /// <summary>
        /// Gets the response body.
        /// </summary>
        public T Body { get; }
    }
}