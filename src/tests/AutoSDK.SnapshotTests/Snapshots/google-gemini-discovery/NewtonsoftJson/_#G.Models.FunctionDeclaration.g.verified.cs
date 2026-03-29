//HintName: G.Models.FunctionDeclaration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Structured representation of a function declaration as defined by the [OpenAPI 3.03 specification](https://spec.openapis.org/oas/v3.0.3). Included in this declaration are the function name and parameters. This FunctionDeclaration is a representation of a block of code that can be used as a `Tool` by the model and executed by the client.
    /// </summary>
    public sealed partial class FunctionDeclaration
    {
        /// <summary>
        /// Required. The name of the function. Must be a-z, A-Z, 0-9, or contain underscores, colons, dots, and dashes, with a maximum length of 128.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Required. A brief description of the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The `Schema` object allows the definition of input and output data types. These types can be objects, but also primitives and arrays. Represents a select subset of an [OpenAPI 3.0 schema object](https://spec.openapis.org/oas/v3.0.3#schema).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.Schema? Parameters { get; set; }

        /// <summary>
        /// Optional. Describes the parameters to the function in JSON Schema format. The schema must describe an object where the properties are the parameters to the function. For example: ``` { "type": "object", "properties": { "name": { "type": "string" }, "age": { "type": "integer" } }, "additionalProperties": false, "required": ["name", "age"], "propertyOrdering": ["name", "age"] } ``` This field is mutually exclusive with `parameters`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parametersJsonSchema")]
        public object? ParametersJsonSchema { get; set; }

        /// <summary>
        /// The `Schema` object allows the definition of input and output data types. These types can be objects, but also primitives and arrays. Represents a select subset of an [OpenAPI 3.0 schema object](https://spec.openapis.org/oas/v3.0.3#schema).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response")]
        public global::G.Schema? Response { get; set; }

        /// <summary>
        /// Optional. Describes the output from this function in JSON Schema format. The value specified by the schema is the response value of the function. This field is mutually exclusive with `response`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("responseJsonSchema")]
        public object? ResponseJsonSchema { get; set; }

        /// <summary>
        /// Optional. Specifies the function Behavior. Currently only supported by the BidiGenerateContent method.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("behavior")]
        public global::G.FunctionDeclarationBehavior? Behavior { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDeclaration" /> class.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function. Must be a-z, A-Z, 0-9, or contain underscores, colons, dots, and dashes, with a maximum length of 128.
        /// </param>
        /// <param name="description">
        /// Required. A brief description of the function.
        /// </param>
        /// <param name="parameters">
        /// The `Schema` object allows the definition of input and output data types. These types can be objects, but also primitives and arrays. Represents a select subset of an [OpenAPI 3.0 schema object](https://spec.openapis.org/oas/v3.0.3#schema).
        /// </param>
        /// <param name="parametersJsonSchema">
        /// Optional. Describes the parameters to the function in JSON Schema format. The schema must describe an object where the properties are the parameters to the function. For example: ``` { "type": "object", "properties": { "name": { "type": "string" }, "age": { "type": "integer" } }, "additionalProperties": false, "required": ["name", "age"], "propertyOrdering": ["name", "age"] } ``` This field is mutually exclusive with `parameters`.
        /// </param>
        /// <param name="response">
        /// The `Schema` object allows the definition of input and output data types. These types can be objects, but also primitives and arrays. Represents a select subset of an [OpenAPI 3.0 schema object](https://spec.openapis.org/oas/v3.0.3#schema).
        /// </param>
        /// <param name="responseJsonSchema">
        /// Optional. Describes the output from this function in JSON Schema format. The value specified by the schema is the response value of the function. This field is mutually exclusive with `response`.
        /// </param>
        /// <param name="behavior">
        /// Optional. Specifies the function Behavior. Currently only supported by the BidiGenerateContent method.
        /// </param>
        public FunctionDeclaration(
            string? name,
            string? description,
            global::G.Schema? parameters,
            object? parametersJsonSchema,
            global::G.Schema? response,
            object? responseJsonSchema,
            global::G.FunctionDeclarationBehavior? behavior)
        {
            this.Name = name;
            this.Description = description;
            this.Parameters = parameters;
            this.ParametersJsonSchema = parametersJsonSchema;
            this.Response = response;
            this.ResponseJsonSchema = responseJsonSchema;
            this.Behavior = behavior;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDeclaration" /> class.
        /// </summary>
        public FunctionDeclaration()
        {
        }
    }
}