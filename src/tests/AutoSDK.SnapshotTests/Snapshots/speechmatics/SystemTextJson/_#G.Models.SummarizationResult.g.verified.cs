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
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizationResult" /> class.
        /// </summary>
        /// <param name="content"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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