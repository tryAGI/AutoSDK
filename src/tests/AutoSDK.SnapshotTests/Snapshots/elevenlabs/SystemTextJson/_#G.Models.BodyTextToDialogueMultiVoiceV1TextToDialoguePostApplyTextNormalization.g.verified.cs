//HintName: G.Models.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This parameter controls text normalization with three modes: 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped.<br/>
    /// Default Value: auto
    /// </summary>
    public enum BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization
    {
        /// <summary>
        /// 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped.
        /// </summary>
        Auto,
        /// <summary>
        /// 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped.
        /// </summary>
        Off,
        /// <summary>
        /// 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped.
        /// </summary>
        On,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization value)
        {
            return value switch
            {
                BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization.Auto => "auto",
                BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization.Off => "off",
                BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization.Auto,
                "off" => BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization.Off,
                "on" => BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization.On,
                _ => null,
            };
        }
    }
}