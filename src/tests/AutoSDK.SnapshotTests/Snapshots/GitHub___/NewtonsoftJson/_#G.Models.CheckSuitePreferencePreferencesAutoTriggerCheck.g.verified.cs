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
        [global::Newtonsoft.Json.JsonProperty("app_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int AppId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("setting", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Setting { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckSuitePreferencePreferencesAutoTriggerCheck" /> class.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="setting"></param>
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