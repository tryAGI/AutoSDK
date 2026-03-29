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
        [global::Newtonsoft.Json.JsonProperty("choice", Required = global::Newtonsoft.Json.Required.Always)]
        public string Choice { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("choice_key")]
        public string ChoiceKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dimension_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DimensionName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_annotations_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int FromAnnotationsCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_annotations_percent", Required = global::Newtonsoft.Json.Required.Always)]
        public double FromAnnotationsPercent { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_predictions_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int FromPredictionsCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_predictions_percent", Required = global::Newtonsoft.Json.Required.Always)]
        public double FromPredictionsPercent { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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