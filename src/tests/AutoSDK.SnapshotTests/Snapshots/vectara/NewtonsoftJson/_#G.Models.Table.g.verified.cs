//HintName: G.Models.Table.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A table in a document.
    /// </summary>
    public sealed partial class Table
    {
        /// <summary>
        /// The unique ID of the table within the document.<br/>
        /// Example: table_1
        /// </summary>
        /// <example>table_1</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The title of the table.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The data of a table.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.Data? Data { get; set; }

        /// <summary>
        /// The description of the table.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Table" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the table within the document.<br/>
        /// Example: table_1
        /// </param>
        /// <param name="title">
        /// The title of the table.
        /// </param>
        /// <param name="data">
        /// The data of a table.
        /// </param>
        /// <param name="description">
        /// The description of the table.
        /// </param>
        public Table(
            string? id,
            string? title,
            global::G.Data? data,
            string? description)
        {
            this.Id = id;
            this.Title = title;
            this.Data = data;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Table" /> class.
        /// </summary>
        public Table()
        {
        }
    }
}