//HintName: G.Models.StartDocumentSearchJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartDocumentSearchJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SearchText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartDocumentSearchJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="searchText"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StartDocumentSearchJobRequest(
            global::System.Guid projectId,
            string searchText)
        {
            this.ProjectId = projectId;
            this.SearchText = searchText ?? throw new global::System.ArgumentNullException(nameof(searchText));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartDocumentSearchJobRequest" /> class.
        /// </summary>
        public StartDocumentSearchJobRequest()
        {
        }
    }
}