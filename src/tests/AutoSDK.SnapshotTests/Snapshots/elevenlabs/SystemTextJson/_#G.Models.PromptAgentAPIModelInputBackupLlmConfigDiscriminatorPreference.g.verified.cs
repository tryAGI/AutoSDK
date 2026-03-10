//HintName: G.Models.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference
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
    public static class PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference value)
        {
            return value switch
            {
                PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference.Default => "default",
                PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference.Disabled => "disabled",
                PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference.Override => "override",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference? ToEnum(string value)
        {
            return value switch
            {
                "default" => PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference.Default,
                "disabled" => PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference.Disabled,
                "override" => PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference.Override,
                _ => null,
            };
        }
    }
}