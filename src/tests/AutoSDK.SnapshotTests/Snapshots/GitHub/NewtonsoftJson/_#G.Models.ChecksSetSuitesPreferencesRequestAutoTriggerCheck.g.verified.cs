//HintName: G.Models.ChecksSetSuitesPreferencesRequestAutoTriggerCheck.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChecksSetSuitesPreferencesRequestAutoTriggerCheck
    {
        /// <summary>
        /// The `id` of the GitHub App.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int AppId { get; set; } = default!;

        /// <summary>
        /// Set to `true` to enable automatic creation of CheckSuite events upon pushes to the repository, or `false` to disable them.<br/>
        /// Default Value: true
        /// </summary>
        /// <default>true</default>
        [global::Newtonsoft.Json.JsonProperty("setting", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Setting { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksSetSuitesPreferencesRequestAutoTriggerCheck" /> class.
        /// </summary>
        /// <param name="appId">
        /// The `id` of the GitHub App.
        /// </param>
        /// <param name="setting">
        /// Set to `true` to enable automatic creation of CheckSuite events upon pushes to the repository, or `false` to disable them.<br/>
        /// Default Value: true
        /// </param>
        public ChecksSetSuitesPreferencesRequestAutoTriggerCheck(
            int appId,
            bool setting)
        {
            this.AppId = appId;
            this.Setting = setting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksSetSuitesPreferencesRequestAutoTriggerCheck" /> class.
        /// </summary>
        public ChecksSetSuitesPreferencesRequestAutoTriggerCheck()
        {
        }
    }
}