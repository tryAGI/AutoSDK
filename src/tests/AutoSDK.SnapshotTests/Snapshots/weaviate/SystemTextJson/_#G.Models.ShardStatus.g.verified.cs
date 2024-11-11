//HintName: G.Models.ShardStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of a single shard
    /// </summary>
    public sealed partial class ShardStatus
    {
        /// <summary>
        /// Status of the shard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardStatus" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the shard
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ShardStatus(
            string? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardStatus" /> class.
        /// </summary>
        public ShardStatus()
        {
        }
    }
}