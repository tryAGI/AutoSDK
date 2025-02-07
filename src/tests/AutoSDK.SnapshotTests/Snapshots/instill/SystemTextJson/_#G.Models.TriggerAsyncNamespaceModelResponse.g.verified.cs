//HintName: G.Models.TriggerAsyncNamespaceModelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// TriggerAsyncNamespaceModelResponse contains the information to access the<br/>
    /// status of an asynchronous model inference.
    /// </summary>
    public sealed partial class TriggerAsyncNamespaceModelResponse
    {
        /// <summary>
        /// Long-running operation information.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        public global::G.LongrunningOperation? Operation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerAsyncNamespaceModelResponse" /> class.
        /// </summary>
        /// <param name="operation">
        /// Long-running operation information.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerAsyncNamespaceModelResponse(
            global::G.LongrunningOperation? operation)
        {
            this.Operation = operation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerAsyncNamespaceModelResponse" /> class.
        /// </summary>
        public TriggerAsyncNamespaceModelResponse()
        {
        }
    }
}