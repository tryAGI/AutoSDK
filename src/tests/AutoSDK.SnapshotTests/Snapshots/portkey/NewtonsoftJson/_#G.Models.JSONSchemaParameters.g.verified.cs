//HintName: G.Models.JSONSchemaParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JSONSchemaParameters
    {
        /// <summary>
        /// JSON schema to validate against
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object Schema { get; set; } = default!;

        /// <summary>
        /// If true, the verdict will be inverted<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("not")]
        public bool? Not { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JSONSchemaParameters" /> class.
        /// </summary>
        /// <param name="schema">
        /// JSON schema to validate against
        /// </param>
        /// <param name="not">
        /// If true, the verdict will be inverted<br/>
        /// Default Value: false
        /// </param>
        public JSONSchemaParameters(
            object schema,
            bool? not)
        {
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Not = not;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JSONSchemaParameters" /> class.
        /// </summary>
        public JSONSchemaParameters()
        {
        }
    }
}