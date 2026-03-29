//HintName: G.Models.HttpSourceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HttpSourceRequest
    {
        /// <summary>
        /// HTTP url to process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional headers used to fetch the urls, e.g. authorization, agent, etc<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// Default Value: http
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpSourceRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// HTTP url to process
        /// </param>
        /// <param name="headers">
        /// Additional headers used to fetch the urls, e.g. authorization, agent, etc<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="kind">
        /// Default Value: http
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HttpSourceRequest(
            string url,
            object? headers,
            string? kind)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Headers = headers;
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpSourceRequest" /> class.
        /// </summary>
        public HttpSourceRequest()
        {
        }
    }
}