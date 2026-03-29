//HintName: G.Models.ResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Use this parameter to specify the format of the response. When you omit this parameter, the platform returns unstructured text.
    /// </summary>
    public sealed partial class ResponseFormat
    {
        /// <summary>
        /// Set this parameter to "json_schema" to receive structured JSON responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseFormatTypeJsonConverter))]
        public global::G.ResponseFormatType Type { get; set; }

        /// <summary>
        /// Contains the JSON schema that defines the response structure. The schema must adhere to the [JSON Schema Draft 2020-12](https://json-schema.org/draft/2020-12) specification.<br/>
        /// **Supported types**<br/>
        /// - `array`<br/>
        /// - `boolean`<br/>
        /// - `integer`<br/>
        /// - `null`<br/>
        /// - `number`<br/>
        /// - `object`<br/>
        /// - `string`<br/>
        /// **Supported constraints**<br/>
        /// | Type | Supported keywords | Notes |<br/>
        /// |------|-------------------|-------|<br/>
        /// | `integer` | `maximum`, `exclusiveMaximum`, `minimum`, `exclusiveMinimum`. | - `maximum`: Sets the highest allowed value (inclusive).&lt;br/&gt;- `exclusiveMaximum`: Sets the highest allowed value (exclusive).&lt;br/&gt;-`minimum`: Sets the lowest allowed value (inclusive).&lt;br/&gt;- `exclusiveMinimum`: Sets the lowest allowed value (exclusive).&lt;br/&gt;These constraints are supported only for the `integer` type. |<br/>
        /// | `string` | `pattern`, `format` | - `pattern`: A regular expression that the string must match.&lt;br/&gt;- `format`: Validates predefined formats. It accepts the following values: `uuid`, `date-time`, `date`, and `time`.&lt;br/&gt;See string limitations below. |<br/>
        /// | `object` | `properties`, `required` | - `properties`: Defines object properties and their schemas. - `required`: Specifies mandatory properties.&lt;br/&gt;See object limitations below. |<br/>
        /// | `array` | `items`, `minItems` | `minItems` accepts only `0` or `1` |<br/>
        /// **String limitations**<br/>
        /// The platform validates strings using the `pattern` and `format` constraints only. When you include `minLength` or `maxLength` keywords in your schema, the platform returns an error: "String length constraints (minLength) are not supported."<br/>
        /// **Object limitations**<br/>
        /// When you use the `object` type:<br/>
        /// - The platform always ignores the `additionalProperties` setting.<br/>
        /// - The sequence of the properties is fixed.<br/>
        /// - The first property should be required. If the first property is optional, the platform moves the first required property to the first position.<br/>
        /// **Constant and enumerated values**<br/>
        /// The `const` and `enum` keywords support the following types:<br/>
        /// - `boolean`<br/>
        /// - `null`<br/>
        /// - `number`<br/>
        /// - `string`<br/>
        /// **Schema composition**<br/>
        /// The platform supports only `anyOf` for [schema composition](https://json-schema.org/understanding-json-schema/reference/combining).<br/>
        /// **Annotations**<br/>
        /// The platform accepts but ignores JSON schema annotations like `title`, `$comments`, and `description`.<br/>
        /// **Subschema references**<br/>
        /// You can reference subschemas using `$ref` with these requirements:<br/>
        /// - Define subschemas within `$defs`.<br/>
        /// - Use valid URIs that point to the internal subschema.<br/>
        /// For details, see the [JSON Schema documentation on $defs](https://json-schema.org/understanding-json-schema/structuring#defs).<br/>
        /// **Response validation**<br/>
        /// Check the `FinishReason` field to verify your JSON response is complete:<br/>
        /// - When `FinishReason` is `stop`, the generation completed normally, and the JSON is valid and complete.<br/>
        /// - When `FinishReason` is `length`, the platform truncates the response at the token limit. This may result in truncated, invalid JSON that fails to parse.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResponseFormatJsonSchema JsonSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormat" /> class.
        /// </summary>
        /// <param name="jsonSchema">
        /// Contains the JSON schema that defines the response structure. The schema must adhere to the [JSON Schema Draft 2020-12](https://json-schema.org/draft/2020-12) specification.<br/>
        /// **Supported types**<br/>
        /// - `array`<br/>
        /// - `boolean`<br/>
        /// - `integer`<br/>
        /// - `null`<br/>
        /// - `number`<br/>
        /// - `object`<br/>
        /// - `string`<br/>
        /// **Supported constraints**<br/>
        /// | Type | Supported keywords | Notes |<br/>
        /// |------|-------------------|-------|<br/>
        /// | `integer` | `maximum`, `exclusiveMaximum`, `minimum`, `exclusiveMinimum`. | - `maximum`: Sets the highest allowed value (inclusive).&lt;br/&gt;- `exclusiveMaximum`: Sets the highest allowed value (exclusive).&lt;br/&gt;-`minimum`: Sets the lowest allowed value (inclusive).&lt;br/&gt;- `exclusiveMinimum`: Sets the lowest allowed value (exclusive).&lt;br/&gt;These constraints are supported only for the `integer` type. |<br/>
        /// | `string` | `pattern`, `format` | - `pattern`: A regular expression that the string must match.&lt;br/&gt;- `format`: Validates predefined formats. It accepts the following values: `uuid`, `date-time`, `date`, and `time`.&lt;br/&gt;See string limitations below. |<br/>
        /// | `object` | `properties`, `required` | - `properties`: Defines object properties and their schemas. - `required`: Specifies mandatory properties.&lt;br/&gt;See object limitations below. |<br/>
        /// | `array` | `items`, `minItems` | `minItems` accepts only `0` or `1` |<br/>
        /// **String limitations**<br/>
        /// The platform validates strings using the `pattern` and `format` constraints only. When you include `minLength` or `maxLength` keywords in your schema, the platform returns an error: "String length constraints (minLength) are not supported."<br/>
        /// **Object limitations**<br/>
        /// When you use the `object` type:<br/>
        /// - The platform always ignores the `additionalProperties` setting.<br/>
        /// - The sequence of the properties is fixed.<br/>
        /// - The first property should be required. If the first property is optional, the platform moves the first required property to the first position.<br/>
        /// **Constant and enumerated values**<br/>
        /// The `const` and `enum` keywords support the following types:<br/>
        /// - `boolean`<br/>
        /// - `null`<br/>
        /// - `number`<br/>
        /// - `string`<br/>
        /// **Schema composition**<br/>
        /// The platform supports only `anyOf` for [schema composition](https://json-schema.org/understanding-json-schema/reference/combining).<br/>
        /// **Annotations**<br/>
        /// The platform accepts but ignores JSON schema annotations like `title`, `$comments`, and `description`.<br/>
        /// **Subschema references**<br/>
        /// You can reference subschemas using `$ref` with these requirements:<br/>
        /// - Define subschemas within `$defs`.<br/>
        /// - Use valid URIs that point to the internal subschema.<br/>
        /// For details, see the [JSON Schema documentation on $defs](https://json-schema.org/understanding-json-schema/structuring#defs).<br/>
        /// **Response validation**<br/>
        /// Check the `FinishReason` field to verify your JSON response is complete:<br/>
        /// - When `FinishReason` is `stop`, the generation completed normally, and the JSON is valid and complete.<br/>
        /// - When `FinishReason` is `length`, the platform truncates the response at the token limit. This may result in truncated, invalid JSON that fails to parse.
        /// </param>
        /// <param name="type">
        /// Set this parameter to "json_schema" to receive structured JSON responses.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseFormat(
            global::G.ResponseFormatJsonSchema jsonSchema,
            global::G.ResponseFormatType type)
        {
            this.Type = type;
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormat" /> class.
        /// </summary>
        public ResponseFormat()
        {
        }
    }
}