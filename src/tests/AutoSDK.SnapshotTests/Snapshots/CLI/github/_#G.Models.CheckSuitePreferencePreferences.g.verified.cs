//HintName: G.Models.CheckSuitePreferencePreferences.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckSuitePreferencePreferences
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_trigger_checks")]
        public global::System.Collections.Generic.IList<global::G.CheckSuitePreferencePreferencesAutoTriggerCheck>? AutoTriggerChecks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckSuitePreferencePreferences" /> class.
        /// </summary>
        /// <param name="autoTriggerChecks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckSuitePreferencePreferences(
            global::System.Collections.Generic.IList<global::G.CheckSuitePreferencePreferencesAutoTriggerCheck>? autoTriggerChecks)
        {
            this.AutoTriggerChecks = autoTriggerChecks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckSuitePreferencePreferences" /> class.
        /// </summary>
        public CheckSuitePreferencePreferences()
        {
        }
    }
}