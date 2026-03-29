//HintName: G.Models.CreateResearchRequestOutputSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A JSON Schema object that defines the structure of the research output. When provided, the research response will be structured to match this schema, ensuring a predictable and validated output shape. Must include a 'properties' field, and may optionally include 'required' field.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
    /// Example: {"properties":{"company":{"type":"string","description":"The name of the company"},"key_metrics":{"type":"array","description":"List of key performance metrics","items":{"type":"string"}},"financial_details":{"type":"object","description":"Detailed financial breakdown","properties":{"operating_income":{"type":"number","description":"Operating income for the period"}}}},"required":["company"]}
    /// </summary>
    public sealed partial class CreateResearchRequestOutputSchema
    {
        /// <summary>
        /// An object containing property definitions. Each key is a property name, and each value is a property schema.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties")]
        public global::System.Collections.Generic.Dictionary<string, global::G.CreateResearchRequestOutputSchemaProperties2>? Properties { get; set; }

        /// <summary>
        /// An array of property names that are required. At least one key from the properties object must be included.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResearchRequestOutputSchema" /> class.
        /// </summary>
        /// <param name="properties">
        /// An object containing property definitions. Each key is a property name, and each value is a property schema.
        /// </param>
        /// <param name="required">
        /// An array of property names that are required. At least one key from the properties object must be included.
        /// </param>
        public CreateResearchRequestOutputSchema(
            global::System.Collections.Generic.Dictionary<string, global::G.CreateResearchRequestOutputSchemaProperties2>? properties,
            global::System.Collections.Generic.IList<string>? required)
        {
            this.Properties = properties;
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResearchRequestOutputSchema" /> class.
        /// </summary>
        public CreateResearchRequestOutputSchema()
        {
        }
    }
}