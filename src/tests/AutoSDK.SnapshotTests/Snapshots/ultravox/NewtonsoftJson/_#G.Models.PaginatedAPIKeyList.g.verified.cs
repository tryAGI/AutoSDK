﻿//HintName: G.Models.PaginatedAPIKeyList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginatedAPIKeyList
    {
        /// <summary>
        /// Example: http://api.example.org/accounts/?cursor=cD00ODY%3D"
        /// </summary>
        /// <example>http://api.example.org/accounts/?cursor=cD00ODY%3D"</example>
        [global::Newtonsoft.Json.JsonProperty("next")]
        public string? Next { get; set; }

        /// <summary>
        /// Example: http://api.example.org/accounts/?cursor=cj0xJnA9NDg3
        /// </summary>
        /// <example>http://api.example.org/accounts/?cursor=cj0xJnA9NDg3</example>
        [global::Newtonsoft.Json.JsonProperty("previous")]
        public string? Previous { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.APIKey> Results { get; set; } = default!;

        /// <summary>
        /// Example: 123
        /// </summary>
        /// <example>123</example>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedAPIKeyList" /> class.
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
        public PaginatedAPIKeyList(
            global::System.Collections.Generic.IList<global::G.APIKey> results,
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
        /// Initializes a new instance of the <see cref="PaginatedAPIKeyList" /> class.
        /// </summary>
        public PaginatedAPIKeyList()
        {
        }
    }
}