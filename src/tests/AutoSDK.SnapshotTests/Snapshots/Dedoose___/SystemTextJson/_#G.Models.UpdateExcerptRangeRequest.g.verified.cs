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
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedTextURI")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedTextURI { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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