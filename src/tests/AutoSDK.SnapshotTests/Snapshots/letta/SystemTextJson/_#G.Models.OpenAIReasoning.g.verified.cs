//HintName: G.Models.OpenAIReasoning.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIReasoning
    {
        /// <summary>
        /// The reasoning effort to use when generating text reasoning models<br/>
        /// Default Value: minimal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OpenAIReasoningReasoningEffortJsonConverter))]
        public global::G.OpenAIReasoningReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIReasoning" /> class.
        /// </summary>
        /// <param name="reasoningEffort">
        /// The reasoning effort to use when generating text reasoning models<br/>
        /// Default Value: minimal
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIReasoning(
            global::G.OpenAIReasoningReasoningEffort? reasoningEffort)
        {
            this.ReasoningEffort = reasoningEffort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIReasoning" /> class.
        /// </summary>
        public OpenAIReasoning()
        {
        }
    }
}