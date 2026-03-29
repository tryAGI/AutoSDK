//HintName: G.Models.ExtractV2SchemaValidateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request schema for validating an extraction schema.
    /// </summary>
    public sealed partial class ExtractV2SchemaValidateRequest
    {
        /// <summary>
        /// JSON Schema to validate for use with extract jobs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object DataSchema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractV2SchemaValidateRequest" /> class.
        /// </summary>
        /// <param name="dataSchema">
        /// JSON Schema to validate for use with extract jobs
        /// </param>
        public ExtractV2SchemaValidateRequest(
            object dataSchema)
        {
            this.DataSchema = dataSchema ?? throw new global::System.ArgumentNullException(nameof(dataSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractV2SchemaValidateRequest" /> class.
        /// </summary>
        public ExtractV2SchemaValidateRequest()
        {
        }
    }
}