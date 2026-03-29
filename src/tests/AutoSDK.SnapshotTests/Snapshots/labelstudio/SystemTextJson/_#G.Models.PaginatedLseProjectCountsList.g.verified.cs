//HintName: G.Models.PaginatedLseProjectCountsList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginatedLseProjectCountsList
    {
        /// <summary>
        /// Example: 123
        /// </summary>
        /// <example>123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Example: http://api.example.org/accounts/?page=4
        /// </summary>
        /// <example>http://api.example.org/accounts/?page=4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// Example: http://api.example.org/accounts/?page=2
        /// </summary>
        /// <example>http://api.example.org/accounts/?page=2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous")]
        public string? Previous { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.LseProjectCounts> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedLseProjectCountsList" /> class.
        /// </summary>
        /// <param name="count">
        /// Example: 123
        /// </param>
        /// <param name="results"></param>
        /// <param name="next">
        /// Example: http://api.example.org/accounts/?page=4
        /// </param>
        /// <param name="previous">
        /// Example: http://api.example.org/accounts/?page=2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginatedLseProjectCountsList(
            int count,
            global::System.Collections.Generic.IList<global::G.LseProjectCounts> results,
            string? next,
            string? previous)
        {
            this.Count = count;
            this.Next = next;
            this.Previous = previous;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedLseProjectCountsList" /> class.
        /// </summary>
        public PaginatedLseProjectCountsList()
        {
        }
    }
}