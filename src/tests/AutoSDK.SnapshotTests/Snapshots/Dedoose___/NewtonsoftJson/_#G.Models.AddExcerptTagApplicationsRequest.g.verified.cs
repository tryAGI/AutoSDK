//HintName: G.Models.AddExcerptTagApplicationsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddExcerptTagApplicationsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid UserId { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("excerptId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ExcerptId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tagApps", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TagAppSimple> TagApps { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddExcerptTagApplicationsRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="excerptId"></param>
        /// <param name="tagApps"></param>
        public AddExcerptTagApplicationsRequest(
            global::System.Guid userId,
            global::System.Guid projectId,
            global::System.Guid resourceId,
            global::System.Guid excerptId,
            global::System.Collections.Generic.IList<global::G.TagAppSimple> tagApps)
        {
            this.UserId = userId;
            this.ProjectId = projectId;
            this.ResourceId = resourceId;
            this.ExcerptId = excerptId;
            this.TagApps = tagApps ?? throw new global::System.ArgumentNullException(nameof(tagApps));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddExcerptTagApplicationsRequest" /> class.
        /// </summary>
        public AddExcerptTagApplicationsRequest()
        {
        }
    }
}