//HintName: G.Models.ServerlessFlushAppQueueResponse4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Standard error response format
    /// </summary>
    public sealed partial class ServerlessFlushAppQueueResponse4
    {
        /// <summary>
        /// Error details
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ServerlessFlushAppQueueResponseError4 Error { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessFlushAppQueueResponse4" /> class.
        /// </summary>
        /// <param name="error">
        /// Error details
        /// </param>
        public ServerlessFlushAppQueueResponse4(
            global::G.ServerlessFlushAppQueueResponseError4 error)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessFlushAppQueueResponse4" /> class.
        /// </summary>
        public ServerlessFlushAppQueueResponse4()
        {
        }
    }
}