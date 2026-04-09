//HintName: G.Models.JsonSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSchema
    {
        /// <summary>
        /// This is the type of output you'd like.<br/>
        /// `string`, `number`, `integer`, `boolean` are the primitive types and should be obvious.<br/>
        /// `array` and `object` are more interesting and quite powerful. They allow you to define nested structures.<br/>
        /// For `array`, you can define the schema of the items in the array using the `items` property.<br/>
        /// For `object`, you can define the properties of the object using the `properties` property.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.JsonSchemaTypeJsonConverter))]
        public global::G.JsonSchemaType Type { get; set; } = default!;

        /// <summary>
        /// This is required if the type is "array". This is the schema of the items in the array. This is a recursive reference to JsonSchema.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items")]
        public global::G.JsonSchema? Items { get; set; }

        /// <summary>
        /// This is required if the type is "object". This specifies the properties of the object. This is a map of property names to JsonSchema objects.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties")]
        public global::System.Collections.Generic.Dictionary<string, global::G.JsonSchema>? Properties { get; set; }

        /// <summary>
        /// This is the description to help the model understand what it needs to output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// This is the pattern of the string. This is a regex that will be used to validate the data in question. To use a common format, use the `format` property instead.<br/>
        /// OpenAI documentation: https://platform.openai.com/docs/guides/structured-outputs#supported-properties
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pattern")]
        public string? Pattern { get; set; }

        /// <summary>
        /// This is the format of the string. To pass a regex, use the `pattern` property instead.<br/>
        /// OpenAI documentation: https://platform.openai.com/docs/guides/structured-outputs?api-mode=chat&amp;type-restrictions=string-restrictions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.JsonSchemaFormatJsonConverter))]
        public global::G.JsonSchemaFormat? Format { get; set; }

        /// <summary>
        /// This is a list of properties that are required.<br/>
        /// This only makes sense if the type is "object".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// This array specifies the allowed values that can be used to restrict the output of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enum")]
        public global::System.Collections.Generic.IList<string>? Enum { get; set; }

        /// <summary>
        /// This is the title of the schema.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchema" /> class.
        /// </summary>
        /// <param name="type">
        /// This is the type of output you'd like.<br/>
        /// `string`, `number`, `integer`, `boolean` are the primitive types and should be obvious.<br/>
        /// `array` and `object` are more interesting and quite powerful. They allow you to define nested structures.<br/>
        /// For `array`, you can define the schema of the items in the array using the `items` property.<br/>
        /// For `object`, you can define the properties of the object using the `properties` property.
        /// </param>
        /// <param name="items">
        /// This is required if the type is "array". This is the schema of the items in the array. This is a recursive reference to JsonSchema.
        /// </param>
        /// <param name="properties">
        /// This is required if the type is "object". This specifies the properties of the object. This is a map of property names to JsonSchema objects.
        /// </param>
        /// <param name="description">
        /// This is the description to help the model understand what it needs to output.
        /// </param>
        /// <param name="pattern">
        /// This is the pattern of the string. This is a regex that will be used to validate the data in question. To use a common format, use the `format` property instead.<br/>
        /// OpenAI documentation: https://platform.openai.com/docs/guides/structured-outputs#supported-properties
        /// </param>
        /// <param name="format">
        /// This is the format of the string. To pass a regex, use the `pattern` property instead.<br/>
        /// OpenAI documentation: https://platform.openai.com/docs/guides/structured-outputs?api-mode=chat&amp;type-restrictions=string-restrictions
        /// </param>
        /// <param name="required">
        /// This is a list of properties that are required.<br/>
        /// This only makes sense if the type is "object".
        /// </param>
        /// <param name="enum">
        /// This array specifies the allowed values that can be used to restrict the output of the model.
        /// </param>
        /// <param name="title">
        /// This is the title of the schema.
        /// </param>
        public JsonSchema(
            global::G.JsonSchemaType type,
            global::G.JsonSchema? items,
            global::System.Collections.Generic.Dictionary<string, global::G.JsonSchema>? properties,
            string? description,
            string? pattern,
            global::G.JsonSchemaFormat? format,
            global::System.Collections.Generic.IList<string>? required,
            global::System.Collections.Generic.IList<string>? @enum,
            string? title)
        {
            this.Type = type;
            this.Items = items;
            this.Properties = properties;
            this.Description = description;
            this.Pattern = pattern;
            this.Format = format;
            this.Required = required;
            this.Enum = @enum;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchema" /> class.
        /// </summary>
        public JsonSchema()
        {
        }
    }
}