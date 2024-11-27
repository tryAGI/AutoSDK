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
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("traineeUserId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TraineeUserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("testId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TestId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resultId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ResultId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("overallRating", Required = global::Newtonsoft.Json.Required.Always)]
        public double OverallRating { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("traineeTagApps", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TrainingTestTagApp> TraineeTagApps { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Completed { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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