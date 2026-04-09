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
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatFormatGrammarConfigTypeJsonConverter))]
        public global::G.ChatFormatGrammarConfigType Type { get; set; }

        /// <summary>
        /// Custom grammar for text generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("grammar", Required = global::Newtonsoft.Json.Required.Always)]
        public string Grammar { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFormatGrammarConfig" /> class.
        /// </summary>
        /// <param name="grammar">
        /// Custom grammar for text generation
        /// </param>
        /// <param name="type"></param>
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