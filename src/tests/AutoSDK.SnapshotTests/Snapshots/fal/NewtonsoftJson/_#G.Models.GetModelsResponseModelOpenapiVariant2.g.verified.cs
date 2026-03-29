//HintName: G.Models.GetModelsResponseModelOpenapiVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error encountered while expanding OpenAPI schema
    /// </summary>
    public sealed partial class GetModelsResponseModelOpenapiVariant2
    {
        /// <summary>
        /// Error details for failed OpenAPI expansion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetModelsResponseModelOpenapiVariant2Error Error { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseModelOpenapiVariant2" /> class.
        /// </summary>
        /// <param name="error">
        /// Error details for failed OpenAPI expansion
        /// </param>
        public GetModelsResponseModelOpenapiVariant2(
            global::G.GetModelsResponseModelOpenapiVariant2Error error)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseModelOpenapiVariant2" /> class.
        /// </summary>
        public GetModelsResponseModelOpenapiVariant2()
        {
        }
    }
}