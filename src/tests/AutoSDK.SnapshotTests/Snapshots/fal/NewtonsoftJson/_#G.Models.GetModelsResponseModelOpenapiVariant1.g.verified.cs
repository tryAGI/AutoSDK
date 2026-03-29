//HintName: G.Models.GetModelsResponseModelOpenapiVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OpenAPI 3.0 specification for the model
    /// </summary>
    public sealed partial class GetModelsResponseModelOpenapiVariant1
    {
        /// <summary>
        /// OpenAPI version (e.g., '3.0.4')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("openapi", Required = global::Newtonsoft.Json.Required.Always)]
        public string Openapi { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseModelOpenapiVariant1" /> class.
        /// </summary>
        /// <param name="openapi">
        /// OpenAPI version (e.g., '3.0.4')
        /// </param>
        public GetModelsResponseModelOpenapiVariant1(
            string openapi)
        {
            this.Openapi = openapi ?? throw new global::System.ArgumentNullException(nameof(openapi));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseModelOpenapiVariant1" /> class.
        /// </summary>
        public GetModelsResponseModelOpenapiVariant1()
        {
        }
    }
}