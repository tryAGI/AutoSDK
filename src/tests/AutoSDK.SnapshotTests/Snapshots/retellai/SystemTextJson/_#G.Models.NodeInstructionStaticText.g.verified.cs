//HintName: G.Models.NodeInstructionStaticText.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeInstructionStaticText
    {
        /// <summary>
        /// Type of instruction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.NodeInstructionStaticTextTypeJsonConverter))]
        public global::G.NodeInstructionStaticTextType Type { get; set; }

        /// <summary>
        /// The static text for the instruction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeInstructionStaticText" /> class.
        /// </summary>
        /// <param name="text">
        /// The static text for the instruction
        /// </param>
        /// <param name="type">
        /// Type of instruction
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeInstructionStaticText(
            string text,
            global::G.NodeInstructionStaticTextType type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeInstructionStaticText" /> class.
        /// </summary>
        public NodeInstructionStaticText()
        {
        }
    }
}