//HintName: G.Models.WebhooksCodeScanningRef.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Git reference of the code scanning alert. When the action is `reopened_by_user` or `closed_by_user`, the event was triggered by the `sender` and this value will be empty.
    /// </summary>
    public sealed partial class WebhooksCodeScanningRef
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}