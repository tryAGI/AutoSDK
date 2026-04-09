//HintName: G.Models.BetaContentBlockSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaContentBlockSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BetaContentBlockSourceTypeJsonConverter))]
        public global::G.BetaContentBlockSourceType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.ContentBetaContentBlockSourceContentItem>> Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContentBlockSource" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="type"></param>
        public BetaContentBlockSource(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.ContentBetaContentBlockSourceContentItem>> content,
            global::G.BetaContentBlockSourceType type)
        {
            this.Type = type;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContentBlockSource" /> class.
        /// </summary>
        public BetaContentBlockSource()
        {
        }
    }
}