//HintName: G.Models.TextBlockDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A delta in a streaming text block.
    /// </summary>
    public sealed partial class TextBlockDelta
    {
        /// <summary>
        /// The text delta.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The type of content block.<br/>
        /// Default Value: text_delta
        /// </summary>
        /// <default>"text_delta"</default>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextBlockDelta" /> class.
        /// </summary>
        /// <param name="text">
        /// The text delta.
        /// </param>
        /// <param name="type">
        /// The type of content block.<br/>
        /// Default Value: text_delta
        /// </param>
        public TextBlockDelta(
            string text,
            string type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextBlockDelta" /> class.
        /// </summary>
        public TextBlockDelta()
        {
        }
    }
}