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
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Element used for the generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lora")]
        public global::G.GetGenerationsByUserIdResponseGenerationGenerationElementLora? Lora { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationsByUserIdResponseGenerationGenerationElement" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="lora">
        /// Element used for the generation.
        /// </param>
        /// <param name="weightApplied"></param>
        public GetGenerationsByUserIdResponseGenerationGenerationElement(
            int? id,
            global::G.GetGenerationsByUserIdResponseGenerationGenerationElementLora? lora,
            double? weightApplied)
        {
            this.Id = id;
            this.Lora = lora;
            this.WeightApplied = weightApplied;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationsByUserIdResponseGenerationGenerationElement" /> class.
        /// </summary>
        public GetGenerationsByUserIdResponseGenerationGenerationElement()
        {
        }
    }
}