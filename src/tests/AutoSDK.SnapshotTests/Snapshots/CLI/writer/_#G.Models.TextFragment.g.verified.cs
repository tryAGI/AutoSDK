//HintName: G.Models.TextFragment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a text content fragment within a chat message.
    /// </summary>
    public sealed partial class TextFragment
    {
        /// <summary>
        /// The type of content fragment. Must be `text` for text fragments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TextFragmentTypeJsonConverter))]
        public global::G.TextFragmentType Type { get; set; }

        /// <summary>
        /// The actual text content of the message fragment.
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
        /// Initializes a new instance of the <see cref="TextFragment" /> class.
        /// </summary>
        /// <param name="text">
        /// The actual text content of the message fragment.
        /// </param>
        /// <param name="type">
        /// The type of content fragment. Must be `text` for text fragments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextFragment(
            string text,
            global::G.TextFragmentType type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextFragment" /> class.
        /// </summary>
        public TextFragment()
        {
        }
    }
}