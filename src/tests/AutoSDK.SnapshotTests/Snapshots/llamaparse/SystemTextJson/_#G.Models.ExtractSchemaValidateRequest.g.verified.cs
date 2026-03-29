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
        [global::System.Text.Json.Serialization.JsonPropertyName("data_schema")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<object, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<object, string> DataSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractSchemaValidateRequest" /> class.
        /// </summary>
        /// <param name="dataSchema"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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