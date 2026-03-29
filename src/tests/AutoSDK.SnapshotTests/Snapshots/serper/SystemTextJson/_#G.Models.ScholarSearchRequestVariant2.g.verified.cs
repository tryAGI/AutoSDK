//HintName: G.Models.ScholarSearchRequestVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScholarSearchRequestVariant2
    {
        /// <summary>
        /// Cluster ID for finding articles that cite a specific paper.<br/>
        /// Example: 5765689389901880758
        /// </summary>
        /// <example>5765689389901880758</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cites")]
        public string? Cites { get; set; }

        /// <summary>
        /// Start year for filtering results (from year).<br/>
        /// Example: 2020
        /// </summary>
        /// <example>2020</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("as_ylo")]
        public string? AsYlo { get; set; }

        /// <summary>
        /// End year for filtering results (to year).<br/>
        /// Example: 2024
        /// </summary>
        /// <example>2024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("as_yhi")]
        public string? AsYhi { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScholarSearchRequestVariant2" /> class.
        /// </summary>
        /// <param name="cites">
        /// Cluster ID for finding articles that cite a specific paper.<br/>
        /// Example: 5765689389901880758
        /// </param>
        /// <param name="asYlo">
        /// Start year for filtering results (from year).<br/>
        /// Example: 2020
        /// </param>
        /// <param name="asYhi">
        /// End year for filtering results (to year).<br/>
        /// Example: 2024
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScholarSearchRequestVariant2(
            string? cites,
            string? asYlo,
            string? asYhi)
        {
            this.Cites = cites;
            this.AsYlo = asYlo;
            this.AsYhi = asYhi;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScholarSearchRequestVariant2" /> class.
        /// </summary>
        public ScholarSearchRequestVariant2()
        {
        }
    }
}