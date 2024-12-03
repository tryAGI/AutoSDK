//HintName: G.Models.GetTagApplicationsByProjectRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTagApplicationsByProjectRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTagApplicationsByProjectRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetTagApplicationsByProjectRequest(
            global::System.Guid projectId,
            int page,
            int pageSize)
        {
            this.ProjectId = projectId;
            this.Page = page;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTagApplicationsByProjectRequest" /> class.
        /// </summary>
        public GetTagApplicationsByProjectRequest()
        {
        }
    }
}