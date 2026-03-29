//HintName: G.Models.ServerlessGetAppQueueInfoResponse5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Standard error response format
    /// </summary>
    public sealed partial class ServerlessGetAppQueueInfoResponse5
    {
        /// <summary>
        /// Error details
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ServerlessGetAppQueueInfoResponseError4 Error { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessGetAppQueueInfoResponse5" /> class.
        /// </summary>
        /// <param name="error">
        /// Error details
        /// </param>
        public ServerlessGetAppQueueInfoResponse5(
            global::G.ServerlessGetAppQueueInfoResponseError4 error)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessGetAppQueueInfoResponse5" /> class.
        /// </summary>
        public ServerlessGetAppQueueInfoResponse5()
        {
        }
    }
}