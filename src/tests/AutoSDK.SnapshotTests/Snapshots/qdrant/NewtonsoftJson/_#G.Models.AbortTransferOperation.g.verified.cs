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
        [global::Newtonsoft.Json.JsonProperty("abort_transfer", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AbortShardTransfer AbortTransfer { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AbortTransferOperation" /> class.
        /// </summary>
        /// <param name="abortTransfer"></param>
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