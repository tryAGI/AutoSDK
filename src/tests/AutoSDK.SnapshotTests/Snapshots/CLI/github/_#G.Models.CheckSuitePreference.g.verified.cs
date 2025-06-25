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
        [global::System.Text.Json.Serialization.JsonPropertyName("preferences")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CheckSuitePreferencePreferences Preferences { get; set; }

        /// <summary>
        /// Minimal Repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MinimalRepository Repository { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckSuitePreference" /> class.
        /// </summary>
        /// <param name="preferences"></param>
        /// <param name="repository">
        /// Minimal Repository
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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