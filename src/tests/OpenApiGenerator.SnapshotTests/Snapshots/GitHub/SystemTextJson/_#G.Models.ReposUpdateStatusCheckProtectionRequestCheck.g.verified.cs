//HintName: G.Models.ReposUpdateStatusCheckProtectionRequestCheck.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposUpdateStatusCheckProtectionRequestCheck
    {
        /// <summary>
        /// The name of the required check
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Context { get; set; }

        /// <summary>
        /// The ID of the GitHub App that must provide this check. Omit this field to automatically select the GitHub App that has recently provided this check, or any app if it was not set by a GitHub App. Pass -1 to explicitly allow any app to set the status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public int AppId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}