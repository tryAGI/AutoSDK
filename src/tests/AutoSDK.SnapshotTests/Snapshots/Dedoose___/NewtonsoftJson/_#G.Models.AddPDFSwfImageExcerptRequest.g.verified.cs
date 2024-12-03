//HintName: G.Models.AddPDFSwfImageExcerptRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddPDFSwfImageExcerptRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resourceId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ResourceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public int Start { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public int End { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tagIdsToApply", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> TagIdsToApply { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddPDFSwfImageExcerptRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="resourceId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="tagIdsToApply"></param>
        public AddPDFSwfImageExcerptRequest(
            global::System.Guid projectId,
            global::System.Guid userId,
            global::System.Guid resourceId,
            int start,
            int end,
            global::System.Collections.Generic.IList<global::System.Guid> tagIdsToApply)
        {
            this.ProjectId = projectId;
            this.UserId = userId;
            this.ResourceId = resourceId;
            this.Start = start;
            this.End = end;
            this.TagIdsToApply = tagIdsToApply ?? throw new global::System.ArgumentNullException(nameof(tagIdsToApply));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddPDFSwfImageExcerptRequest" /> class.
        /// </summary>
        public AddPDFSwfImageExcerptRequest()
        {
        }
    }
}