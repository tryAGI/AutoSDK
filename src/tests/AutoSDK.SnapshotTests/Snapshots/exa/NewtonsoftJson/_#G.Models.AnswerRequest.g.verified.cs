//HintName: G.Models.AnswerRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnswerRequest
    {
        /// <summary>
        /// The question or query to answer.<br/>
        /// Example: What is the latest valuation of SpaceX?
        /// </summary>
        /// <example>What is the latest valuation of SpaceX?</example>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// If true, the response is returned as a server-sent events (SSS) stream.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// If true, the response includes full text content in the search results<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public bool? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// The question or query to answer.<br/>
        /// Example: What is the latest valuation of SpaceX?
        /// </param>
        /// <param name="stream">
        /// If true, the response is returned as a server-sent events (SSS) stream.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="text">
        /// If true, the response includes full text content in the search results<br/>
        /// Default Value: false
        /// </param>
        public AnswerRequest(
            string query,
            bool? stream,
            bool? text)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Stream = stream;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerRequest" /> class.
        /// </summary>
        public AnswerRequest()
        {
        }
    }
}