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
        [global::Newtonsoft.Json.JsonProperty("extension_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExtensionId { get; set; } = default!;

        /// <summary>
        /// The version of the extension to update.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extension_version", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExtensionVersion { get; set; } = default!;

        /// <summary>
        /// The required\_configuration string to use with the extension.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_configuration", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequiredConfiguration { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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