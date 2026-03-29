//HintName: G.Models.WarmTransferPrompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WarmTransferPrompt
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WarmTransferPromptTypeJsonConverter))]
        public global::G.WarmTransferPromptType? Type { get; set; }

        /// <summary>
        /// The prompt to be used for warm handoff. Can contain dynamic variables.<br/>
        /// Example: Summarize the call in one sentence for the warn handoff.
        /// </summary>
        /// <example>Summarize the call in one sentence for the warn handoff.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WarmTransferPrompt" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="prompt">
        /// The prompt to be used for warm handoff. Can contain dynamic variables.<br/>
        /// Example: Summarize the call in one sentence for the warn handoff.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WarmTransferPrompt(
            global::G.WarmTransferPromptType? type,
            string? prompt)
        {
            this.Type = type;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WarmTransferPrompt" /> class.
        /// </summary>
        public WarmTransferPrompt()
        {
        }
    }
}