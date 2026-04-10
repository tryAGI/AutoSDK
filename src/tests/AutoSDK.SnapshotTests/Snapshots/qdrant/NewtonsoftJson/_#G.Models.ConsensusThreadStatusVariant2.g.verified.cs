//HintName: G.Models.ConsensusThreadStatusVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConsensusThreadStatusVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("consensus_thread_status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConsensusThreadStatusVariant2ConsensusThreadStatusJsonConverter))]
        public global::G.ConsensusThreadStatusVariant2ConsensusThreadStatus ConsensusThreadStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsensusThreadStatusVariant2" /> class.
        /// </summary>
        /// <param name="consensusThreadStatus"></param>
        public ConsensusThreadStatusVariant2(
            global::G.ConsensusThreadStatusVariant2ConsensusThreadStatus consensusThreadStatus)
        {
            this.ConsensusThreadStatus = consensusThreadStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsensusThreadStatusVariant2" /> class.
        /// </summary>
        public ConsensusThreadStatusVariant2()
        {
        }
    }
}