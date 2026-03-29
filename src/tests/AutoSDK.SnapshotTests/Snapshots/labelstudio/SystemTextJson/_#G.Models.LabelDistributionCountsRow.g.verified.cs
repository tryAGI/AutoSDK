//HintName: G.Models.LabelDistributionCountsRow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LabelDistributionCountsRow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Choice { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("choice_key")]
        public string ChoiceKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DimensionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_annotations_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FromAnnotationsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_annotations_percent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FromAnnotationsPercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_predictions_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FromPredictionsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_predictions_percent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FromPredictionsPercent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelDistributionCountsRow" /> class.
        /// </summary>
        /// <param name="choice"></param>
        /// <param name="dimensionName"></param>
        /// <param name="fromAnnotationsCount"></param>
        /// <param name="fromAnnotationsPercent"></param>
        /// <param name="fromPredictionsCount"></param>
        /// <param name="fromPredictionsPercent"></param>
        /// <param name="choiceKey">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabelDistributionCountsRow(
            string choice,
            string dimensionName,
            int fromAnnotationsCount,
            double fromAnnotationsPercent,
            int fromPredictionsCount,
            double fromPredictionsPercent,
            string choiceKey = default!)
        {
            this.Choice = choice ?? throw new global::System.ArgumentNullException(nameof(choice));
            this.ChoiceKey = choiceKey;
            this.DimensionName = dimensionName ?? throw new global::System.ArgumentNullException(nameof(dimensionName));
            this.FromAnnotationsCount = fromAnnotationsCount;
            this.FromAnnotationsPercent = fromAnnotationsPercent;
            this.FromPredictionsCount = fromPredictionsCount;
            this.FromPredictionsPercent = fromPredictionsPercent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelDistributionCountsRow" /> class.
        /// </summary>
        public LabelDistributionCountsRow()
        {
        }
    }
}