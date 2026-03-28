//HintName: G.Models.DubbingMetadataPageResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbingMetadataPageResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dubs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.DubbingMetadataResponse> Dubs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingMetadataPageResponseModel" /> class.
        /// </summary>
        /// <param name="dubs"></param>
        /// <param name="hasMore"></param>
        /// <param name="nextCursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingMetadataPageResponseModel(
            global::System.Collections.Generic.IList<global::G.DubbingMetadataResponse> dubs,
            bool hasMore,
            string? nextCursor)
        {
            this.Dubs = dubs ?? throw new global::System.ArgumentNullException(nameof(dubs));
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingMetadataPageResponseModel" /> class.
        /// </summary>
        public DubbingMetadataPageResponseModel()
        {
        }
    }
}