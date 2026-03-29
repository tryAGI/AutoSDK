//HintName: G.Models.ConsensusThreadStatusVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConsensusThreadStatusVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("consensus_thread_status")]
        public global::G.ConsensusThreadStatusVariant3ConsensusThreadStatus ConsensusThreadStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("err", Required = global::Newtonsoft.Json.Required.Always)]
        public string Err { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsensusThreadStatusVariant3" /> class.
        /// </summary>
        /// <param name="err"></param>
        /// <param name="consensusThreadStatus"></param>
        public ConsensusThreadStatusVariant3(
            string err,
            global::G.ConsensusThreadStatusVariant3ConsensusThreadStatus consensusThreadStatus)
        {
            this.ConsensusThreadStatus = consensusThreadStatus;
            this.Err = err ?? throw new global::System.ArgumentNullException(nameof(err));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsensusThreadStatusVariant3" /> class.
        /// </summary>
        public ConsensusThreadStatusVariant3()
        {
        }
    }
}