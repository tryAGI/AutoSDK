//HintName: G.Models.PipelinePublicServiceTriggerNamespacePipelineWithStreamResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinePublicServiceTriggerNamespacePipelineWithStreamResponse
    {
        /// <summary>
        /// TriggerNamespacePipelineWithStreamResponse contains the pipeline execution results, i.e.,<br/>
        /// the multiple model inference outputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::G.TriggerNamespacePipelineWithStreamResponse? Result { get; set; }

        /// <summary>
        /// The `Status` type defines a logical error model that is suitable for<br/>
        /// different programming environments, including REST APIs and RPC APIs. It is<br/>
        /// used by [gRPC](https://github.com/grpc). Each `Status` message contains<br/>
        /// three pieces of data: error code, error message, and error details.<br/>
        /// You can find out more about this error model and how to work with it in the<br/>
        /// [API Design Guide](https://cloud.google.com/apis/design/errors).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::G.RpcStatus? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinePublicServiceTriggerNamespacePipelineWithStreamResponse" /> class.
        /// </summary>
        /// <param name="result">
        /// TriggerNamespacePipelineWithStreamResponse contains the pipeline execution results, i.e.,<br/>
        /// the multiple model inference outputs.
        /// </param>
        /// <param name="error">
        /// The `Status` type defines a logical error model that is suitable for<br/>
        /// different programming environments, including REST APIs and RPC APIs. It is<br/>
        /// used by [gRPC](https://github.com/grpc). Each `Status` message contains<br/>
        /// three pieces of data: error code, error message, and error details.<br/>
        /// You can find out more about this error model and how to work with it in the<br/>
        /// [API Design Guide](https://cloud.google.com/apis/design/errors).
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PipelinePublicServiceTriggerNamespacePipelineWithStreamResponse(
            global::G.TriggerNamespacePipelineWithStreamResponse? result,
            global::G.RpcStatus? error)
        {
            this.Result = result;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinePublicServiceTriggerNamespacePipelineWithStreamResponse" /> class.
        /// </summary>
        public PipelinePublicServiceTriggerNamespacePipelineWithStreamResponse()
        {
        }
    }
}