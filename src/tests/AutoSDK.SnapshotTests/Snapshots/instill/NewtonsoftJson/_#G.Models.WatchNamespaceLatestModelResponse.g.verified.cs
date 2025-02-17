﻿//HintName: G.Models.WatchNamespaceLatestModelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// WatchNamespaceLatestModelResponse contains the state of the latest model version.
    /// </summary>
    public sealed partial class WatchNamespaceLatestModelResponse
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
        /// Initializes a new instance of the <see cref="WatchNamespaceLatestModelResponse" /> class.
        /// </summary>
        /// <param name="state">
        /// State.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="message">
        /// Included only in responses
        /// </param>
        public WatchNamespaceLatestModelResponse(
            global::G.State? state,
            string? message)
        {
            this.State = state;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatchNamespaceLatestModelResponse" /> class.
        /// </summary>
        public WatchNamespaceLatestModelResponse()
        {
        }
    }
}