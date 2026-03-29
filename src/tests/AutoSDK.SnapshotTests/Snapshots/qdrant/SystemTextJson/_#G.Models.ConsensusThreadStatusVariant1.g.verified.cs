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
        [global::System.Text.Json.Serialization.JsonPropertyName("consensus_thread_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConsensusThreadStatusVariant1ConsensusThreadStatusJsonConverter))]
        public global::G.ConsensusThreadStatusVariant1ConsensusThreadStatus ConsensusThreadStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_update")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastUpdate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsensusThreadStatusVariant1" /> class.
        /// </summary>
        /// <param name="lastUpdate"></param>
        /// <param name="consensusThreadStatus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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