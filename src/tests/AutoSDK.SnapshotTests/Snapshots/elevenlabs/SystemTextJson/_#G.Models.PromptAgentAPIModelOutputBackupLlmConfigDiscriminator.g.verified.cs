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
        [global::System.Text.Json.Serialization.JsonPropertyName("preference")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceJsonConverter))]
        public global::G.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference? Preference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentAPIModelOutputBackupLlmConfigDiscriminator" /> class.
        /// </summary>
        /// <param name="preference"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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