//HintName: G.Models.UpdateProjectRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectRequest2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedTitle", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedTitle { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedDescription", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedDescription { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequest2" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="updatedTitle"></param>
        /// <param name="updatedDescription"></param>
        public UpdateProjectRequest2(
            global::System.Guid projectId,
            string updatedTitle,
            string updatedDescription)
        {
            this.ProjectId = projectId;
            this.UpdatedTitle = updatedTitle ?? throw new global::System.ArgumentNullException(nameof(updatedTitle));
            this.UpdatedDescription = updatedDescription ?? throw new global::System.ArgumentNullException(nameof(updatedDescription));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequest2" /> class.
        /// </summary>
        public UpdateProjectRequest2()
        {
        }
    }
}