//HintName: G.Models.ConsensusThreadStatusVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConsensusThreadStatusVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("consensus_thread_status")]
        public global::G.ConsensusThreadStatusVariant1ConsensusThreadStatus ConsensusThreadStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_update", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime LastUpdate { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsensusThreadStatusVariant1" /> class.
        /// </summary>
        /// <param name="lastUpdate"></param>
        /// <param name="consensusThreadStatus"></param>
        public ConsensusThreadStatusVariant1(
            global::System.DateTime lastUpdate,
            global::G.ConsensusThreadStatusVariant1ConsensusThreadStatus consensusThreadStatus)
        {
            this.ConsensusThreadStatus = consensusThreadStatus;
            this.LastUpdate = lastUpdate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsensusThreadStatusVariant1" /> class.
        /// </summary>
        public ConsensusThreadStatusVariant1()
        {
        }
    }
}