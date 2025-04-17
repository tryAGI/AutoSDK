//HintName: G.Models.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobTypeJsonConverter))]
        public global::G.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType? JobType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="jobType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminator(
            global::G.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType? jobType)
        {
            this.JobType = jobType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminator" /> class.
        /// </summary>
        public JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminator()
        {
        }
    }
}