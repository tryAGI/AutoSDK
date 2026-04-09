//HintName: G.Models.TextContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextContent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TextContentTypeJsonConverter))]
        public global::G.TextContentType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TextContentLanguageJsonConverter))]
        public global::G.TextContentLanguage Language { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextContent" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="language"></param>
        /// <param name="type"></param>
        public TextContent(
            string text,
            global::G.TextContentLanguage language,
            global::G.TextContentType type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextContent" /> class.
        /// </summary>
        public TextContent()
        {
        }
    }
}