//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItems4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItems4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf4TypeJsonConverter))]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf4Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cited_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CitedText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_result_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SearchResultIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_block_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartBlockIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_block_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndBlockIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItems4" /> class.
        /// </summary>
        /// <param name="citedText"></param>
        /// <param name="searchResultIndex"></param>
        /// <param name="source"></param>
        /// <param name="startBlockIndex"></param>
        /// <param name="endBlockIndex"></param>
        /// <param name="type"></param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItems4(
            string citedText,
            double searchResultIndex,
            string source,
            double startBlockIndex,
            double endBlockIndex,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf4Type type,
            string? title)
        {
            this.Type = type;
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.SearchResultIndex = searchResultIndex;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Title = title;
            this.StartBlockIndex = startBlockIndex;
            this.EndBlockIndex = endBlockIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItems4" /> class.
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItems4()
        {
        }
    }
}