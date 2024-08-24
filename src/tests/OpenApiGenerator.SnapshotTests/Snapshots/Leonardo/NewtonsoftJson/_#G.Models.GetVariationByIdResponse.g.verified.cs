//HintName: G.Models.GetVariationByIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetVariationByIdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generated_image_variation_generic")]
        public global::System.Collections.Generic.IList<global::G.GetVariationByIdResponseGeneratedImageVariationGenericItem>? GeneratedImageVariationGeneric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}