//HintName: G.Models.UpdateExcerptRangeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateExcerptRangeRequest
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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedTextURI", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedTextURI { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExcerptRangeRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="excerptId"></param>
        /// <param name="newStart"></param>
        /// <param name="newEnd"></param>
        /// <param name="updatedTextURI"></param>
        public UpdateExcerptRangeRequest(
            global::System.Guid projectId,
            global::System.Guid userId,
            global::System.Guid excerptId,
            int newStart,
            int newEnd,
            string updatedTextURI)
        {
            this.ProjectId = projectId;
            this.UserId = userId;
            this.ExcerptId = excerptId;
            this.NewStart = newStart;
            this.NewEnd = newEnd;
            this.UpdatedTextURI = updatedTextURI ?? throw new global::System.ArgumentNullException(nameof(updatedTextURI));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExcerptRangeRequest" /> class.
        /// </summary>
        public UpdateExcerptRangeRequest()
        {
        }
    }
}