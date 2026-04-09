//HintName: G.Models.PipelinesUpdatePipelineProducerConfigResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesUpdatePipelineProducerConfigResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errorCode", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PipelinesUpdatePipelineProducerConfigResponseErrorCodeJsonConverter))]
        public global::G.PipelinesUpdatePipelineProducerConfigResponseErrorCode ErrorCode { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesUpdatePipelineProducerConfigResponse2" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorCode"></param>
        public PipelinesUpdatePipelineProducerConfigResponse2(
            string message,
            global::G.PipelinesUpdatePipelineProducerConfigResponseErrorCode errorCode)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesUpdatePipelineProducerConfigResponse2" /> class.
        /// </summary>
        public PipelinesUpdatePipelineProducerConfigResponse2()
        {
        }
    }
}