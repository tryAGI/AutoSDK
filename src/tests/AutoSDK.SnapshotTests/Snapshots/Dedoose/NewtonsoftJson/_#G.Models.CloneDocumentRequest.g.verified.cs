//HintName: G.Models.CloneDocumentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloneDocumentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resourceId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ResourceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cloneExcerpts", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CloneExcerpts { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cloneTagApps", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CloneTagApps { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneDocumentRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="cloneExcerpts"></param>
        /// <param name="cloneTagApps"></param>
        public CloneDocumentRequest(
            global::System.Guid projectId,
            global::System.Guid resourceId,
            bool cloneExcerpts,
            bool cloneTagApps)
        {
            this.ProjectId = projectId;
            this.ResourceId = resourceId;
            this.CloneExcerpts = cloneExcerpts;
            this.CloneTagApps = cloneTagApps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneDocumentRequest" /> class.
        /// </summary>
        public CloneDocumentRequest()
        {
        }
    }
}