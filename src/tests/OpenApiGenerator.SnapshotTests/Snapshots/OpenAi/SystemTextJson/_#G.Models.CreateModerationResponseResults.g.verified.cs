//HintName: G.Models.CreateModerationResponseResults.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModerationResponseResults
    {
        /// <summary>
        /// Whether any of the below categories are flagged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Flagged { get; set; }

        /// <summary>
        /// A list of the categories, and whether they are flagged or not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required CreateModerationResponseResultsCategories Categories { get; set; }

        /// <summary>
        /// A list of the categories along with their scores as predicted by model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_scores")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required CreateModerationResponseResultsCategoryScores CategoryScores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}