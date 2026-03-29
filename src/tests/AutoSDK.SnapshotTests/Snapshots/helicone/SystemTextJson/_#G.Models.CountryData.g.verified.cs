//HintName: G.Models.CountryData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CountryData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CountryData" /> class.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="totalRequests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CountryData(
            string country,
            double totalRequests)
        {
            this.Country = country ?? throw new global::System.ArgumentNullException(nameof(country));
            this.TotalRequests = totalRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountryData" /> class.
        /// </summary>
        public CountryData()
        {
        }
    }
}