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
        [global::Newtonsoft.Json.JsonProperty("flagged", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Flagged { get; set; } = default!;

        /// <summary>
        /// A list of the categories, and whether they are flagged or not.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("categories", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateModerationResponseResultCategories Categories { get; set; } = default!;

        /// <summary>
        /// A list of the categories along with their scores as predicted by model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("category_scores", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateModerationResponseResultCategoryScores CategoryScores { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public CreateModerationResponseResult(
            bool flagged,
            global::G.CreateModerationResponseResultCategories categories,
            global::G.CreateModerationResponseResultCategoryScores categoryScores)
        {
            this.Flagged = flagged;
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
            this.CategoryScores = categoryScores ?? throw new global::System.ArgumentNullException(nameof(categoryScores));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationResponseResult" /> class.
        /// </summary>
        public CreateModerationResponseResult()
        {
        }
    }
}