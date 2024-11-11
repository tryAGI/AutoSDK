//HintName: G.Models.WatchNamespaceModelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// WatchNamespaceModelResponse contains the state of a model.
    /// </summary>
    public sealed partial class WatchNamespaceModelResponse
    {
        /// <summary>
        /// State.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.State? State { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WatchNamespaceModelResponse" /> class.
        /// </summary>
        /// <param name="state">
        /// State.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="message">
        /// Included only in responses
        /// </param>
        public WatchNamespaceModelResponse(
            global::G.State? state,
            string? message)
        {
            this.State = state;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatchNamespaceModelResponse" /> class.
        /// </summary>
        public WatchNamespaceModelResponse()
        {
        }
    }
}