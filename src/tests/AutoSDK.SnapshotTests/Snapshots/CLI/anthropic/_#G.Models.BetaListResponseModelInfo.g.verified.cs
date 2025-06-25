//HintName: G.Models.BetaListResponseModelInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaListResponseModelInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.BetaModelInfo> Data { get; set; }

        /// <summary>
        /// Indicates if there are more results in the requested page direction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// First ID in the `data` list. Can be used as the `before_id` for the previous page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? FirstId { get; set; }

        /// <summary>
        /// Last ID in the `data` list. Can be used as the `after_id` for the next page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? LastId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaListResponseModelInfo" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="hasMore">
        /// Indicates if there are more results in the requested page direction.
        /// </param>
        /// <param name="firstId">
        /// First ID in the `data` list. Can be used as the `before_id` for the previous page.
        /// </param>
        /// <param name="lastId">
        /// Last ID in the `data` list. Can be used as the `after_id` for the next page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaListResponseModelInfo(
            global::System.Collections.Generic.IList<global::G.BetaModelInfo> data,
            bool hasMore,
            string? firstId,
            string? lastId)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.FirstId = firstId ?? throw new global::System.ArgumentNullException(nameof(firstId));
            this.LastId = lastId ?? throw new global::System.ArgumentNullException(nameof(lastId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaListResponseModelInfo" /> class.
        /// </summary>
        public BetaListResponseModelInfo()
        {
        }
    }
}