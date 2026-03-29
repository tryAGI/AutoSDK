//HintName: G.Models.GetModelsResponseModelOpenapiVariant2Error.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error details for failed OpenAPI expansion
    /// </summary>
    public sealed partial class GetModelsResponseModelOpenapiVariant2Error
    {
        /// <summary>
        /// Error code (e.g., 'expansion_failed')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Human-readable error message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseModelOpenapiVariant2Error" /> class.
        /// </summary>
        /// <param name="code">
        /// Error code (e.g., 'expansion_failed')
        /// </param>
        /// <param name="message">
        /// Human-readable error message
        /// </param>
        public GetModelsResponseModelOpenapiVariant2Error(
            string code,
            string message)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseModelOpenapiVariant2Error" /> class.
        /// </summary>
        public GetModelsResponseModelOpenapiVariant2Error()
        {
        }
    }
}