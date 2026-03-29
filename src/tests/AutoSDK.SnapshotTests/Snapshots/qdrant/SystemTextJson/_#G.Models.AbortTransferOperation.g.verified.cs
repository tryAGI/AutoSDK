//HintName: G.Models.AbortTransferOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AbortTransferOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("abort_transfer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AbortShardTransfer AbortTransfer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AbortTransferOperation" /> class.
        /// </summary>
        /// <param name="abortTransfer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AbortTransferOperation(
            global::G.AbortShardTransfer abortTransfer)
        {
            this.AbortTransfer = abortTransfer ?? throw new global::System.ArgumentNullException(nameof(abortTransfer));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbortTransferOperation" /> class.
        /// </summary>
        public AbortTransferOperation()
        {
        }
    }
}