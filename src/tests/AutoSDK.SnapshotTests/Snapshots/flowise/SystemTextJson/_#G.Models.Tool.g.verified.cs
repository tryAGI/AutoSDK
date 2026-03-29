//HintName: G.Models.Tool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Tool
    {
        /// <summary>
        /// Unique identifier for the tool<br/>
        /// Example: cfd531e0-82fc-11e9-bc42-526af7764f64
        /// </summary>
        /// <example>cfd531e0-82fc-11e9-bc42-526af7764f64</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Name of the tool<br/>
        /// Example: date_time_tool
        /// </summary>
        /// <example>date_time_tool</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the tool<br/>
        /// Example: A tool used for date and time operations
        /// </summary>
        /// <example>A tool used for date and time operations</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Color associated with the tool<br/>
        /// Example: #FF5733
        /// </summary>
        /// <example>#FF5733</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Source URL for the tool's icon<br/>
        /// Example: https://example.com/icons/date.png
        /// </summary>
        /// <example>https://example.com/icons/date.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("iconSrc")]
        public string? IconSrc { get; set; }

        /// <summary>
        /// JSON schema associated with the tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public string? Schema { get; set; }

        /// <summary>
        /// Functionality description or code associated with the tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("func")]
        public string? Func { get; set; }

        /// <summary>
        /// Date and time when the tool was created<br/>
        /// Example: 2024-08-24T14:15:22Z
        /// </summary>
        /// <example>2024-08-24T14:15:22Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Date and time when the tool was last updated<br/>
        /// Example: 2024-08-24T14:15:22Z
        /// </summary>
        /// <example>2024-08-24T14:15:22Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedDate")]
        public global::System.DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Tool" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the tool<br/>
        /// Example: cfd531e0-82fc-11e9-bc42-526af7764f64
        /// </param>
        /// <param name="name">
        /// Name of the tool<br/>
        /// Example: date_time_tool
        /// </param>
        /// <param name="description">
        /// Description of the tool<br/>
        /// Example: A tool used for date and time operations
        /// </param>
        /// <param name="color">
        /// Color associated with the tool<br/>
        /// Example: #FF5733
        /// </param>
        /// <param name="iconSrc">
        /// Source URL for the tool's icon<br/>
        /// Example: https://example.com/icons/date.png
        /// </param>
        /// <param name="schema">
        /// JSON schema associated with the tool
        /// </param>
        /// <param name="func">
        /// Functionality description or code associated with the tool
        /// </param>
        /// <param name="createdDate">
        /// Date and time when the tool was created<br/>
        /// Example: 2024-08-24T14:15:22Z
        /// </param>
        /// <param name="updatedDate">
        /// Date and time when the tool was last updated<br/>
        /// Example: 2024-08-24T14:15:22Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Tool(
            global::System.Guid? id,
            string? name,
            string? description,
            string? color,
            string? iconSrc,
            string? schema,
            string? func,
            global::System.DateTime? createdDate,
            global::System.DateTime? updatedDate)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Color = color;
            this.IconSrc = iconSrc;
            this.Schema = schema;
            this.Func = func;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tool" /> class.
        /// </summary>
        public Tool()
        {
        }
    }
}