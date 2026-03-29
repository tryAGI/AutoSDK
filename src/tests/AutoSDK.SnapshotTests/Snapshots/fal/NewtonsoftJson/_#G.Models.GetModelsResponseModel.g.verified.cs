//HintName: G.Models.GetModelsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model information with optional metadata and expandable fields
    /// </summary>
    public sealed partial class GetModelsResponseModel
    {
        /// <summary>
        /// Stable identifier used to call the model (e.g., 'fal-ai/wan/v2.2-a14b/text-to-video', 'fal-ai/minimax/video-01/image-to-video', 'fal-ai/hunyuan3d-v21')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoint_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EndpointId { get; set; } = default!;

        /// <summary>
        /// Model metadata (optional - may be absent for endpoints without registry entries)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.GetModelsResponseModelMetadata? Metadata { get; set; }

        /// <summary>
        /// OpenAPI 3.0 specification or error (present when expand=openapi-3.0 is requested)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("openapi")]
        public global::G.AnyOf<global::G.GetModelsResponseModelOpenapiVariant1, global::G.GetModelsResponseModelOpenapiVariant2>? Openapi { get; set; }

        /// <summary>
        /// Enterprise readiness status (present when expand=enterprise_status is requested)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enterprise_status")]
        public global::G.AnyOf<global::G.GetModelsResponseModelEnterpriseStatusEnum?, global::G.GetModelsResponseModelEnterpriseStatusEnum2>? EnterpriseStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseModel" /> class.
        /// </summary>
        /// <param name="endpointId">
        /// Stable identifier used to call the model (e.g., 'fal-ai/wan/v2.2-a14b/text-to-video', 'fal-ai/minimax/video-01/image-to-video', 'fal-ai/hunyuan3d-v21')
        /// </param>
        /// <param name="metadata">
        /// Model metadata (optional - may be absent for endpoints without registry entries)
        /// </param>
        /// <param name="openapi">
        /// OpenAPI 3.0 specification or error (present when expand=openapi-3.0 is requested)
        /// </param>
        /// <param name="enterpriseStatus">
        /// Enterprise readiness status (present when expand=enterprise_status is requested)
        /// </param>
        public GetModelsResponseModel(
            string endpointId,
            global::G.GetModelsResponseModelMetadata? metadata,
            global::G.AnyOf<global::G.GetModelsResponseModelOpenapiVariant1, global::G.GetModelsResponseModelOpenapiVariant2>? openapi,
            global::G.AnyOf<global::G.GetModelsResponseModelEnterpriseStatusEnum?, global::G.GetModelsResponseModelEnterpriseStatusEnum2>? enterpriseStatus)
        {
            this.EndpointId = endpointId ?? throw new global::System.ArgumentNullException(nameof(endpointId));
            this.Metadata = metadata;
            this.Openapi = openapi;
            this.EnterpriseStatus = enterpriseStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseModel" /> class.
        /// </summary>
        public GetModelsResponseModel()
        {
        }
    }
}