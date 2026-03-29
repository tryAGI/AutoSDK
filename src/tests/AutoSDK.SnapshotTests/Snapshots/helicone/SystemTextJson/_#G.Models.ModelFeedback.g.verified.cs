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
        [global::System.Text.Json.Serialization.JsonPropertyName("negativePercentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NegativePercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("positivePercentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PositivePercentage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelFeedback" /> class.
        /// </summary>
        /// <param name="negativePercentage"></param>
        /// <param name="positivePercentage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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