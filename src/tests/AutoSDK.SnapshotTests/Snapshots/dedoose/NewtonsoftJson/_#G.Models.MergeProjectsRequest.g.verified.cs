//HintName: G.Models.MergeProjectsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MergeProjectsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project1Id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Project1Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project2Id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Project2Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("newTitle", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewTitle { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("newDescription", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewDescription { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creatorId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid CreatorId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mergeCodes", Required = global::Newtonsoft.Json.Required.Always)]
        public bool MergeCodes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MergeProjectsRequest" /> class.
        /// </summary>
        /// <param name="project1Id"></param>
        /// <param name="project2Id"></param>
        /// <param name="newTitle"></param>
        /// <param name="newDescription"></param>
        /// <param name="creatorId"></param>
        /// <param name="mergeCodes"></param>
        public MergeProjectsRequest(
            global::System.Guid project1Id,
            global::System.Guid project2Id,
            string newTitle,
            string newDescription,
            global::System.Guid creatorId,
            bool mergeCodes)
        {
            this.Project1Id = project1Id;
            this.Project2Id = project2Id;
            this.NewTitle = newTitle ?? throw new global::System.ArgumentNullException(nameof(newTitle));
            this.NewDescription = newDescription ?? throw new global::System.ArgumentNullException(nameof(newDescription));
            this.CreatorId = creatorId;
            this.MergeCodes = mergeCodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MergeProjectsRequest" /> class.
        /// </summary>
        public MergeProjectsRequest()
        {
        }
    }
}