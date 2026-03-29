//HintName: G.Models.ModelGeographicTtftItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelGeographicTtftItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("median")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Median { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("countryCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CountryCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelGeographicTtftItem" /> class.
        /// </summary>
        /// <param name="median"></param>
        /// <param name="countryCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelGeographicTtftItem(
            double median,
            string countryCode)
        {
            this.Median = median;
            this.CountryCode = countryCode ?? throw new global::System.ArgumentNullException(nameof(countryCode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelGeographicTtftItem" /> class.
        /// </summary>
        public ModelGeographicTtftItem()
        {
        }
    }
}