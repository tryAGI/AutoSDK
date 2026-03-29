//HintName: G.Models.ExtractAgentUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Settings for updating an extraction schema.
    /// </summary>
    public sealed partial class ExtractAgentUpdate
    {
        /// <summary>
        /// The schema of the data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_schema")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<object, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<object, string> DataSchema { get; set; }

        /// <summary>
        /// The configuration parameters for the extraction agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExtractConfig Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractAgentUpdate" /> class.
        /// </summary>
        /// <param name="dataSchema">
        /// The schema of the data
        /// </param>
        /// <param name="config">
        /// The configuration parameters for the extraction agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractAgentUpdate(
            global::G.AnyOf<object, string> dataSchema,
            global::G.ExtractConfig config)
        {
            this.DataSchema = dataSchema;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractAgentUpdate" /> class.
        /// </summary>
        public ExtractAgentUpdate()
        {
        }
    }
}