//HintName: G.Models.SetExtensionRequiredConfigurationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetExtensionRequiredConfigurationRequest
    {
        /// <summary>
        /// The ID of the extension to update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extension_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExtensionId { get; set; }

        /// <summary>
        /// The version of the extension to update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extension_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExtensionVersion { get; set; }

        /// <summary>
        /// The required\_configuration string to use with the extension.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequiredConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}