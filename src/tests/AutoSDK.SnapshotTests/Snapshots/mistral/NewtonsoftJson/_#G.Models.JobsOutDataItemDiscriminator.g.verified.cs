//HintName: G.Models.JobsOutDataItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobsOutDataItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_type")]
        public global::G.JobsOutDataItemDiscriminatorJobType? JobType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsOutDataItemDiscriminator" /> class.
        /// </summary>
        /// <param name="jobType"></param>
        public JobsOutDataItemDiscriminator(
            global::G.JobsOutDataItemDiscriminatorJobType? jobType)
        {
            this.JobType = jobType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsOutDataItemDiscriminator" /> class.
        /// </summary>
        public JobsOutDataItemDiscriminator()
        {
        }
    }
}