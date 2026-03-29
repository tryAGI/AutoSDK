//HintName: G.Models.SummarizationResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Summary of the transcript, configured using `summarization_config`.<br/>
    /// Example: {"content":"this is a summary"}
    /// </summary>
    public sealed partial class SummarizationResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizationResult" /> class.
        /// </summary>
        /// <param name="content"></param>
        public SummarizationResult(
            string? content)
        {
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizationResult" /> class.
        /// </summary>
        public SummarizationResult()
        {
        }
    }
}