//HintName: G.Models.ChecksSetSuitesPreferencesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChecksSetSuitesPreferencesRequest
    {
        /// <summary>
        /// Enables or disables automatic creation of CheckSuite events upon pushes to the repository. Enabled by default.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_trigger_checks")]
        public global::System.Collections.Generic.IList<ChecksSetSuitesPreferencesRequestAutoTriggerChecks?>? AutoTriggerChecks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}