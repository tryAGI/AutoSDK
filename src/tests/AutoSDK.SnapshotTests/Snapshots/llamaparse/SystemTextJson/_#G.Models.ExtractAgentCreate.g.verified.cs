//HintName: G.Models.ExtractAgentCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Settings for creating an extraction agent.
    /// </summary>
    public sealed partial class ExtractAgentCreate
    {
        /// <summary>
        /// The name of the extraction schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The schema of the data.
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
        /// Initializes a new instance of the <see cref="ExtractAgentCreate" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the extraction schema
        /// </param>
        /// <param name="dataSchema">
        /// The schema of the data.
        /// </param>
        /// <param name="config">
        /// The configuration parameters for the extraction agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractAgentCreate(
            string name,
            global::G.AnyOf<object, string> dataSchema,
            global::G.ExtractConfig config)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DataSchema = dataSchema;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractAgentCreate" /> class.
        /// </summary>
        public ExtractAgentCreate()
        {
        }
    }
}