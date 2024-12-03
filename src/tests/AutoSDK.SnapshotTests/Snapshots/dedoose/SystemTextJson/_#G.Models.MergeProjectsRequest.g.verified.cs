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
        [global::System.Text.Json.Serialization.JsonPropertyName("project1Id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Project1Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project2Id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Project2Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newTitle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newDescription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creatorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CreatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mergeCodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool MergeCodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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