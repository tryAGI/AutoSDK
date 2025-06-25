//HintName: G.Models.CreateModerationResponseResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModerationResponseResult
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
        public required global::G.CreateModerationResponseResultCategories Categories { get; set; }

        /// <summary>
        /// A list of the categories along with their scores as predicted by model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_scores")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateModerationResponseResultCategoryScores CategoryScores { get; set; }

        /// <summary>
        /// A list of the categories along with the input type(s) that the score applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_applied_input_types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateModerationResponseResultCategoryAppliedInputTypes CategoryAppliedInputTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationResponseResult" /> class.
        /// </summary>
        /// <param name="flagged">
        /// Whether any of the below categories are flagged.
        /// </param>
        /// <param name="categories">
        /// A list of the categories, and whether they are flagged or not.
        /// </param>
        /// <param name="categoryScores">
        /// A list of the categories along with their scores as predicted by model.
        /// </param>
        /// <param name="categoryAppliedInputTypes">
        /// A list of the categories along with the input type(s) that the score applies to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModerationResponseResult(
            bool flagged,
            global::G.CreateModerationResponseResultCategories categories,
            global::G.CreateModerationResponseResultCategoryScores categoryScores,
            global::G.CreateModerationResponseResultCategoryAppliedInputTypes categoryAppliedInputTypes)
        {
            this.Flagged = flagged;
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
            this.CategoryScores = categoryScores ?? throw new global::System.ArgumentNullException(nameof(categoryScores));
            this.CategoryAppliedInputTypes = categoryAppliedInputTypes ?? throw new global::System.ArgumentNullException(nameof(categoryAppliedInputTypes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationResponseResult" /> class.
        /// </summary>
        public CreateModerationResponseResult()
        {
        }
    }
}