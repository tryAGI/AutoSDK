//HintName: G.Models.AddTestRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddTestRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("trainingTestType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TrainingTestType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdUserId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CreatedUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ExIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TagIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTestRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="trainingTestType"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="createdUserId"></param>
        /// <param name="exIds"></param>
        /// <param name="tagIds"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AddTestRequest(
            global::System.Guid projectId,
            int trainingTestType,
            string title,
            string description,
            global::System.Guid createdUserId,
            global::System.Collections.Generic.IList<string> exIds,
            global::System.Collections.Generic.IList<string> tagIds)
        {
            this.ProjectId = projectId;
            this.TrainingTestType = trainingTestType;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.CreatedUserId = createdUserId;
            this.ExIds = exIds ?? throw new global::System.ArgumentNullException(nameof(exIds));
            this.TagIds = tagIds ?? throw new global::System.ArgumentNullException(nameof(tagIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTestRequest" /> class.
        /// </summary>
        public AddTestRequest()
        {
        }
    }
}