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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// HTTP status code of the fetched response
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statusCode", Required = global::Newtonsoft.Json.Required.Always)]
        public int StatusCode { get; set; } = default!;

        /// <summary>
        /// Response headers as key-value pairs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Headers { get; set; } = default!;

        /// <summary>
        /// The response body content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// The MIME type of the response
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contentType", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContentType { get; set; } = default!;

        /// <summary>
        /// The character encoding of the response
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encoding", Required = global::Newtonsoft.Json.Required.Always)]
        public string Encoding { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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