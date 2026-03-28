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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BetaContentBlockSourceTypeJsonConverter))]
        public global::G.BetaContentBlockSourceType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ContentBetaContentBlockSourceContentItem>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.ContentBetaContentBlockSourceContentItem>> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContentBlockSource" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="content"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaContentBlockSource(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.ContentBetaContentBlockSourceContentItem>> content,
            global::G.BetaContentBlockSourceType type)
        {
            this.Content = content;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContentBlockSource" /> class.
        /// </summary>
        public BetaContentBlockSource()
        {
        }
    }
}