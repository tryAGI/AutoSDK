//HintName: G.Models.ReturnChatGroupPagedAudioReconstructions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReturnChatGroupPagedAudioReconstructions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination_direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReturnChatGroupPagedAudioReconstructionsPaginationDirectionJsonConverter))]
        public global::G.ReturnChatGroupPagedAudioReconstructionsPaginationDirection? PaginationDirection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_reconstructions_page")]
        public global::System.Collections.Generic.IList<global::G.ReturnChatAudioReconstruction>? AudioReconstructionsPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_number")]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_pages")]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnChatGroupPagedAudioReconstructions" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="paginationDirection"></param>
        /// <param name="audioReconstructionsPage"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalPages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReturnChatGroupPagedAudioReconstructions(
            string? id,
            global::G.ReturnChatGroupPagedAudioReconstructionsPaginationDirection? paginationDirection,
            global::System.Collections.Generic.IList<global::G.ReturnChatAudioReconstruction>? audioReconstructionsPage,
            int? pageNumber,
            int? pageSize,
            int? totalPages)
        {
            this.Id = id;
            this.PaginationDirection = paginationDirection;
            this.AudioReconstructionsPage = audioReconstructionsPage;
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.TotalPages = totalPages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnChatGroupPagedAudioReconstructions" /> class.
        /// </summary>
        public ReturnChatGroupPagedAudioReconstructions()
        {
        }
    }
}