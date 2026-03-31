//HintName: G.Models.EntityCompanyPropertiesFundingRound.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Funding round information.
    /// </summary>
    public sealed partial class EntityCompanyPropertiesFundingRound
    {
        /// <summary>
        /// Name of the funding round (e.g., "Series A", "Seed").<br/>
        /// Example: Series B
        /// </summary>
        /// <example>Series B</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Date of the funding round.<br/>
        /// Example: 2023-06-15
        /// </summary>
        /// <example>2023-06-15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// Amount raised in USD.<br/>
        /// Example: 50000000
        /// </summary>
        /// <example>50000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int? Amount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityCompanyPropertiesFundingRound" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the funding round (e.g., "Series A", "Seed").<br/>
        /// Example: Series B
        /// </param>
        /// <param name="date">
        /// Date of the funding round.<br/>
        /// Example: 2023-06-15
        /// </param>
        /// <param name="amount">
        /// Amount raised in USD.<br/>
        /// Example: 50000000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EntityCompanyPropertiesFundingRound(
            string? name,
            string? date,
            int? amount)
        {
            this.Name = name;
            this.Date = date;
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityCompanyPropertiesFundingRound" /> class.
        /// </summary>
        public EntityCompanyPropertiesFundingRound()
        {
        }
    }
}