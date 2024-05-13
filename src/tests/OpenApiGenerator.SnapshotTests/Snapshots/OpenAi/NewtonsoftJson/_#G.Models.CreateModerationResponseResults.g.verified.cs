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
        [global::Newtonsoft.Json.JsonProperty("flagged", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Flagged { get; set; } = default!;

        /// <summary>
        /// A list of the categories, and whether they are flagged or not.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("categories", Required = global::Newtonsoft.Json.Required.Always)]
        public CreateModerationResponseResultsCategories Categories { get; set; } = default!;

        /// <summary>
        /// A list of the categories along with their scores as predicted by model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("category_scores", Required = global::Newtonsoft.Json.Required.Always)]
        public CreateModerationResponseResultsCategoryScores CategoryScores { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}