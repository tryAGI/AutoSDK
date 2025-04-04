﻿//HintName: G.Models.GetNamespaceLatestModelOperationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetNamespaceLatestModelOperationResponse represents a response to query a long-running<br/>
    /// operation.
    /// </summary>
    public sealed partial class GetNamespaceLatestModelOperationResponse
    {
        /// <summary>
        /// The long-running operation.<br/>
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
        /// Initializes a new instance of the <see cref="GetNamespaceLatestModelOperationResponse" /> class.
        /// </summary>
        /// <param name="operation">
        /// The long-running operation.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetNamespaceLatestModelOperationResponse(
            global::G.LongrunningOperation? operation)
        {
            this.Operation = operation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNamespaceLatestModelOperationResponse" /> class.
        /// </summary>
        public GetNamespaceLatestModelOperationResponse()
        {
        }
    }
}