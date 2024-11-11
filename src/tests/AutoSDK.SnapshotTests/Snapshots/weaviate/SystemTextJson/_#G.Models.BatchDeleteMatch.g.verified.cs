//HintName: G.Models.BatchDeleteMatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Outlines how to find the objects to be deleted.
    /// </summary>
    public sealed partial class BatchDeleteMatch
    {
        /// <summary>
        /// Class (name) which objects will be deleted.<br/>
        /// Example: City
        /// </summary>
        /// <example>City</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("class")]
        public string? Class { get; set; }

        /// <summary>
        /// Filter search results using a where filter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("where")]
        public global::G.WhereFilter? Where { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeleteMatch" /> class.
        /// </summary>
        /// <param name="class">
        /// Class (name) which objects will be deleted.<br/>
        /// Example: City
        /// </param>
        /// <param name="where">
        /// Filter search results using a where filter
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BatchDeleteMatch(
            string? @class,
            global::G.WhereFilter? where)
        {
            this.Class = @class;
            this.Where = where;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeleteMatch" /> class.
        /// </summary>
        public BatchDeleteMatch()
        {
        }
    }
}