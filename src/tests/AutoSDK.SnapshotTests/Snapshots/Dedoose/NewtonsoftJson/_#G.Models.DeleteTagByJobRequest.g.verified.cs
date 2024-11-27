//HintName: G.Models.DeleteTagByJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteTagByJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("currentProjectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid CurrentProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Tag Tag { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTagByJobRequest" /> class.
        /// </summary>
        /// <param name="currentProjectId"></param>
        /// <param name="tag"></param>
        public DeleteTagByJobRequest(
            global::System.Guid currentProjectId,
            global::G.Tag tag)
        {
            this.CurrentProjectId = currentProjectId;
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTagByJobRequest" /> class.
        /// </summary>
        public DeleteTagByJobRequest()
        {
        }
    }
}