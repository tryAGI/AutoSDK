//HintName: G.Models.DeleteGenerationByIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteGenerationByIdResponse
    {
        /// <summary>
        /// columns and relationships of "generations"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_generations_by_pk")]
        public global::G.DeleteGenerationByIdResponseDeleteGenerationsByPk? DeleteGenerationsByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteGenerationByIdResponse" /> class.
        /// </summary>
        /// <param name="deleteGenerationsByPk">
        /// columns and relationships of "generations"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteGenerationByIdResponse(
            global::G.DeleteGenerationByIdResponseDeleteGenerationsByPk? deleteGenerationsByPk)
        {
            this.DeleteGenerationsByPk = deleteGenerationsByPk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteGenerationByIdResponse" /> class.
        /// </summary>
        public DeleteGenerationByIdResponse()
        {
        }
    }
}