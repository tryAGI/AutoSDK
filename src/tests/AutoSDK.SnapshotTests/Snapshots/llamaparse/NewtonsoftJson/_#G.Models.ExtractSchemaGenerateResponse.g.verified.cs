//HintName: G.Models.ExtractSchemaGenerateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response schema for schema generation.
    /// </summary>
    public sealed partial class ExtractSchemaGenerateResponse
    {
        /// <summary>
        /// The generated JSON schema
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object DataSchema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractSchemaGenerateResponse" /> class.
        /// </summary>
        /// <param name="dataSchema">
        /// The generated JSON schema
        /// </param>
        public ExtractSchemaGenerateResponse(
            object dataSchema)
        {
            this.DataSchema = dataSchema ?? throw new global::System.ArgumentNullException(nameof(dataSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractSchemaGenerateResponse" /> class.
        /// </summary>
        public ExtractSchemaGenerateResponse()
        {
        }
    }
}