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
        /// Initializes a new instance of the <see cref="SaveTestResultRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="traineeUserId"></param>
        /// <param name="testId"></param>
        /// <param name="overallRating"></param>
        /// <param name="traineeTagApps"></param>
        /// <param name="completed"></param>
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