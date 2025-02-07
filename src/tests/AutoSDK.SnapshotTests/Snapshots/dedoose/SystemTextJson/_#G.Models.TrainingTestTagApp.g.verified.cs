//HintName: G.Models.TrainingTestTagApp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrainingTestTagApp
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
        [global::System.Text.Json.Serialization.JsonPropertyName("createdOn")]
        public global::System.DateTime? CreatedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainingTagIDL")]
        public global::System.Guid? TrainingTagIDL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainingTestExcerptId")]
        public global::System.Guid? TrainingTestExcerptId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIDL")]
        public global::System.Guid? ProjectIDL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainingTestResultIDL")]
        public global::System.Guid? TrainingTestResultIDL { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingTestTagApp" /> class.
        /// </summary>
        /// <param name="projectIdKey"></param>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="trainingTestIDL"></param>
        /// <param name="createdOn"></param>
        /// <param name="trainingTagIDL"></param>
        /// <param name="weight"></param>
        /// <param name="trainingTestExcerptId"></param>
        /// <param name="projectIDL"></param>
        /// <param name="trainingTestResultIDL"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingTestTagApp(
            string? projectIdKey,
            global::System.Guid? projectId,
            global::System.Guid? id,
            global::System.Guid? trainingTestIDL,
            global::System.DateTime? createdOn,
            global::System.Guid? trainingTagIDL,
            double? weight,
            global::System.Guid? trainingTestExcerptId,
            global::System.Guid? projectIDL,
            global::System.Guid? trainingTestResultIDL)
        {
            this.ProjectIdKey = projectIdKey;
            this.ProjectId = projectId;
            this.Id = id;
            this.TrainingTestIDL = trainingTestIDL;
            this.CreatedOn = createdOn;
            this.TrainingTagIDL = trainingTagIDL;
            this.Weight = weight;
            this.TrainingTestExcerptId = trainingTestExcerptId;
            this.ProjectIDL = projectIDL;
            this.TrainingTestResultIDL = trainingTestResultIDL;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingTestTagApp" /> class.
        /// </summary>
        public TrainingTestTagApp()
        {
        }
    }
}