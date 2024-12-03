//HintName: G.Models.GetFilteredUsersRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFilteredUsersRequest2
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
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxResults")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFilteredUsersRequest2" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="filter"></param>
        /// <param name="maxResults"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetFilteredUsersRequest2(
            global::System.Guid projectId,
            string filter,
            int maxResults)
        {
            this.ProjectId = projectId;
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.MaxResults = maxResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFilteredUsersRequest2" /> class.
        /// </summary>
        public GetFilteredUsersRequest2()
        {
        }
    }
}