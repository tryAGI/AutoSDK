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
        [global::Newtonsoft.Json.JsonProperty("calls", Required = global::Newtonsoft.Json.Required.Always)]
        public object Calls { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning", Required = global::Newtonsoft.Json.Required.Always)]
        public string Reasoning { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData" /> class.
        /// </summary>
        /// <param name="calls"></param>
        /// <param name="reasoning"></param>
        /// <param name="content"></param>
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