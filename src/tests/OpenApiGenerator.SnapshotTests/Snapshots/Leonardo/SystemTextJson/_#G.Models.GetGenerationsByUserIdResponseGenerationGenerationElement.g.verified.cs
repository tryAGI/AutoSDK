//HintName: G.Models.GetGenerationsByUserIdResponseGenerationGenerationElement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This table captures the elements that are applied to a Generations, also the order and weightings used when applied.
    /// </summary>
    public sealed partial class GetGenerationsByUserIdResponseGenerationGenerationElement
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Element used for the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora")]
        public global::G.GetGenerationsByUserIdResponseGenerationGenerationElementLora? Lora { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weightApplied")]
        public double? WeightApplied { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}