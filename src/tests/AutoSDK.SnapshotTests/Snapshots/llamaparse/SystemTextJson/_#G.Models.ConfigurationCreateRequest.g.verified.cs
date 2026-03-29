//HintName: G.Models.ConfigurationCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for creating a product configuration.
    /// </summary>
    public sealed partial class ConfigurationCreateRequest
    {
        /// <summary>
        /// Human-readable name for this configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Product-specific configuration parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ParametersJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Parameters Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable name for this configuration.
        /// </param>
        /// <param name="parameters">
        /// Product-specific configuration parameters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigurationCreateRequest(
            string name,
            global::G.Parameters parameters)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationCreateRequest" /> class.
        /// </summary>
        public ConfigurationCreateRequest()
        {
        }
    }
}