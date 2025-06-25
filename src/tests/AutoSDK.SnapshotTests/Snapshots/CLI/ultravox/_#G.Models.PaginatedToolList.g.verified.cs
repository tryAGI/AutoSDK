//HintName: G.Models.PaginatedToolList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginatedToolList
    {
        /// <summary>
        /// Example: http://api.example.org/accounts/?cursor=cD00ODY%3D"
        /// </summary>
        /// <example>http://api.example.org/accounts/?cursor=cD00ODY%3D"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// Example: http://api.example.org/accounts/?cursor=cj0xJnA9NDg3
        /// </summary>
        /// <example>http://api.example.org/accounts/?cursor=cj0xJnA9NDg3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous")]
        public string? Previous { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Tool> Results { get; set; }

        /// <summary>
        /// Example: 123
        /// </summary>
        /// <example>123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedToolList" /> class.
        /// </summary>
        /// <param name="next">
        /// Example: http://api.example.org/accounts/?cursor=cD00ODY%3D"
        /// </param>
        /// <param name="previous">
        /// Example: http://api.example.org/accounts/?cursor=cj0xJnA9NDg3
        /// </param>
        /// <param name="results"></param>
        /// <param name="total">
        /// Example: 123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginatedToolList(
            global::System.Collections.Generic.IList<global::G.Tool> results,
            string? next,
            string? previous,
            int? total)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Next = next;
            this.Previous = previous;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedToolList" /> class.
        /// </summary>
        public PaginatedToolList()
        {
        }
    }
}