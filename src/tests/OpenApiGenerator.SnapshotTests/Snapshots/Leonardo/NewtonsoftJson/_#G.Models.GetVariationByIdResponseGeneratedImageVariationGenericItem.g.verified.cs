//HintName: G.Models.GetVariationByIdResponseGeneratedImageVariationGenericItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// columns and relationships of "generated_image_variation_generic"
    /// </summary>
    public sealed partial class GetVariationByIdResponseGeneratedImageVariationGenericItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The status of the current task.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.JobStatus? Status { get; set; }

        /// <summary>
        /// The type of variation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transformType")]
        public global::G.VARIATIONTYPE? TransformType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}