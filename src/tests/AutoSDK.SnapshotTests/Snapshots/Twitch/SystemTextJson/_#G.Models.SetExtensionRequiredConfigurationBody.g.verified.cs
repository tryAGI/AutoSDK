//HintName: G.Models.SetExtensionRequiredConfigurationBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetExtensionRequiredConfigurationBody
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

        /// <summary>
        /// Initializes a new instance of the <see cref="SetExtensionRequiredConfigurationBody" /> class.
        /// </summary>
        /// <param name="extensionId">
        /// The ID of the extension to update.
        /// </param>
        /// <param name="extensionVersion">
        /// The version of the extension to update.
        /// </param>
        /// <param name="requiredConfiguration">
        /// The required\_configuration string to use with the extension.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SetExtensionRequiredConfigurationBody(
            string extensionId,
            string extensionVersion,
            string requiredConfiguration)
        {
            this.ExtensionId = extensionId ?? throw new global::System.ArgumentNullException(nameof(extensionId));
            this.ExtensionVersion = extensionVersion ?? throw new global::System.ArgumentNullException(nameof(extensionVersion));
            this.RequiredConfiguration = requiredConfiguration ?? throw new global::System.ArgumentNullException(nameof(requiredConfiguration));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetExtensionRequiredConfigurationBody" /> class.
        /// </summary>
        public SetExtensionRequiredConfigurationBody()
        {
        }
    }
}