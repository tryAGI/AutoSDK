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
        [global::System.Text.Json.Serialization.JsonPropertyName("move_shard")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MoveShard MoveShard { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveShardOperation" /> class.
        /// </summary>
        /// <param name="moveShard"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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