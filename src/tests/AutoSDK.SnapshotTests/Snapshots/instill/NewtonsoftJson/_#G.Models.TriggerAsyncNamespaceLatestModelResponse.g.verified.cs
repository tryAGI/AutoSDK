﻿//HintName: G.Models.TriggerAsyncNamespaceLatestModelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// TriggerAsyncNamespaceLatestModelResponse contains the information to access the<br/>
    /// status of an asynchronous model inference.
    /// </summary>
    public sealed partial class TriggerAsyncNamespaceLatestModelResponse
    {
        /// <summary>
        /// Long-running operation information.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operation")]
        public global::G.LongrunningOperation? Operation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerAsyncNamespaceLatestModelResponse" /> class.
        /// </summary>
        /// <param name="operation">
        /// Long-running operation information.<br/>
        /// Included only in responses
        /// </param>
        public TriggerAsyncNamespaceLatestModelResponse(
            global::G.LongrunningOperation? operation)
        {
            this.Operation = operation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerAsyncNamespaceLatestModelResponse" /> class.
        /// </summary>
        public TriggerAsyncNamespaceLatestModelResponse()
        {
        }
    }
}