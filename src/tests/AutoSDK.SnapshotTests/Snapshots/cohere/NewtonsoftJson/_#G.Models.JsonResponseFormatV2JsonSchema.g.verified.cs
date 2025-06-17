//HintName: G.Models.JsonResponseFormatV2JsonSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A [JSON schema](https://json-schema.org/overview/what-is-jsonschema) object that the output will adhere to. There are some restrictions we have on the schema, refer to [our guide](https://docs.cohere.com/docs/structured-outputs-json#schema-constraints) for more information.<br/>
    /// Example (required name and age object):<br/>
    /// ```json<br/>
    /// {<br/>
    ///   "type": "object",<br/>
    ///   "properties": {<br/>
    ///     "name": {"type": "string"},<br/>
    ///     "age": {"type": "integer"}<br/>
    ///   },<br/>
    ///   "required": ["name", "age"]<br/>
    /// }<br/>
    /// ```<br/>
    /// **Note**: This field must not be specified when the `type` is set to `"text"`.
    /// </summary>
    public sealed partial class JsonResponseFormatV2JsonSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}