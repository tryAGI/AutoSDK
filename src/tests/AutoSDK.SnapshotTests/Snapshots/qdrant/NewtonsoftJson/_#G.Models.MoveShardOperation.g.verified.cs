//HintName: G.Models.MoveShardOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MoveShardOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("move_shard", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MoveShard MoveShard { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveShardOperation" /> class.
        /// </summary>
        /// <param name="moveShard"></param>
        public MoveShardOperation(
            global::G.MoveShard moveShard)
        {
            this.MoveShard = moveShard ?? throw new global::System.ArgumentNullException(nameof(moveShard));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveShardOperation" /> class.
        /// </summary>
        public MoveShardOperation()
        {
        }
    }
}