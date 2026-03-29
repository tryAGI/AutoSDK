//HintName: G.Models.PageColumns.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PageColumns
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("columns")]
        public global::System.Collections.Generic.IList<global::G.Column>? Columns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PageColumns" /> class.
        /// </summary>
        /// <param name="columns"></param>
        public PageColumns(
            global::System.Collections.Generic.IList<global::G.Column>? columns)
        {
            this.Columns = columns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageColumns" /> class.
        /// </summary>
        public PageColumns()
        {
        }
    }
}