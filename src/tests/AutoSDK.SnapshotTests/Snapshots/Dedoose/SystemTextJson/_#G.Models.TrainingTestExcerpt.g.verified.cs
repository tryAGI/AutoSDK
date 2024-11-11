//HintName: G.Models.TrainingTestExcerpt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrainingTestExcerpt
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
        [global::System.Text.Json.Serialization.JsonPropertyName("trainingTestIDL")]
        public global::System.Guid? TrainingTestIDL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createDate")]
        public global::System.DateTime? CreateDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excerptDataPathURL")]
        public string? ExcerptDataPathURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originalResourceId")]
        public global::System.Guid? OriginalResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originalExcerptId")]
        public global::System.Guid? OriginalExcerptId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originalStartLocation")]
        public int? OriginalStartLocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originalEndLocation")]
        public int? OriginalEndLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingTestExcerpt" /> class.
        /// </summary>
        /// <param name="projectIdKey">
        /// Included only in responses
        /// </param>
        /// <param name="id"></param>
        /// <param name="trainingTestIDL"></param>
        /// <param name="createDate"></param>
        /// <param name="excerptDataPathURL"></param>
        /// <param name="projectId"></param>
        /// <param name="originalResourceId"></param>
        /// <param name="originalExcerptId"></param>
        /// <param name="originalStartLocation"></param>
        /// <param name="originalEndLocation"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TrainingTestExcerpt(
            string? projectIdKey,
            global::System.Guid? id,
            global::System.Guid? trainingTestIDL,
            global::System.DateTime? createDate,
            string? excerptDataPathURL,
            global::System.Guid? projectId,
            global::System.Guid? originalResourceId,
            global::System.Guid? originalExcerptId,
            int? originalStartLocation,
            int? originalEndLocation)
        {
            this.ProjectIdKey = projectIdKey;
            this.Id = id;
            this.TrainingTestIDL = trainingTestIDL;
            this.CreateDate = createDate;
            this.ExcerptDataPathURL = excerptDataPathURL;
            this.ProjectId = projectId;
            this.OriginalResourceId = originalResourceId;
            this.OriginalExcerptId = originalExcerptId;
            this.OriginalStartLocation = originalStartLocation;
            this.OriginalEndLocation = originalEndLocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingTestExcerpt" /> class.
        /// </summary>
        public TrainingTestExcerpt()
        {
        }
    }
}