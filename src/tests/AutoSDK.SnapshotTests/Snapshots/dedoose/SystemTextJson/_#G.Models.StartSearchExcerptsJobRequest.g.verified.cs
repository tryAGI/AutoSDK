//HintName: G.Models.StartSearchExcerptsJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartSearchExcerptsJobRequest
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
        /// Initializes a new instance of the <see cref="StartSearchExcerptsJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="searchText"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartSearchExcerptsJobRequest(
            global::System.Guid projectId,
            string searchText)
        {
            this.ProjectId = projectId;
            this.SearchText = searchText ?? throw new global::System.ArgumentNullException(nameof(searchText));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartSearchExcerptsJobRequest" /> class.
        /// </summary>
        public StartSearchExcerptsJobRequest()
        {
        }
    }
}