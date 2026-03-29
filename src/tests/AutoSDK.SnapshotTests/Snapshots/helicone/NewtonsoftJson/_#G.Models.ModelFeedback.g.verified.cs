//HintName: G.Models.ModelFeedback.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelFeedback
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("negativePercentage", Required = global::Newtonsoft.Json.Required.Always)]
        public double NegativePercentage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("positivePercentage", Required = global::Newtonsoft.Json.Required.Always)]
        public double PositivePercentage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelFeedback" /> class.
        /// </summary>
        /// <param name="negativePercentage"></param>
        /// <param name="positivePercentage"></param>
        public ModelFeedback(
            double negativePercentage,
            double positivePercentage)
        {
            this.NegativePercentage = negativePercentage;
            this.PositivePercentage = positivePercentage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelFeedback" /> class.
        /// </summary>
        public ModelFeedback()
        {
        }
    }
}