//HintName: G.Models.ConfigurationUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for updating a product configuration.
    /// </summary>
    public sealed partial class ConfigurationUpdateRequest
    {
        /// <summary>
        /// Updated name (omit to leave unchanged).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Updated parameters (omit to leave unchanged).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::G.ParametersVariant1? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Updated name (omit to leave unchanged).
        /// </param>
        /// <param name="parameters">
        /// Updated parameters (omit to leave unchanged).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigurationUpdateRequest(
            string? name,
            global::G.ParametersVariant1? parameters)
        {
            this.Name = name;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationUpdateRequest" /> class.
        /// </summary>
        public ConfigurationUpdateRequest()
        {
        }
    }
}