//HintName: G.Models.ClassificationFilters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassificationFilters
    {
        /// <summary>
        /// Filter search results using a where filter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceWhere")]
        public global::G.WhereFilter? SourceWhere { get; set; }

        /// <summary>
        /// Filter search results using a where filter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainingSetWhere")]
        public global::G.WhereFilter? TrainingSetWhere { get; set; }

        /// <summary>
        /// Filter search results using a where filter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetWhere")]
        public global::G.WhereFilter? TargetWhere { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationFilters" /> class.
        /// </summary>
        /// <param name="sourceWhere">
        /// Filter search results using a where filter
        /// </param>
        /// <param name="trainingSetWhere">
        /// Filter search results using a where filter
        /// </param>
        /// <param name="targetWhere">
        /// Filter search results using a where filter
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ClassificationFilters(
            global::G.WhereFilter? sourceWhere,
            global::G.WhereFilter? trainingSetWhere,
            global::G.WhereFilter? targetWhere)
        {
            this.SourceWhere = sourceWhere;
            this.TrainingSetWhere = trainingSetWhere;
            this.TargetWhere = targetWhere;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationFilters" /> class.
        /// </summary>
        public ClassificationFilters()
        {
        }
    }
}