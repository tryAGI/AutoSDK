//HintName: G.Models.UpdatePDFSwfImageExcerptRegionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePDFSwfImageExcerptRegionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("currentUserId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid CurrentUserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excerptId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ExcerptId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("newStart", Required = global::Newtonsoft.Json.Required.Always)]
        public int NewStart { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("newEnd", Required = global::Newtonsoft.Json.Required.Always)]
        public int NewEnd { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePDFSwfImageExcerptRegionRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="currentUserId"></param>
        /// <param name="excerptId"></param>
        /// <param name="newStart"></param>
        /// <param name="newEnd"></param>
        public UpdatePDFSwfImageExcerptRegionRequest(
            global::System.Guid projectId,
            global::System.Guid currentUserId,
            global::System.Guid excerptId,
            int newStart,
            int newEnd)
        {
            this.ProjectId = projectId;
            this.CurrentUserId = currentUserId;
            this.ExcerptId = excerptId;
            this.NewStart = newStart;
            this.NewEnd = newEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePDFSwfImageExcerptRegionRequest" /> class.
        /// </summary>
        public UpdatePDFSwfImageExcerptRegionRequest()
        {
        }
    }
}