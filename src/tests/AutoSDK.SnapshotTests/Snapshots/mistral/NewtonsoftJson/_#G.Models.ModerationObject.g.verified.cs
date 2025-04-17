//HintName: G.Models.ModerationObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModerationObject
    {
        /// <summary>
        /// Moderation result thresholds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("categories")]
        public global::System.Collections.Generic.Dictionary<string, bool>? Categories { get; set; }

        /// <summary>
        /// Moderation result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("category_scores")]
        public global::System.Collections.Generic.Dictionary<string, double>? CategoryScores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationObject" /> class.
        /// </summary>
        /// <param name="categories">
        /// Moderation result thresholds
        /// </param>
        /// <param name="categoryScores">
        /// Moderation result
        /// </param>
        public ModerationObject(
            global::System.Collections.Generic.Dictionary<string, bool>? categories,
            global::System.Collections.Generic.Dictionary<string, double>? categoryScores)
        {
            this.Categories = categories;
            this.CategoryScores = categoryScores;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationObject" /> class.
        /// </summary>
        public ModerationObject()
        {
        }
    }
}