//HintName: G.Models.EvalCustomDataSourceConfigSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The json schema for the run data source items.<br/>
    /// Learn how to build JSON schemas [here](https://json-schema.org/).<br/>
    /// Example: {<br/>
    ///   "type": "object",<br/>
    ///   "properties": {<br/>
    ///     "item": {<br/>
    ///       "type": "object",<br/>
    ///       "properties": {<br/>
    ///         "label": {"type": "string"},<br/>
    ///       },<br/>
    ///       "required": ["label"]<br/>
    ///     }<br/>
    ///   },<br/>
    ///   "required": ["item"]<br/>
    /// }
    /// </summary>
    public sealed partial class EvalCustomDataSourceConfigSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}