//HintName: G.Models.ListIncompleteUploadsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListIncompleteUploadsResponse
    {
        /// <summary>
        /// An array containing information about your incomplete upload sessions, up to `page_limit` items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.IncompleteUploadSummary> Data { get; set; }

        /// <summary>
        /// An object that provides information about pagination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PageInfo PageInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListIncompleteUploadsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// An array containing information about your incomplete upload sessions, up to `page_limit` items.
        /// </param>
        /// <param name="pageInfo">
        /// An object that provides information about pagination.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListIncompleteUploadsResponse(
            global::System.Collections.Generic.IList<global::G.IncompleteUploadSummary> data,
            global::G.PageInfo pageInfo)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.PageInfo = pageInfo ?? throw new global::System.ArgumentNullException(nameof(pageInfo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListIncompleteUploadsResponse" /> class.
        /// </summary>
        public ListIncompleteUploadsResponse()
        {
        }
    }
}