//HintName: G.Models.GetGenerationByIdResponseGenerationsByPkGenerationElement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This table captures the elements that are applied to Generations.
    /// </summary>
    public sealed partial class GetGenerationByIdResponseGenerationsByPkGenerationElement
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Element used for the generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lora")]
        public global::G.GetGenerationByIdResponseGenerationsByPkGenerationElementLora? Lora { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weightApplied")]
        public double? WeightApplied { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}