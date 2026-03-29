//HintName: G.Models.RenameReplicaRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RenameReplicaRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replica_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReplicaName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameReplicaRequest" /> class.
        /// </summary>
        /// <param name="replicaName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RenameReplicaRequest(
            string replicaName)
        {
            this.ReplicaName = replicaName ?? throw new global::System.ArgumentNullException(nameof(replicaName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameReplicaRequest" /> class.
        /// </summary>
        public RenameReplicaRequest()
        {
        }
    }
}