//HintName: G.Models.Schema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The `Schema` object allows the definition of input and output data types. These types can be objects, but also primitives and arrays. Represents a select subset of an [OpenAPI 3.0 schema object](https://spec.openapis.org/oas/v3.0.3#schema).
    /// </summary>
    public sealed partial class Schema
    {
        /// <summary>
        /// Required. Data type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SchemaType? Type { get; set; }

        /// <summary>
        /// Optional. The format of the data. Any value is allowed, but most do not trigger any special functionality.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public string? Format { get; set; }

        /// <summary>
        /// Optional. The title of the schema.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Optional. A brief description of the parameter. This could contain examples of use. Parameter description may be formatted as Markdown.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Optional. Indicates if the value may be null.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nullable")]
        public bool? Nullable { get; set; }

        /// <summary>
        /// Optional. Possible values of the element of Type.STRING with enum format. For example we can define an Enum Direction as : {type:STRING, format:enum, enum:["EAST", NORTH", "SOUTH", "WEST"]}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enum")]
        public global::System.Collections.Generic.IList<string>? Enum { get; set; }

        /// <summary>
        /// The `Schema` object allows the definition of input and output data types. These types can be objects, but also primitives and arrays. Represents a select subset of an [OpenAPI 3.0 schema object](https://spec.openapis.org/oas/v3.0.3#schema).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items")]
        public global::G.Schema? Items { get; set; }

        /// <summary>
        /// Optional. Maximum number of the elements for Type.ARRAY.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxItems")]
        public string? MaxItems { get; set; }

        /// <summary>
        /// Optional. Minimum number of the elements for Type.ARRAY.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minItems")]
        public string? MinItems { get; set; }

        /// <summary>
        /// Optional. Properties of Type.OBJECT.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties")]
        public global::System.Collections.Generic.Dictionary<string, global::G.Schema>? Properties { get; set; }

        /// <summary>
        /// Optional. Required properties of Type.OBJECT.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// Optional. Minimum number of the properties for Type.OBJECT.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minProperties")]
        public string? MinProperties { get; set; }

        /// <summary>
        /// Optional. Maximum number of the properties for Type.OBJECT.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxProperties")]
        public string? MaxProperties { get; set; }

        /// <summary>
        /// Optional. SCHEMA FIELDS FOR TYPE INTEGER and NUMBER Minimum value of the Type.INTEGER and Type.NUMBER
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minimum")]
        public double? Minimum { get; set; }

        /// <summary>
        /// Optional. Maximum value of the Type.INTEGER and Type.NUMBER
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maximum")]
        public double? Maximum { get; set; }

        /// <summary>
        /// Optional. SCHEMA FIELDS FOR TYPE STRING Minimum length of the Type.STRING
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minLength")]
        public string? MinLength { get; set; }

        /// <summary>
        /// Optional. Maximum length of the Type.STRING
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxLength")]
        public string? MaxLength { get; set; }

        /// <summary>
        /// Optional. Pattern of the Type.STRING to restrict a string to a regular expression.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pattern")]
        public string? Pattern { get; set; }

        /// <summary>
        /// Optional. Example of the object. Will only populated when the object is the root.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("example")]
        public object? Example { get; set; }

        /// <summary>
        /// Optional. The value should be validated against any (one or more) of the subschemas in the list.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("anyOf")]
        public global::System.Collections.Generic.IList<global::G.Schema>? AnyOf { get; set; }

        /// <summary>
        /// Optional. The order of the properties. Not a standard field in open api spec. Used to determine the order of the properties in the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("propertyOrdering")]
        public global::System.Collections.Generic.IList<string>? PropertyOrdering { get; set; }

        /// <summary>
        /// Optional. Default value of the field. Per JSON Schema, this field is intended for documentation generators and doesn't affect validation. Thus it's included here and ignored so that developers who send schemas with a `default` field don't get unknown-field errors.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default")]
        public object? Default { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Schema" /> class.
        /// </summary>
        /// <param name="type">
        /// Required. Data type.
        /// </param>
        /// <param name="format">
        /// Optional. The format of the data. Any value is allowed, but most do not trigger any special functionality.
        /// </param>
        /// <param name="title">
        /// Optional. The title of the schema.
        /// </param>
        /// <param name="description">
        /// Optional. A brief description of the parameter. This could contain examples of use. Parameter description may be formatted as Markdown.
        /// </param>
        /// <param name="nullable">
        /// Optional. Indicates if the value may be null.
        /// </param>
        /// <param name="enum">
        /// Optional. Possible values of the element of Type.STRING with enum format. For example we can define an Enum Direction as : {type:STRING, format:enum, enum:["EAST", NORTH", "SOUTH", "WEST"]}
        /// </param>
        /// <param name="items">
        /// The `Schema` object allows the definition of input and output data types. These types can be objects, but also primitives and arrays. Represents a select subset of an [OpenAPI 3.0 schema object](https://spec.openapis.org/oas/v3.0.3#schema).
        /// </param>
        /// <param name="maxItems">
        /// Optional. Maximum number of the elements for Type.ARRAY.
        /// </param>
        /// <param name="minItems">
        /// Optional. Minimum number of the elements for Type.ARRAY.
        /// </param>
        /// <param name="properties">
        /// Optional. Properties of Type.OBJECT.
        /// </param>
        /// <param name="required">
        /// Optional. Required properties of Type.OBJECT.
        /// </param>
        /// <param name="minProperties">
        /// Optional. Minimum number of the properties for Type.OBJECT.
        /// </param>
        /// <param name="maxProperties">
        /// Optional. Maximum number of the properties for Type.OBJECT.
        /// </param>
        /// <param name="minimum">
        /// Optional. SCHEMA FIELDS FOR TYPE INTEGER and NUMBER Minimum value of the Type.INTEGER and Type.NUMBER
        /// </param>
        /// <param name="maximum">
        /// Optional. Maximum value of the Type.INTEGER and Type.NUMBER
        /// </param>
        /// <param name="minLength">
        /// Optional. SCHEMA FIELDS FOR TYPE STRING Minimum length of the Type.STRING
        /// </param>
        /// <param name="maxLength">
        /// Optional. Maximum length of the Type.STRING
        /// </param>
        /// <param name="pattern">
        /// Optional. Pattern of the Type.STRING to restrict a string to a regular expression.
        /// </param>
        /// <param name="example">
        /// Optional. Example of the object. Will only populated when the object is the root.
        /// </param>
        /// <param name="anyOf">
        /// Optional. The value should be validated against any (one or more) of the subschemas in the list.
        /// </param>
        /// <param name="propertyOrdering">
        /// Optional. The order of the properties. Not a standard field in open api spec. Used to determine the order of the properties in the response.
        /// </param>
        /// <param name="default">
        /// Optional. Default value of the field. Per JSON Schema, this field is intended for documentation generators and doesn't affect validation. Thus it's included here and ignored so that developers who send schemas with a `default` field don't get unknown-field errors.
        /// </param>
        public Schema(
            global::G.SchemaType? type,
            string? format,
            string? title,
            string? description,
            bool? nullable,
            global::System.Collections.Generic.IList<string>? @enum,
            global::G.Schema? items,
            string? maxItems,
            string? minItems,
            global::System.Collections.Generic.Dictionary<string, global::G.Schema>? properties,
            global::System.Collections.Generic.IList<string>? required,
            string? minProperties,
            string? maxProperties,
            double? minimum,
            double? maximum,
            string? minLength,
            string? maxLength,
            string? pattern,
            object? example,
            global::System.Collections.Generic.IList<global::G.Schema>? anyOf,
            global::System.Collections.Generic.IList<string>? propertyOrdering,
            object? @default)
        {
            this.Type = type;
            this.Format = format;
            this.Title = title;
            this.Description = description;
            this.Nullable = nullable;
            this.Enum = @enum;
            this.Items = items;
            this.MaxItems = maxItems;
            this.MinItems = minItems;
            this.Properties = properties;
            this.Required = required;
            this.MinProperties = minProperties;
            this.MaxProperties = maxProperties;
            this.Minimum = minimum;
            this.Maximum = maximum;
            this.MinLength = minLength;
            this.MaxLength = maxLength;
            this.Pattern = pattern;
            this.Example = example;
            this.AnyOf = anyOf;
            this.PropertyOrdering = propertyOrdering;
            this.Default = @default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Schema" /> class.
        /// </summary>
        public Schema()
        {
        }
    }
}