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
        [global::Newtonsoft.Json.JsonProperty("drop_replica", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Replica DropReplica { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DropReplicaOperation" /> class.
        /// </summary>
        /// <param name="dropReplica"></param>
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