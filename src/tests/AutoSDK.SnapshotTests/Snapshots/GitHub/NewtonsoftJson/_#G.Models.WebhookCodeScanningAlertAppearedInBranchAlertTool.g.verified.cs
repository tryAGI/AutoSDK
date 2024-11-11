//HintName: G.Models.WebhookCodeScanningAlertAppearedInBranchAlertTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookCodeScanningAlertAppearedInBranchAlertTool
    {
        /// <summary>
        /// The name of the tool used to generate the code scanning analysis alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The version of the tool used to detect the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Version { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertAppearedInBranchAlertTool" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the tool used to generate the code scanning analysis alert.
        /// </param>
        /// <param name="version">
        /// The version of the tool used to detect the alert.
        /// </param>
        public WebhookCodeScanningAlertAppearedInBranchAlertTool(
            string name,
            string? version)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertAppearedInBranchAlertTool" /> class.
        /// </summary>
        public WebhookCodeScanningAlertAppearedInBranchAlertTool()
        {
        }
    }
}