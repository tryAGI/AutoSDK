//HintName: G.Models.PricingCalculatorRequestServiceParamsLCMGENERATION.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for LCM_GENERATION service
    /// </summary>
    public sealed partial class PricingCalculatorRequestServiceParamsLCMGENERATION
    {
        /// <summary>
        /// The output height of the image. Must be 512, 640 or 1024.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// The output width of the image. Must be 512, 640 or 1024.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Enable for instant upscale
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instantRefine")]
        public bool? InstantRefine { get; set; }

        /// <summary>
        /// Enable for normal alchemy upscale
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refine")]
        public bool? Refine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}