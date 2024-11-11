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
        [global::Newtonsoft.Json.JsonProperty("appliedIndex")]
        public string? AppliedIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commitIndex")]
        public string? CommitIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fsmPending")]
        public string? FsmPending { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastContact")]
        public string? LastContact { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastLogIndex")]
        public string? LastLogIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastLogTerm")]
        public string? LastLogTerm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastSnapshotIndex")]
        public string? LastSnapshotIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastSnapshotTerm")]
        public string? LastSnapshotTerm { get; set; }

        /// <summary>
        /// Weaviate Raft nodes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latestConfiguration")]
        public object? LatestConfiguration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latestConfigurationIndex")]
        public string? LatestConfigurationIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numPeers")]
        public string? NumPeers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("protocolVersion")]
        public string? ProtocolVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("protocolVersionMax")]
        public string? ProtocolVersionMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("protocolVersionMin")]
        public string? ProtocolVersionMin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("snapshotVersionMax")]
        public string? SnapshotVersionMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("snapshotVersionMin")]
        public string? SnapshotVersionMin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public string? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("term")]
        public string? Term { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.RaftStatistics? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RaftStatistics>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.RaftStatistics?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.RaftStatistics?>(serializer.Deserialize<global::G.RaftStatistics>(jsonReader));
        }

    }
}