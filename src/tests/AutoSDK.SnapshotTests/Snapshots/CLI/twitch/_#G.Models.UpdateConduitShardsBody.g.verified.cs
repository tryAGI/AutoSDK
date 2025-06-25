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
        [global::System.Text.Json.Serialization.JsonPropertyName("conduit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConduitId { get; set; }

        /// <summary>
        /// List of shards to update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shards")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.UpdateConduitShardsBodyShard> Shards { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConduitShardsBody" /> class.
        /// </summary>
        /// <param name="conduitId">
        /// Conduit ID.
        /// </param>
        /// <param name="shards">
        /// List of shards to update.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateConduitShardsBody(
            string conduitId,
            global::System.Collections.Generic.IList<global::G.UpdateConduitShardsBodyShard> shards)
        {
            this.ConduitId = conduitId ?? throw new global::System.ArgumentNullException(nameof(conduitId));
            this.Shards = shards ?? throw new global::System.ArgumentNullException(nameof(shards));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConduitShardsBody" /> class.
        /// </summary>
        public UpdateConduitShardsBody()
        {
        }
    }
}