//HintName: G.Models.TrainingTest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrainingTest
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIdKey")]
        public string? ProjectIdKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testType")]
        public int? TestType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdOn")]
        public global::System.DateTime? CreatedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excerptCount")]
        public int? ExcerptCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagCount")]
        public int? TagCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public global::System.Guid? Creator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingTest" /> class.
        /// </summary>
        /// <param name="projectIdKey">
        /// Included only in responses
        /// </param>
        /// <param name="id"></param>
        /// <param name="testType"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="createdOn"></param>
        /// <param name="projectId"></param>
        /// <param name="excerptCount"></param>
        /// <param name="tagCount"></param>
        /// <param name="creator"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TrainingTest(
            string? projectIdKey,
            global::System.Guid? id,
            int? testType,
            string? title,
            string? description,
            global::System.DateTime? createdOn,
            global::System.Guid? projectId,
            int? excerptCount,
            int? tagCount,
            global::System.Guid? creator)
        {
            this.ProjectIdKey = projectIdKey;
            this.Id = id;
            this.TestType = testType;
            this.Title = title;
            this.Description = description;
            this.CreatedOn = createdOn;
            this.ProjectId = projectId;
            this.ExcerptCount = excerptCount;
            this.TagCount = tagCount;
            this.Creator = creator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingTest" /> class.
        /// </summary>
        public TrainingTest()
        {
        }
    }
}