//HintName: G.Models.OpenAIFunctionParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIFunctionParameters
    {
        /// <summary>
        /// This must be set to 'object'. It instructs the model to return a JSON object containing the function call properties.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.OpenAIFunctionParametersTypeJsonConverter))]
        public global::G.OpenAIFunctionParametersType Type { get; set; }

        /// <summary>
        /// This provides a description of the properties required by the function.<br/>
        /// JSON Schema can be used to specify expectations for each property.<br/>
        /// Refer to [this doc](https://ajv.js.org/json-schema.html#json-data-type) for a comprehensive guide on JSON Schema.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.JsonSchema> Properties { get; set; } = default!;

        /// <summary>
        /// This specifies the properties that are required by the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFunctionParameters" /> class.
        /// </summary>
        /// <param name="properties">
        /// This provides a description of the properties required by the function.<br/>
        /// JSON Schema can be used to specify expectations for each property.<br/>
        /// Refer to [this doc](https://ajv.js.org/json-schema.html#json-data-type) for a comprehensive guide on JSON Schema.
        /// </param>
        /// <param name="type">
        /// This must be set to 'object'. It instructs the model to return a JSON object containing the function call properties.
        /// </param>
        /// <param name="required">
        /// This specifies the properties that are required by the function.
        /// </param>
        public OpenAIFunctionParameters(
            global::System.Collections.Generic.Dictionary<string, global::G.JsonSchema> properties,
            global::G.OpenAIFunctionParametersType type,
            global::System.Collections.Generic.IList<string>? required)
        {
            this.Type = type;
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFunctionParameters" /> class.
        /// </summary>
        public OpenAIFunctionParameters()
        {
        }
    }
}