//HintName: G.Models.Statistics.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Node's status.<br/>
        /// Default Value: HEALTHY
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.StatisticsStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bootstrapped")]
        public bool? Bootstrapped { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dbLoaded")]
        public bool? DbLoaded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initialLastAppliedIndex")]
        public double? InitialLastAppliedIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastAppliedIndex")]
        public double? LastAppliedIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isVoter")]
        public bool? IsVoter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("leaderId")]
        public object? LeaderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("leaderAddress")]
        public object? LeaderAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("open")]
        public bool? Open { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ready")]
        public bool? Ready { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("candidates")]
        public object? Candidates { get; set; }

        /// <summary>
        /// The definition of Raft statistics.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("raft")]
        public global::G.RaftStatistics? Raft { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public static global::G.Statistics? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Statistics>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.Statistics?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.Statistics?>(serializer.Deserialize<global::G.Statistics>(jsonReader));
        }

    }
}