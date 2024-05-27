//HintName: G.Models.UpdateConduitShardsBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateConduitShardsBody
    {
        /// <summary>
        /// Conduit ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conduit_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConduitId { get; set; } = default!;

        /// <summary>
        /// List of shards to update.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shards", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<UpdateConduitShardsBodyShards> Shards { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}