//HintName: G.Models.PipelinesSyncPipelineResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesSyncPipelineResponse3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errorCode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PipelinesSyncPipelineResponseErrorCode2JsonConverter))]
        public global::G.PipelinesSyncPipelineResponseErrorCode2 ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesSyncPipelineResponse3" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorCode"></param>
        public PipelinesSyncPipelineResponse3(
            string message,
            global::G.PipelinesSyncPipelineResponseErrorCode2 errorCode)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesSyncPipelineResponse3" /> class.
        /// </summary>
        public PipelinesSyncPipelineResponse3()
        {
        }
    }
}