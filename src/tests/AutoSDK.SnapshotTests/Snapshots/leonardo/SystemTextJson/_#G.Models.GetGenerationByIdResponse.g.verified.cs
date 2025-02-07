//HintName: G.Models.GetGenerationByIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetGenerationByIdResponse
    {
        /// <summary>
        /// columns and relationships of "generations"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generations_by_pk")]
        public global::G.GetGenerationByIdResponseGenerationsByPk? GenerationsByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationByIdResponse" /> class.
        /// </summary>
        /// <param name="generationsByPk">
        /// columns and relationships of "generations"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetGenerationByIdResponse(
            global::G.GetGenerationByIdResponseGenerationsByPk? generationsByPk)
        {
            this.GenerationsByPk = generationsByPk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationByIdResponse" /> class.
        /// </summary>
        public GetGenerationByIdResponse()
        {
        }
    }
}