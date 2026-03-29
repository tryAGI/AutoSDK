//HintName: G.Models.OutputItemWebSearchCallActionOneOf0SourcesItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutputItemWebSearchCallActionOneOf0SourcesItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OutputItemWebSearchCallActionOneOf0SourcesItemsTypeJsonConverter))]
        public global::G.OutputItemWebSearchCallActionOneOf0SourcesItemsType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemWebSearchCallActionOneOf0SourcesItems" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemWebSearchCallActionOneOf0SourcesItems(
            string url,
            global::G.OutputItemWebSearchCallActionOneOf0SourcesItemsType type)
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemWebSearchCallActionOneOf0SourcesItems" /> class.
        /// </summary>
        public OutputItemWebSearchCallActionOneOf0SourcesItems()
        {
        }
    }
}