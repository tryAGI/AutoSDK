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
        [global::Newtonsoft.Json.JsonProperty("replica_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReplicaName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameReplicaRequest" /> class.
        /// </summary>
        /// <param name="replicaName"></param>
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