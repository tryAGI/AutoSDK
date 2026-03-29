//HintName: G.Models.ModelPricingCacheMultipliers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelPricingCacheMultipliers
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("write1h")]
        public double? Write1h { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("write5m")]
        public double? Write5m { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachedInput")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CachedInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingCacheMultipliers" /> class.
        /// </summary>
        /// <param name="cachedInput"></param>
        /// <param name="write1h"></param>
        /// <param name="write5m"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPricingCacheMultipliers(
            double cachedInput,
            double? write1h,
            double? write5m)
        {
            this.Write1h = write1h;
            this.Write5m = write5m;
            this.CachedInput = cachedInput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingCacheMultipliers" /> class.
        /// </summary>
        public ModelPricingCacheMultipliers()
        {
        }
    }
}