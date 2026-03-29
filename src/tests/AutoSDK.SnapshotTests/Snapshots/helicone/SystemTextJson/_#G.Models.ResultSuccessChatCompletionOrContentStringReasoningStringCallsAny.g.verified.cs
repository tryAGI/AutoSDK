//HintName: G.Models.ResultSuccessChatCompletionOrContentStringReasoningStringCallsAny.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessChatCompletionOrContentStringReasoningStringCallsAny
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.ChatCompletion, global::G.ResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.ChatCompletion, global::G.ResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData> Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public double? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessChatCompletionOrContentStringReasoningStringCallsAny" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResultSuccessChatCompletionOrContentStringReasoningStringCallsAny(
            global::G.AnyOf<global::G.ChatCompletion, global::G.ResultSuccessChatCompletionOrContentStringReasoningStringCallsAnyData> data,
            double? error)
        {
            this.Data = data;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessChatCompletionOrContentStringReasoningStringCallsAny" /> class.
        /// </summary>
        public ResultSuccessChatCompletionOrContentStringReasoningStringCallsAny()
        {
        }
    }
}