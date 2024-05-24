//HintName: G.Models.SecretScanningAlertResolutionComment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An optional comment when closing an alert. Cannot be updated or deleted. Must be `null` when changing `state` to `open`.
    /// </summary>
    public sealed partial class SecretScanningAlertResolutionComment
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}