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
        [global::Newtonsoft.Json.JsonProperty("restart_transfer", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RestartTransfer RestartTransfer { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RestartTransferOperation" /> class.
        /// </summary>
        /// <param name="restartTransfer"></param>
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