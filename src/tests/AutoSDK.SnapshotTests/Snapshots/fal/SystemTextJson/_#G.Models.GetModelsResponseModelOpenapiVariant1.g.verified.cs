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
        [global::System.Text.Json.Serialization.JsonPropertyName("openapi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Openapi { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseModelOpenapiVariant1" /> class.
        /// </summary>
        /// <param name="openapi">
        /// OpenAPI version (e.g., '3.0.4')
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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