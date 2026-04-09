//HintName: G.Models.ContentBlockSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentBlockSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ContentBlockSourceTypeJsonConverter))]
        public global::G.ContentBlockSourceType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.ContentContentBlockSourceContentItem>> Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentBlockSource" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="type"></param>
        public ContentBlockSource(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.ContentContentBlockSourceContentItem>> content,
            global::G.ContentBlockSourceType type)
        {
            this.Type = type;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentBlockSource" /> class.
        /// </summary>
        public ContentBlockSource()
        {
        }
    }
}