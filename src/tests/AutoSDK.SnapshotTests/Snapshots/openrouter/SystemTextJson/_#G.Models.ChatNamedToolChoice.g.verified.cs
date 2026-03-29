//HintName: G.Models.ChatNamedToolChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Named tool choice for specific function
    /// </summary>
    public sealed partial class ChatNamedToolChoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatNamedToolChoiceTypeJsonConverter))]
        public global::G.ChatNamedToolChoiceType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatNamedToolChoiceFunction Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatNamedToolChoice" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatNamedToolChoice(
            global::G.ChatNamedToolChoiceFunction function,
            global::G.ChatNamedToolChoiceType type)
        {
            this.Type = type;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatNamedToolChoice" /> class.
        /// </summary>
        public ChatNamedToolChoice()
        {
        }
    }
}