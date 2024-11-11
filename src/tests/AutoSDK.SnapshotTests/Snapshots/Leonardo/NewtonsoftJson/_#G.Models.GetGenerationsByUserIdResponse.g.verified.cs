//HintName: G.Models.GetGenerationsByUserIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetGenerationsByUserIdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generations")]
        public global::System.Collections.Generic.IList<global::G.GetGenerationsByUserIdResponseGeneration>? Generations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationsByUserIdResponse" /> class.
        /// </summary>
        /// <param name="generations"></param>
        public GetGenerationsByUserIdResponse(
            global::System.Collections.Generic.IList<global::G.GetGenerationsByUserIdResponseGeneration>? generations)
        {
            this.Generations = generations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationsByUserIdResponse" /> class.
        /// </summary>
        public GetGenerationsByUserIdResponse()
        {
        }
    }
}