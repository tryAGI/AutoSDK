//HintName: G.Models.RestartTransferOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RestartTransferOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restart_transfer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RestartTransfer RestartTransfer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RestartTransferOperation" /> class.
        /// </summary>
        /// <param name="restartTransfer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RestartTransferOperation(
            global::G.RestartTransfer restartTransfer)
        {
            this.RestartTransfer = restartTransfer ?? throw new global::System.ArgumentNullException(nameof(restartTransfer));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestartTransferOperation" /> class.
        /// </summary>
        public RestartTransferOperation()
        {
        }
    }
}