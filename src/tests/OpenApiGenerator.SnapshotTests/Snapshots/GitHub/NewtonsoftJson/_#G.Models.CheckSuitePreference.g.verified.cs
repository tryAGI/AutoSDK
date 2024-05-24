//HintName: G.Models.CheckSuitePreference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Check suite configuration preferences for a repository.
    /// </summary>
    public sealed partial class CheckSuitePreference
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preferences", Required = global::Newtonsoft.Json.Required.Always)]
        public CheckSuitePreferencePreferences Preferences { get; set; } = default!;

        /// <summary>
        /// Minimal Repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public MinimalRepository Repository { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}