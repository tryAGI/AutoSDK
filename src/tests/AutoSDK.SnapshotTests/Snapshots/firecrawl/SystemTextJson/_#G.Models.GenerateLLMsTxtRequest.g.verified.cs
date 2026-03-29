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
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Maximum number of URLs to analyze<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxUrls")]
        public int? MaxUrls { get; set; }

        /// <summary>
        /// Include full text content in the response<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("showFullText")]
        public bool? ShowFullText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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