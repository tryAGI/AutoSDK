//HintName: G.Models.Variable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Variable
    {
        /// <summary>
        /// Unique identifier for the variable<br/>
        /// Example: cfd531e0-82fc-11e9-bc42-526af7764f64
        /// </summary>
        /// <example>cfd531e0-82fc-11e9-bc42-526af7764f64</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Name of the variable<br/>
        /// Example: API_KEY
        /// </summary>
        /// <example>API_KEY</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Value of the variable<br/>
        /// Example: my-secret-key
        /// </summary>
        /// <example>my-secret-key</example>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Type of the variable (e.g., string, number)<br/>
        /// Example: string
        /// </summary>
        /// <example>string</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Date and time when the variable was created<br/>
        /// Example: 2024-08-24T14:15:22Z
        /// </summary>
        /// <example>2024-08-24T14:15:22Z</example>
        [global::Newtonsoft.Json.JsonProperty("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Date and time when the variable was last updated<br/>
        /// Example: 2024-08-24T14:15:22Z
        /// </summary>
        /// <example>2024-08-24T14:15:22Z</example>
        [global::Newtonsoft.Json.JsonProperty("updatedDate")]
        public global::System.DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Variable" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the variable<br/>
        /// Example: cfd531e0-82fc-11e9-bc42-526af7764f64
        /// </param>
        /// <param name="name">
        /// Name of the variable<br/>
        /// Example: API_KEY
        /// </param>
        /// <param name="value">
        /// Value of the variable<br/>
        /// Example: my-secret-key
        /// </param>
        /// <param name="type">
        /// Type of the variable (e.g., string, number)<br/>
        /// Example: string
        /// </param>
        /// <param name="createdDate">
        /// Date and time when the variable was created<br/>
        /// Example: 2024-08-24T14:15:22Z
        /// </param>
        /// <param name="updatedDate">
        /// Date and time when the variable was last updated<br/>
        /// Example: 2024-08-24T14:15:22Z
        /// </param>
        public Variable(
            global::System.Guid? id,
            string? name,
            string? value,
            string? type,
            global::System.DateTime? createdDate,
            global::System.DateTime? updatedDate)
        {
            this.Id = id;
            this.Name = name;
            this.Value = value;
            this.Type = type;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Variable" /> class.
        /// </summary>
        public Variable()
        {
        }
    }
}