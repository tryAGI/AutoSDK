//HintName: G.Models.FilesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.FileResponse> Data { get; set; }

        /// <summary>
        /// Indicates if there are more files available beyond the current page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// The ID of the first file in the current response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        public string? FirstId { get; set; }

        /// <summary>
        /// The ID of the last file in the current response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        public string? LastId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="hasMore">
        /// Indicates if there are more files available beyond the current page.
        /// </param>
        /// <param name="firstId">
        /// The ID of the first file in the current response.
        /// </param>
        /// <param name="lastId">
        /// The ID of the last file in the current response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilesResponse(
            global::System.Collections.Generic.IList<global::G.FileResponse> data,
            bool hasMore,
            string? firstId,
            string? lastId)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.FirstId = firstId;
            this.LastId = lastId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesResponse" /> class.
        /// </summary>
        public FilesResponse()
        {
        }
    }
}