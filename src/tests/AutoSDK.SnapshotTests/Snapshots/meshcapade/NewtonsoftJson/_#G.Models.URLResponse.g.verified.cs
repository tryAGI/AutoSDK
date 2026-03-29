//HintName: G.Models.URLResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class URLResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("internal")]
        public bool? Internal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("method")]
        public string? Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="URLResponse" /> class.
        /// </summary>
        /// <param name="internal"></param>
        /// <param name="method"></param>
        /// <param name="path"></param>
        public URLResponse(
            bool? @internal,
            string? method,
            string? path)
        {
            this.Internal = @internal;
            this.Method = method;
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="URLResponse" /> class.
        /// </summary>
        public URLResponse()
        {
        }
    }
}