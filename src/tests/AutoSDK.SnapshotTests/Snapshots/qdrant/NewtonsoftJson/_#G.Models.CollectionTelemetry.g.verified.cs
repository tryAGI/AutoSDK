//HintName: G.Models.CollectionTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CollectionTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("init_time_ms")]
        public int? InitTimeMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.CollectionConfigTelemetry? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shards")]
        public global::System.Collections.Generic.IList<global::G.ReplicaSetTelemetry>? Shards { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transfers")]
        public global::System.Collections.Generic.IList<global::G.ShardTransferInfo>? Transfers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resharding")]
        public global::System.Collections.Generic.IList<global::G.ReshardingInfo>? Resharding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_clean_tasks")]
        public object? ShardCleanTasks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionTelemetry" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="initTimeMs"></param>
        /// <param name="config"></param>
        /// <param name="shards"></param>
        /// <param name="transfers"></param>
        /// <param name="resharding"></param>
        /// <param name="shardCleanTasks"></param>
        public CollectionTelemetry(
            string id,
            int? initTimeMs,
            global::G.CollectionConfigTelemetry? config,
            global::System.Collections.Generic.IList<global::G.ReplicaSetTelemetry>? shards,
            global::System.Collections.Generic.IList<global::G.ShardTransferInfo>? transfers,
            global::System.Collections.Generic.IList<global::G.ReshardingInfo>? resharding,
            object? shardCleanTasks)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.InitTimeMs = initTimeMs;
            this.Config = config;
            this.Shards = shards;
            this.Transfers = transfers;
            this.Resharding = resharding;
            this.ShardCleanTasks = shardCleanTasks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionTelemetry" /> class.
        /// </summary>
        public CollectionTelemetry()
        {
        }
    }
}