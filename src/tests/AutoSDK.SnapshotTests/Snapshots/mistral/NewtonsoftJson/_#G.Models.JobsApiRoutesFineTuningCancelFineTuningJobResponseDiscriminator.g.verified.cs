//HintName: G.Models.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_type")]
        public global::G.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType? JobType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="jobType"></param>
        public JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminator(
            global::G.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType? jobType)
        {
            this.JobType = jobType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminator" /> class.
        /// </summary>
        public JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminator()
        {
        }
    }
}