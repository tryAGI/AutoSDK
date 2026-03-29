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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Product-specific configuration parameters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Parameters Parameters { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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