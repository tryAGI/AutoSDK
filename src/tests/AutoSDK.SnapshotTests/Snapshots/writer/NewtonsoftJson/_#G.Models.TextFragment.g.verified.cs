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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.TextFragmentType Type { get; set; }

        /// <summary>
        /// The actual text content of the message fragment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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