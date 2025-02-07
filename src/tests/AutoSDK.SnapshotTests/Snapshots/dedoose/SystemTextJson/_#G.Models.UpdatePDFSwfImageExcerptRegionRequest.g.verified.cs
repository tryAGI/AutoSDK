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
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentUserId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CurrentUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excerptId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ExcerptId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newStart")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NewStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newEnd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NewEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePDFSwfImageExcerptRegionRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="currentUserId"></param>
        /// <param name="excerptId"></param>
        /// <param name="newStart"></param>
        /// <param name="newEnd"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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