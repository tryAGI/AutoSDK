//HintName: G.Models.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Override,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference value)
        {
            return value switch
            {
                PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference.Default => "default",
                PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference.Disabled => "disabled",
                PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference.Override => "override",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference? ToEnum(string value)
        {
            return value switch
            {
                "default" => PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference.Default,
                "disabled" => PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference.Disabled,
                "override" => PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference.Override,
                _ => null,
            };
        }
    }
}