//HintName: G.Models.TrainingTestTag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrainingTestTag
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIdKey")]
        public string? ProjectIdKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public global::System.Guid? ProjectId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainingTagParentIDL")]
        public global::System.Guid? TrainingTagParentIDL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dateCreated")]
        public global::System.DateTime? DateCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isWeighted")]
        public bool? IsWeighted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weightMin")]
        public double? WeightMin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weightMax")]
        public double? WeightMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weightDefault")]
        public double? WeightDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sortOrder")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIDL")]
        public global::System.Guid? ProjectIDL { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingTestTag" /> class.
        /// </summary>
        /// <param name="projectIdKey"></param>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="trainingTestIDL"></param>
        /// <param name="title"></param>
        /// <param name="trainingTagParentIDL"></param>
        /// <param name="dateCreated"></param>
        /// <param name="description"></param>
        /// <param name="isWeighted"></param>
        /// <param name="weightMin"></param>
        /// <param name="weightMax"></param>
        /// <param name="weightDefault"></param>
        /// <param name="sortOrder"></param>
        /// <param name="projectIDL"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingTestTag(
            string? projectIdKey,
            global::System.Guid? projectId,
            global::System.Guid? id,
            global::System.Guid? trainingTestIDL,
            string? title,
            global::System.Guid? trainingTagParentIDL,
            global::System.DateTime? dateCreated,
            string? description,
            bool? isWeighted,
            double? weightMin,
            double? weightMax,
            double? weightDefault,
            int? sortOrder,
            global::System.Guid? projectIDL)
        {
            this.ProjectIdKey = projectIdKey;
            this.ProjectId = projectId;
            this.Id = id;
            this.TrainingTestIDL = trainingTestIDL;
            this.Title = title;
            this.TrainingTagParentIDL = trainingTagParentIDL;
            this.DateCreated = dateCreated;
            this.Description = description;
            this.IsWeighted = isWeighted;
            this.WeightMin = weightMin;
            this.WeightMax = weightMax;
            this.WeightDefault = weightDefault;
            this.SortOrder = sortOrder;
            this.ProjectIDL = projectIDL;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingTestTag" /> class.
        /// </summary>
        public TrainingTestTag()
        {
        }
    }
}