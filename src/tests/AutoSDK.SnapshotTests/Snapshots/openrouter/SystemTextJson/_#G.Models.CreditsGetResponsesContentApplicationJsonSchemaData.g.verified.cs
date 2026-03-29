//HintName: G.Models.CreditsGetResponsesContentApplicationJsonSchemaData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreditsGetResponsesContentApplicationJsonSchemaData
    {
        /// <summary>
        /// Total credits purchased
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCredits { get; set; }

        /// <summary>
        /// Total credits used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsGetResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        /// <param name="totalCredits">
        /// Total credits purchased
        /// </param>
        /// <param name="totalUsage">
        /// Total credits used
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreditsGetResponsesContentApplicationJsonSchemaData(
            double totalCredits,
            double totalUsage)
        {
            this.TotalCredits = totalCredits;
            this.TotalUsage = totalUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsGetResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        public CreditsGetResponsesContentApplicationJsonSchemaData()
        {
        }
    }
}