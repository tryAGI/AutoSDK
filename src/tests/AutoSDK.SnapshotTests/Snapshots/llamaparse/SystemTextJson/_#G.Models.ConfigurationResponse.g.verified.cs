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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Creation timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Last update timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Configuration name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Product type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfigurationResponseProductTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ConfigurationResponseProductType ProductType { get; set; }

        /// <summary>
        /// Version identifier (datetime string).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Product-specific configuration parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Parameters2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Parameters2 Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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