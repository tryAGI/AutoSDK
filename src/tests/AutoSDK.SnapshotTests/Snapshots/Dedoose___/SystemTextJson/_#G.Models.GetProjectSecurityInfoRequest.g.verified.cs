//HintName: G.Models.GetProjectSecurityInfoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectSecurityInfoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectSecurityInfoRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetProjectSecurityInfoRequest(
            global::System.Guid projectId)
        {
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectSecurityInfoRequest" /> class.
        /// </summary>
        public GetProjectSecurityInfoRequest()
        {
        }
    }
}