//HintName: G.Models.ExtractSchemaValidateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request schema for validating an extraction schema.
    /// </summary>
    public sealed partial class ExtractSchemaValidateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<object, string> DataSchema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractSchemaValidateRequest" /> class.
        /// </summary>
        /// <param name="dataSchema"></param>
        public ExtractSchemaValidateRequest(
            global::G.AnyOf<object, string> dataSchema)
        {
            this.DataSchema = dataSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractSchemaValidateRequest" /> class.
        /// </summary>
        public ExtractSchemaValidateRequest()
        {
        }
    }
}