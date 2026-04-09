//HintName: G.Models.JobStatusDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobStatusDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.JobStatusDiscriminatorJobTypeJsonConverter))]
        public global::G.JobStatusDiscriminatorJobType? JobType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobStatusDiscriminator" /> class.
        /// </summary>
        /// <param name="jobType"></param>
        public JobStatusDiscriminator(
            global::G.JobStatusDiscriminatorJobType? jobType)
        {
            this.JobType = jobType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobStatusDiscriminator" /> class.
        /// </summary>
        public JobStatusDiscriminator()
        {
        }
    }
}