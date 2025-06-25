//HintName: G.Models.RaftStatistics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The definition of Raft statistics.
    /// </summary>
    public sealed partial class RaftStatistics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appliedIndex")]
        public string? AppliedIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitIndex")]
        public string? CommitIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fsmPending")]
        public string? FsmPending { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastContact")]
        public string? LastContact { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastLogIndex")]
        public string? LastLogIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastLogTerm")]
        public string? LastLogTerm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastSnapshotIndex")]
        public string? LastSnapshotIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastSnapshotTerm")]
        public string? LastSnapshotTerm { get; set; }

        /// <summary>
        /// Weaviate Raft nodes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestConfiguration")]
        public object? LatestConfiguration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestConfigurationIndex")]
        public string? LatestConfigurationIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numPeers")]
        public string? NumPeers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocolVersion")]
        public string? ProtocolVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocolVersionMax")]
        public string? ProtocolVersionMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocolVersionMin")]
        public string? ProtocolVersionMin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshotVersionMax")]
        public string? SnapshotVersionMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshotVersionMin")]
        public string? SnapshotVersionMin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("term")]
        public string? Term { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RaftStatistics" /> class.
        /// </summary>
        /// <param name="appliedIndex"></param>
        /// <param name="commitIndex"></param>
        /// <param name="fsmPending"></param>
        /// <param name="lastContact"></param>
        /// <param name="lastLogIndex"></param>
        /// <param name="lastLogTerm"></param>
        /// <param name="lastSnapshotIndex"></param>
        /// <param name="lastSnapshotTerm"></param>
        /// <param name="latestConfiguration">
        /// Weaviate Raft nodes.
        /// </param>
        /// <param name="latestConfigurationIndex"></param>
        /// <param name="numPeers"></param>
        /// <param name="protocolVersion"></param>
        /// <param name="protocolVersionMax"></param>
        /// <param name="protocolVersionMin"></param>
        /// <param name="snapshotVersionMax"></param>
        /// <param name="snapshotVersionMin"></param>
        /// <param name="state"></param>
        /// <param name="term"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RaftStatistics(
            string? appliedIndex,
            string? commitIndex,
            string? fsmPending,
            string? lastContact,
            string? lastLogIndex,
            string? lastLogTerm,
            string? lastSnapshotIndex,
            string? lastSnapshotTerm,
            object? latestConfiguration,
            string? latestConfigurationIndex,
            string? numPeers,
            string? protocolVersion,
            string? protocolVersionMax,
            string? protocolVersionMin,
            string? snapshotVersionMax,
            string? snapshotVersionMin,
            string? state,
            string? term)
        {
            this.AppliedIndex = appliedIndex;
            this.CommitIndex = commitIndex;
            this.FsmPending = fsmPending;
            this.LastContact = lastContact;
            this.LastLogIndex = lastLogIndex;
            this.LastLogTerm = lastLogTerm;
            this.LastSnapshotIndex = lastSnapshotIndex;
            this.LastSnapshotTerm = lastSnapshotTerm;
            this.LatestConfiguration = latestConfiguration;
            this.LatestConfigurationIndex = latestConfigurationIndex;
            this.NumPeers = numPeers;
            this.ProtocolVersion = protocolVersion;
            this.ProtocolVersionMax = protocolVersionMax;
            this.ProtocolVersionMin = protocolVersionMin;
            this.SnapshotVersionMax = snapshotVersionMax;
            this.SnapshotVersionMin = snapshotVersionMin;
            this.State = state;
            this.Term = term;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RaftStatistics" /> class.
        /// </summary>
        public RaftStatistics()
        {
        }
    }
}