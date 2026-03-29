//HintName: G.Models.CategoricalAnnotationValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CategoricalAnnotationValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalAnnotationValue" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="score"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CategoricalAnnotationValue(
            string label,
            double? score)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalAnnotationValue" /> class.
        /// </summary>
        public CategoricalAnnotationValue()
        {
        }
    }
}