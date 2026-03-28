//HintName: G.Models.WebhookCodeScanningAlertReopenedAlertTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookCodeScanningAlertReopenedAlertTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("guid")]
        public string? Guid { get; set; }

        /// <summary>
        /// The name of the tool used to generate the code scanning analysis alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The version of the tool used to detect the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertReopenedAlertTool" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the tool used to generate the code scanning analysis alert.
        /// </param>
        /// <param name="guid"></param>
        /// <param name="version">
        /// The version of the tool used to detect the alert.
        /// </param>
        public WebhookCodeScanningAlertReopenedAlertTool(
            string name,
            string? guid,
            string? version)
        {
            this.Guid = guid;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertReopenedAlertTool" /> class.
        /// </summary>
        public WebhookCodeScanningAlertReopenedAlertTool()
        {
        }
    }
}