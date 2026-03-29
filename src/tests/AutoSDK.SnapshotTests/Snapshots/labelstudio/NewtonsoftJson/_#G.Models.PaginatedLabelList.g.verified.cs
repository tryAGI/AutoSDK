//HintName: G.Models.PaginatedLabelList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginatedLabelList
    {
        /// <summary>
        /// Example: 123
        /// </summary>
        /// <example>123</example>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public int Count { get; set; } = default!;

        /// <summary>
        /// Example: http://api.example.org/accounts/?page=4
        /// </summary>
        /// <example>http://api.example.org/accounts/?page=4</example>
        [global::Newtonsoft.Json.JsonProperty("next")]
        public string? Next { get; set; }

        /// <summary>
        /// Example: http://api.example.org/accounts/?page=2
        /// </summary>
        /// <example>http://api.example.org/accounts/?page=2</example>
        [global::Newtonsoft.Json.JsonProperty("previous")]
        public string? Previous { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Label> Results { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedLabelList" /> class.
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
        public PaginatedLabelList(
            int count,
            global::System.Collections.Generic.IList<global::G.Label> results,
            string? next,
            string? previous)
        {
            this.Count = count;
            this.Next = next;
            this.Previous = previous;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedLabelList" /> class.
        /// </summary>
        public PaginatedLabelList()
        {
        }
    }
}