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
        [global::System.Text.Json.Serialization.JsonPropertyName("data_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object DataSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractV2SchemaValidateRequest" /> class.
        /// </summary>
        /// <param name="dataSchema">
        /// JSON Schema to validate for use with extract jobs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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