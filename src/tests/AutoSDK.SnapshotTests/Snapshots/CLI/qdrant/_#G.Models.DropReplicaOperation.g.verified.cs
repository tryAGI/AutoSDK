//HintName: G.Models.DropReplicaOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DropReplicaOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drop_replica")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Replica DropReplica { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DropReplicaOperation" /> class.
        /// </summary>
        /// <param name="dropReplica"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DropReplicaOperation(
            global::G.Replica dropReplica)
        {
            this.DropReplica = dropReplica ?? throw new global::System.ArgumentNullException(nameof(dropReplica));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DropReplicaOperation" /> class.
        /// </summary>
        public DropReplicaOperation()
        {
        }
    }
}