//HintName: G.Models.TextContentPart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextContentPart
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"text"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "text";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextContentPart" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type"></param>
        public TextContentPart(
            string text,
            string type = "text")
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextContentPart" /> class.
        /// </summary>
        public TextContentPart()
        {
        }
    }
}