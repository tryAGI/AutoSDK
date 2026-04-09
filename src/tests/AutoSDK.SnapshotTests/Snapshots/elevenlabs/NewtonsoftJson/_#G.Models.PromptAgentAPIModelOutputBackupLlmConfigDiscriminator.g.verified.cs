//HintName: G.Models.PromptAgentAPIModelOutputBackupLlmConfigDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAgentAPIModelOutputBackupLlmConfigDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preference")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceJsonConverter))]
        public global::G.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference? Preference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentAPIModelOutputBackupLlmConfigDiscriminator" /> class.
        /// </summary>
        /// <param name="preference"></param>
        public PromptAgentAPIModelOutputBackupLlmConfigDiscriminator(
            global::G.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference? preference)
        {
            this.Preference = preference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentAPIModelOutputBackupLlmConfigDiscriminator" /> class.
        /// </summary>
        public PromptAgentAPIModelOutputBackupLlmConfigDiscriminator()
        {
        }
    }
}