//HintName: G.Models.ScoreDistributionDistributionItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScoreDistributionDistributionItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upper")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Upper { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lower")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Lower { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreDistributionDistributionItem" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="upper"></param>
        /// <param name="lower"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoreDistributionDistributionItem(
            double value,
            double upper,
            double lower)
        {
            this.Value = value;
            this.Upper = upper;
            this.Lower = lower;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreDistributionDistributionItem" /> class.
        /// </summary>
        public ScoreDistributionDistributionItem()
        {
        }
    }
}