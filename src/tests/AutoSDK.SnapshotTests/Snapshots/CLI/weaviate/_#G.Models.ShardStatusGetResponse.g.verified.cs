﻿//HintName: G.Models.ShardStatusGetResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response body of shard status get request
    /// </summary>
    public sealed partial class ShardStatusGetResponse
    {
        /// <summary>
        /// Name of the shard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Status of the shard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Size of the vector queue of the shard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorQueueSize")]
        public int? VectorQueueSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardStatusGetResponse" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the shard
        /// </param>
        /// <param name="status">
        /// Status of the shard
        /// </param>
        /// <param name="vectorQueueSize">
        /// Size of the vector queue of the shard
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShardStatusGetResponse(
            string? name,
            string? status,
            int? vectorQueueSize)
        {
            this.Name = name;
            this.Status = status;
            this.VectorQueueSize = vectorQueueSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardStatusGetResponse" /> class.
        /// </summary>
        public ShardStatusGetResponse()
        {
        }
    }
}