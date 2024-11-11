//HintName: G.Models.V2TemplateGenerateRequestVariablesFirstName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2TemplateGenerateRequestVariablesFirstName
    {
        /// <summary>
        /// Example: first_name
        /// </summary>
        /// <example>first_name</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties")]
        public global::G.V2TemplateGenerateRequestVariablesFirstNameProperties? Properties { get; set; }

        /// <summary>
        /// Example: text
        /// </summary>
        /// <example>text</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2TemplateGenerateRequestVariablesFirstName" /> class.
        /// </summary>
        /// <param name="name">
        /// Example: first_name
        /// </param>
        /// <param name="properties"></param>
        /// <param name="type">
        /// Example: text
        /// </param>
        public V2TemplateGenerateRequestVariablesFirstName(
            string? name,
            global::G.V2TemplateGenerateRequestVariablesFirstNameProperties? properties,
            string? type)
        {
            this.Name = name;
            this.Properties = properties;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2TemplateGenerateRequestVariablesFirstName" /> class.
        /// </summary>
        public V2TemplateGenerateRequestVariablesFirstName()
        {
        }
    }
}