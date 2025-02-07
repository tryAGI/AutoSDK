//HintName: G.Models.DeleteGenerationByIdResponseDeleteGenerationsByPk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// columns and relationships of "generations"
    /// </summary>
    public sealed partial class DeleteGenerationByIdResponseDeleteGenerationsByPk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteGenerationByIdResponseDeleteGenerationsByPk" /> class.
        /// </summary>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteGenerationByIdResponseDeleteGenerationsByPk(
            string? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteGenerationByIdResponseDeleteGenerationsByPk" /> class.
        /// </summary>
        public DeleteGenerationByIdResponseDeleteGenerationsByPk()
        {
        }
    }
}