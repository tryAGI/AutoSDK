//HintName: G.Models.PostSummarizationMessageData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostSummarizationMessageData
    {
        /// <summary>
        /// The summarization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public string Results { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostSummarizationMessageData" /> class.
        /// </summary>
        /// <param name="results">
        /// The summarization
        /// </param>
        public PostSummarizationMessageData(
            string results)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostSummarizationMessageData" /> class.
        /// </summary>
        public PostSummarizationMessageData()
        {
        }
    }
}