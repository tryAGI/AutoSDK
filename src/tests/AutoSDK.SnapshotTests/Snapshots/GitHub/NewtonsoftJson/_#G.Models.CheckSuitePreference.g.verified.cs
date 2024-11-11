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
        public global::G.CheckSuitePreferencePreferences Preferences { get; set; } = default!;

        /// <summary>
        /// Minimal Repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MinimalRepository Repository { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckSuitePreference" /> class.
        /// </summary>
        /// <param name="preferences"></param>
        /// <param name="repository">
        /// Minimal Repository
        /// </param>
        public CheckSuitePreference(
            global::G.CheckSuitePreferencePreferences preferences,
            global::G.MinimalRepository repository)
        {
            this.Preferences = preferences ?? throw new global::System.ArgumentNullException(nameof(preferences));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckSuitePreference" /> class.
        /// </summary>
        public CheckSuitePreference()
        {
        }
    }
}