//HintName: G.Models.WebhookCodeScanningAlertReopenedByUserAlertTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookCodeScanningAlertReopenedByUserAlertTool
    {
        /// <summary>
        /// The name of the tool used to generate the code scanning analysis alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The version of the tool used to detect the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertReopenedByUserAlertTool" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the tool used to generate the code scanning analysis alert.
        /// </param>
        /// <param name="version">
        /// The version of the tool used to detect the alert.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookCodeScanningAlertReopenedByUserAlertTool(
            string name,
            string? version)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertReopenedByUserAlertTool" /> class.
        /// </summary>
        public WebhookCodeScanningAlertReopenedByUserAlertTool()
        {
        }
    }
}