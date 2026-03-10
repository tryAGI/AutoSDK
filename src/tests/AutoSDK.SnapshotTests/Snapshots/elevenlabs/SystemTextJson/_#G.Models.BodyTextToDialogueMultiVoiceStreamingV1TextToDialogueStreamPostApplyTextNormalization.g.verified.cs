//HintName: G.Models.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This parameter controls text normalization with three modes: 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped.<br/>
    /// Default Value: auto
    /// </summary>
    public enum BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization
    {
        /// <summary>
        /// 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped.
        /// </summary>
        Auto,
        /// <summary>
        /// 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped.
        /// </summary>
        On,
        /// <summary>
        /// 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped.
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization value)
        {
            return value switch
            {
                BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization.Auto => "auto",
                BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization.On => "on",
                BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization.Auto,
                "on" => BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization.On,
                "off" => BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization.Off,
                _ => null,
            };
        }
    }
}