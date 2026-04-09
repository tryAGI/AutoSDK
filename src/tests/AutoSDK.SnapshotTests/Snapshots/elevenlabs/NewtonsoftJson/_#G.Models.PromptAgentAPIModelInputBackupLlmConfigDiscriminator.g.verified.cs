//HintName: G.Models.PromptAgentAPIModelInputBackupLlmConfigDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAgentAPIModelInputBackupLlmConfigDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preference")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreferenceJsonConverter))]
        public global::G.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference? Preference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentAPIModelInputBackupLlmConfigDiscriminator" /> class.
        /// </summary>
        /// <param name="preference"></param>
        public PromptAgentAPIModelInputBackupLlmConfigDiscriminator(
            global::G.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference? preference)
        {
            this.Preference = preference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentAPIModelInputBackupLlmConfigDiscriminator" /> class.
        /// </summary>
        public PromptAgentAPIModelInputBackupLlmConfigDiscriminator()
        {
        }
    }
}