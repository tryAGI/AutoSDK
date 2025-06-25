﻿//HintName: G.Models.Statistics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The definition of node statistics.
    /// </summary>
    public sealed partial class Statistics
    {
        /// <summary>
        /// The name of the node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Node's status.<br/>
        /// Default Value: HEALTHY
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StatisticsStatusJsonConverter))]
        public global::G.StatisticsStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bootstrapped")]
        public bool? Bootstrapped { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbLoaded")]
        public bool? DbLoaded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initialLastAppliedIndex")]
        public double? InitialLastAppliedIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastAppliedIndex")]
        public double? LastAppliedIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isVoter")]
        public bool? IsVoter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leaderId")]
        public object? LeaderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leaderAddress")]
        public object? LeaderAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("open")]
        public bool? Open { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ready")]
        public bool? Ready { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("candidates")]
        public object? Candidates { get; set; }

        /// <summary>
        /// The definition of Raft statistics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raft")]
        public global::G.RaftStatistics? Raft { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Statistics" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the node.
        /// </param>
        /// <param name="status">
        /// Node's status.<br/>
        /// Default Value: HEALTHY
        /// </param>
        /// <param name="bootstrapped"></param>
        /// <param name="dbLoaded"></param>
        /// <param name="initialLastAppliedIndex"></param>
        /// <param name="lastAppliedIndex"></param>
        /// <param name="isVoter"></param>
        /// <param name="leaderId"></param>
        /// <param name="leaderAddress"></param>
        /// <param name="open"></param>
        /// <param name="ready"></param>
        /// <param name="candidates"></param>
        /// <param name="raft">
        /// The definition of Raft statistics.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Statistics(
            string? name,
            global::G.StatisticsStatus? status,
            bool? bootstrapped,
            bool? dbLoaded,
            double? initialLastAppliedIndex,
            double? lastAppliedIndex,
            bool? isVoter,
            object? leaderId,
            object? leaderAddress,
            bool? open,
            bool? ready,
            object? candidates,
            global::G.RaftStatistics? raft)
        {
            this.Name = name;
            this.Status = status;
            this.Bootstrapped = bootstrapped;
            this.DbLoaded = dbLoaded;
            this.InitialLastAppliedIndex = initialLastAppliedIndex;
            this.LastAppliedIndex = lastAppliedIndex;
            this.IsVoter = isVoter;
            this.LeaderId = leaderId;
            this.LeaderAddress = leaderAddress;
            this.Open = open;
            this.Ready = ready;
            this.Candidates = candidates;
            this.Raft = raft;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Statistics" /> class.
        /// </summary>
        public Statistics()
        {
        }
    }
}