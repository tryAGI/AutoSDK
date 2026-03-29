//HintName: G.Models.EntityDateRange.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Date range for work history entries.
    /// </summary>
    public sealed partial class EntityDateRange
    {
        /// <summary>
        /// Start date (YYYY-MM-DD format).<br/>
        /// Example: 2020-01-15
        /// </summary>
        /// <example>2020-01-15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// End date (YYYY-MM-DD format).<br/>
        /// Example: 2023-06-30
        /// </summary>
        /// <example>2023-06-30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public string? To { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityDateRange" /> class.
        /// </summary>
        /// <param name="from">
        /// Start date (YYYY-MM-DD format).<br/>
        /// Example: 2020-01-15
        /// </param>
        /// <param name="to">
        /// End date (YYYY-MM-DD format).<br/>
        /// Example: 2023-06-30
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EntityDateRange(
            string? from,
            string? to)
        {
            this.From = from;
            this.To = to;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityDateRange" /> class.
        /// </summary>
        public EntityDateRange()
        {
        }
    }
}