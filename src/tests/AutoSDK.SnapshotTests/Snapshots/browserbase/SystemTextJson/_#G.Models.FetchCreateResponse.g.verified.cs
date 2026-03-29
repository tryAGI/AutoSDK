//HintName: G.Models.FetchCreateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FetchCreateResponse
    {
        /// <summary>
        /// Unique identifier for the fetch request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// HTTP status code of the fetched response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// Response headers as key-value pairs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// The response body content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// The MIME type of the response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// The character encoding of the response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Encoding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchCreateResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the fetch request
        /// </param>
        /// <param name="statusCode">
        /// HTTP status code of the fetched response
        /// </param>
        /// <param name="headers">
        /// Response headers as key-value pairs
        /// </param>
        /// <param name="content">
        /// The response body content
        /// </param>
        /// <param name="contentType">
        /// The MIME type of the response
        /// </param>
        /// <param name="encoding">
        /// The character encoding of the response
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FetchCreateResponse(
            string id,
            int statusCode,
            global::System.Collections.Generic.Dictionary<string, string> headers,
            string content,
            string contentType,
            string encoding)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.StatusCode = statusCode;
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.Encoding = encoding ?? throw new global::System.ArgumentNullException(nameof(encoding));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchCreateResponse" /> class.
        /// </summary>
        public FetchCreateResponse()
        {
        }
    }
}