//HintName: G.Models.SaveTestResultRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SaveTestResultRequest
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
        /// Initializes a new instance of the <see cref="SaveTestResultRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="traineeUserId"></param>
        /// <param name="testId"></param>
        /// <param name="overallRating"></param>
        /// <param name="traineeTagApps"></param>
        /// <param name="completed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SaveTestResultRequest(
            global::System.Guid projectId,
            global::System.Guid traineeUserId,
            global::System.Guid testId,
            double overallRating,
            global::System.Collections.Generic.IList<global::G.TrainingTestTagApp> traineeTagApps,
            bool completed)
        {
            this.ProjectId = projectId;
            this.TraineeUserId = traineeUserId;
            this.TestId = testId;
            this.OverallRating = overallRating;
            this.TraineeTagApps = traineeTagApps ?? throw new global::System.ArgumentNullException(nameof(traineeTagApps));
            this.Completed = completed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveTestResultRequest" /> class.
        /// </summary>
        public SaveTestResultRequest()
        {
        }
    }
}