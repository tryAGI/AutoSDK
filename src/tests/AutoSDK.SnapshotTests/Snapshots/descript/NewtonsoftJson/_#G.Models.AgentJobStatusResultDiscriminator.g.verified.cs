//HintName: G.Models.AgentJobStatusResultDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentJobStatusResultDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.AgentJobStatusResultDiscriminatorStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentJobStatusResultDiscriminator" /> class.
        /// </summary>
        /// <param name="status"></param>
        public AgentJobStatusResultDiscriminator(
            global::G.AgentJobStatusResultDiscriminatorStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentJobStatusResultDiscriminator" /> class.
        /// </summary>
        public AgentJobStatusResultDiscriminator()
        {
        }
    }
}