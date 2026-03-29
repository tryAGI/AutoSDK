//HintName: G.Models.ExtractV2SchemaValidateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response schema for schema validation.
    /// </summary>
    public sealed partial class ExtractV2SchemaValidateResponse
    {
        /// <summary>
        /// Validated JSON Schema, ready for use in extract jobs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object DataSchema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractV2SchemaValidateResponse" /> class.
        /// </summary>
        /// <param name="dataSchema">
        /// Validated JSON Schema, ready for use in extract jobs
        /// </param>
        public ExtractV2SchemaValidateResponse(
            object dataSchema)
        {
            this.DataSchema = dataSchema ?? throw new global::System.ArgumentNullException(nameof(dataSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractV2SchemaValidateResponse" /> class.
        /// </summary>
        public ExtractV2SchemaValidateResponse()
        {
        }
    }
}