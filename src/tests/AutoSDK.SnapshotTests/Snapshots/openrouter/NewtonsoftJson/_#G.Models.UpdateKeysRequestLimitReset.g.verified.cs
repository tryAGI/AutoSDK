//HintName: G.Models.UpdateKeysRequestLimitReset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// New limit reset type for the API key (daily, weekly, monthly, or null for no reset). Resets happen automatically at midnight UTC, and weeks are Monday through Sunday.
    /// </summary>
    public sealed partial class UpdateKeysRequestLimitReset
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}