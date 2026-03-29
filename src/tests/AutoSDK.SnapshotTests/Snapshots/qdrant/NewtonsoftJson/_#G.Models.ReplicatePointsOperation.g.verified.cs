//HintName: G.Models.ReplicatePointsOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReplicatePointsOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("replicate_points", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ReplicatePoints ReplicatePoints { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicatePointsOperation" /> class.
        /// </summary>
        /// <param name="replicatePoints"></param>
        public ReplicatePointsOperation(
            global::G.ReplicatePoints replicatePoints)
        {
            this.ReplicatePoints = replicatePoints ?? throw new global::System.ArgumentNullException(nameof(replicatePoints));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicatePointsOperation" /> class.
        /// </summary>
        public ReplicatePointsOperation()
        {
        }
    }
}