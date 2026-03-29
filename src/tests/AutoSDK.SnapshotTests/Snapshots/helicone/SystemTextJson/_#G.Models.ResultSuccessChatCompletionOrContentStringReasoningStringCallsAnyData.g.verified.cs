//HintName: G.Models.ResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Calls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reasoning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData" /> class.
        /// </summary>
        /// <param name="calls"></param>
        /// <param name="reasoning"></param>
        /// <param name="content"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData(
            object calls,
            string reasoning,
            string content)
        {
            this.Calls = calls ?? throw new global::System.ArgumentNullException(nameof(calls));
            this.Reasoning = reasoning ?? throw new global::System.ArgumentNullException(nameof(reasoning));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData" /> class.
        /// </summary>
        public ResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData()
        {
        }
    }
}