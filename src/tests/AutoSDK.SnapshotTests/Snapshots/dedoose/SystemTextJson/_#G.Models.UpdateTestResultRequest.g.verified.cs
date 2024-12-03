//HintName: G.Models.UpdateTestResultRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTestResultRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("traineeUserId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TraineeUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resultId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ResultId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overallRating")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double OverallRating { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traineeTagApps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TrainingTestTagApp> TraineeTagApps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Completed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTestResultRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="traineeUserId"></param>
        /// <param name="testId"></param>
        /// <param name="resultId"></param>
        /// <param name="overallRating"></param>
        /// <param name="traineeTagApps"></param>
        /// <param name="completed"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateTestResultRequest(
            global::System.Guid projectId,
            global::System.Guid traineeUserId,
            global::System.Guid testId,
            global::System.Guid resultId,
            double overallRating,
            global::System.Collections.Generic.IList<global::G.TrainingTestTagApp> traineeTagApps,
            bool completed)
        {
            this.ProjectId = projectId;
            this.TraineeUserId = traineeUserId;
            this.TestId = testId;
            this.ResultId = resultId;
            this.OverallRating = overallRating;
            this.TraineeTagApps = traineeTagApps ?? throw new global::System.ArgumentNullException(nameof(traineeTagApps));
            this.Completed = completed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTestResultRequest" /> class.
        /// </summary>
        public UpdateTestResultRequest()
        {
        }
    }
}