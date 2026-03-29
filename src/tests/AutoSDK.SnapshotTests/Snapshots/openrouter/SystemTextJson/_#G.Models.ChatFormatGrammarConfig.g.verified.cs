//HintName: G.Models.ChatFormatGrammarConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Custom grammar response format
    /// </summary>
    public sealed partial class ChatFormatGrammarConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatFormatGrammarConfigTypeJsonConverter))]
        public global::G.ChatFormatGrammarConfigType Type { get; set; }

        /// <summary>
        /// Custom grammar for text generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grammar")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Grammar { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFormatGrammarConfig" /> class.
        /// </summary>
        /// <param name="grammar">
        /// Custom grammar for text generation
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatFormatGrammarConfig(
            string grammar,
            global::G.ChatFormatGrammarConfigType type)
        {
            this.Type = type;
            this.Grammar = grammar ?? throw new global::System.ArgumentNullException(nameof(grammar));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFormatGrammarConfig" /> class.
        /// </summary>
        public ChatFormatGrammarConfig()
        {
        }
    }
}