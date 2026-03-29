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
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional headers used to fetch the urls, e.g. authorization, agent, etc<br/>
        /// Default Value: {}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// Default Value: http
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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