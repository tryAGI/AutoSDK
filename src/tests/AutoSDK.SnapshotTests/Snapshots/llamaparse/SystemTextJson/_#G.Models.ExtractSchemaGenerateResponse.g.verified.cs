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
        [global::System.Text.Json.Serialization.JsonPropertyName("data_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object DataSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractSchemaGenerateResponse" /> class.
        /// </summary>
        /// <param name="dataSchema">
        /// The generated JSON schema
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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