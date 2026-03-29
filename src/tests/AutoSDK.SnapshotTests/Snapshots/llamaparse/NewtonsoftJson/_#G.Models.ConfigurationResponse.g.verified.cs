//HintName: G.Models.ConfigurationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response schema for a single product configuration.
    /// </summary>
    public sealed partial class ConfigurationResponse
    {
        /// <summary>
        /// Unique configuration ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Creation timestamp.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Last update timestamp.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Configuration name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Product type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("product_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConfigurationResponseProductType ProductType { get; set; } = default!;

        /// <summary>
        /// Version identifier (datetime string).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// Product-specific configuration parameters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Parameters2 Parameters { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique configuration ID.
        /// </param>
        /// <param name="name">
        /// Configuration name.
        /// </param>
        /// <param name="productType">
        /// Product type.
        /// </param>
        /// <param name="version">
        /// Version identifier (datetime string).
        /// </param>
        /// <param name="parameters">
        /// Product-specific configuration parameters.
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp.
        /// </param>
        /// <param name="updatedAt">
        /// Last update timestamp.
        /// </param>
        public ConfigurationResponse(
            string id,
            string name,
            global::G.ConfigurationResponseProductType productType,
            string version,
            global::G.Parameters2 parameters,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProductType = productType;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationResponse" /> class.
        /// </summary>
        public ConfigurationResponse()
        {
        }
    }
}