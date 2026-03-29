//HintName: G.Models.GenerateLLMsTxtRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateLLMsTxtRequest
    {
        /// <summary>
        /// The URL to generate LLMs.txt from
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Maximum number of URLs to analyze<br/>
        /// Default Value: 2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxUrls")]
        public int? MaxUrls { get; set; }

        /// <summary>
        /// Include full text content in the response<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("showFullText")]
        public bool? ShowFullText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateLLMsTxtRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL to generate LLMs.txt from
        /// </param>
        /// <param name="maxUrls">
        /// Maximum number of URLs to analyze<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="showFullText">
        /// Include full text content in the response<br/>
        /// Default Value: false
        /// </param>
        public GenerateLLMsTxtRequest(
            string url,
            int? maxUrls,
            bool? showFullText)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.MaxUrls = maxUrls;
            this.ShowFullText = showFullText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateLLMsTxtRequest" /> class.
        /// </summary>
        public GenerateLLMsTxtRequest()
        {
        }
    }
}