//HintName: G.Models.DeleteExcerptRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteExcerptRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excerptId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ExcerptId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteExcerptRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="excerptId"></param>
        public DeleteExcerptRequest(
            global::System.Guid projectId,
            global::System.Guid excerptId)
        {
            this.ProjectId = projectId;
            this.ExcerptId = excerptId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteExcerptRequest" /> class.
        /// </summary>
        public DeleteExcerptRequest()
        {
        }
    }
}