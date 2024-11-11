//HintName: G.Models.BatchDeleteResponseMatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Outlines how to find the objects to be deleted.
    /// </summary>
    public sealed partial class BatchDeleteResponseMatch
    {
        /// <summary>
        /// Class (name) which objects will be deleted.<br/>
        /// Example: City
        /// </summary>
        /// <example>City</example>
        [global::Newtonsoft.Json.JsonProperty("class")]
        public string? Class { get; set; }

        /// <summary>
        /// Filter search results using a where filter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("where")]
        public global::G.WhereFilter? Where { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeleteResponseMatch" /> class.
        /// </summary>
        /// <param name="class">
        /// Class (name) which objects will be deleted.<br/>
        /// Example: City
        /// </param>
        /// <param name="where">
        /// Filter search results using a where filter
        /// </param>
        public BatchDeleteResponseMatch(
            string? @class,
            global::G.WhereFilter? where)
        {
            this.Class = @class;
            this.Where = where;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeleteResponseMatch" /> class.
        /// </summary>
        public BatchDeleteResponseMatch()
        {
        }
    }
}