//HintName: G.Models.LongrunningOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This resource represents a long-running operation that is the result of a<br/>
    /// network API call.
    /// </summary>
    public sealed partial class LongrunningOperation
    {
        /// <summary>
        /// The server-assigned name, which is only unique within the same service that<br/>
        /// originally returns it. If you use the default HTTP mapping, the<br/>
        /// `name` should be a resource name ending with `operations/{unique_id}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Service-specific metadata associated with the operation.  It typically<br/>
        /// contains progress information and common metadata such as create time.<br/>
        /// Some services might not provide such metadata.  Any method that returns a<br/>
        /// long-running operation should document the metadata type, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.Any? Metadata { get; set; }

        /// <summary>
        /// If the value is `false`, it means the operation is still in progress.<br/>
        /// If `true`, the operation is completed, and either `error` or `response` is<br/>
        /// available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("done")]
        public bool? Done { get; set; }

        /// <summary>
        /// The error result of the operation in case of failure or cancellation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::G.RpcStatus? Error { get; set; }

        /// <summary>
        /// The normal response of the operation in case of success.  If the original<br/>
        /// method returns no data on success, such as `Delete`, the response is<br/>
        /// `google.protobuf.Empty`.  If the original method is standard<br/>
        /// `Get`/`Create`/`Update`, the response should be the resource.  For other<br/>
        /// methods, the response should have the type `XxxResponse`, where `Xxx`<br/>
        /// is the original method name.  For example, if the original method name<br/>
        /// is `TakeSnapshot()`, the inferred response type is<br/>
        /// `TakeSnapshotResponse`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::G.Any? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LongrunningOperation" /> class.
        /// </summary>
        /// <param name="name">
        /// The server-assigned name, which is only unique within the same service that<br/>
        /// originally returns it. If you use the default HTTP mapping, the<br/>
        /// `name` should be a resource name ending with `operations/{unique_id}`.
        /// </param>
        /// <param name="metadata">
        /// Service-specific metadata associated with the operation.  It typically<br/>
        /// contains progress information and common metadata such as create time.<br/>
        /// Some services might not provide such metadata.  Any method that returns a<br/>
        /// long-running operation should document the metadata type, if any.
        /// </param>
        /// <param name="done">
        /// If the value is `false`, it means the operation is still in progress.<br/>
        /// If `true`, the operation is completed, and either `error` or `response` is<br/>
        /// available.
        /// </param>
        /// <param name="error">
        /// The error result of the operation in case of failure or cancellation.
        /// </param>
        /// <param name="response">
        /// The normal response of the operation in case of success.  If the original<br/>
        /// method returns no data on success, such as `Delete`, the response is<br/>
        /// `google.protobuf.Empty`.  If the original method is standard<br/>
        /// `Get`/`Create`/`Update`, the response should be the resource.  For other<br/>
        /// methods, the response should have the type `XxxResponse`, where `Xxx`<br/>
        /// is the original method name.  For example, if the original method name<br/>
        /// is `TakeSnapshot()`, the inferred response type is<br/>
        /// `TakeSnapshotResponse`.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public LongrunningOperation(
            string? name,
            global::G.Any? metadata,
            bool? done,
            global::G.RpcStatus? error,
            global::G.Any? response)
        {
            this.Name = name;
            this.Metadata = metadata;
            this.Done = done;
            this.Error = error;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LongrunningOperation" /> class.
        /// </summary>
        public LongrunningOperation()
        {
        }
    }
}