//HintName: G.Models.StartCopyProjectJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartCopyProjectJobRequest
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
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("decription", Required = global::Newtonsoft.Json.Required.Always)]
        public string Decription { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartCopyProjectJobRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="decription"></param>
        public StartCopyProjectJobRequest(
            global::System.Guid userId,
            global::System.Guid projectId,
            string title,
            string decription)
        {
            this.UserId = userId;
            this.ProjectId = projectId;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Decription = decription ?? throw new global::System.ArgumentNullException(nameof(decription));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartCopyProjectJobRequest" /> class.
        /// </summary>
        public StartCopyProjectJobRequest()
        {
        }
    }
}