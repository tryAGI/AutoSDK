//HintName: G.Models.CheckSuitePreferencePreferencesAutoTriggerCheck.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckSuitePreferencePreferencesAutoTriggerCheck
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AppId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setting")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Setting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckSuitePreferencePreferencesAutoTriggerCheck" /> class.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="setting"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckSuitePreferencePreferencesAutoTriggerCheck(
            int appId,
            bool setting)
        {
            this.AppId = appId;
            this.Setting = setting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckSuitePreferencePreferencesAutoTriggerCheck" /> class.
        /// </summary>
        public CheckSuitePreferencePreferencesAutoTriggerCheck()
        {
        }
    }
}