//HintName: G.Models.BodyTextToDialogueFullWithTimestampsApplyTextNormalization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This parameter controls text normalization with three modes: 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped.<br/>
    /// Default Value: auto
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyTextToDialogueFullWithTimestampsApplyTextNormalization
    {
        /// <summary>
        /// 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="on")]
        On,
        /// <summary>
        /// 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off")]
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyTextToDialogueFullWithTimestampsApplyTextNormalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyTextToDialogueFullWithTimestampsApplyTextNormalization value)
        {
            return value switch
            {
                BodyTextToDialogueFullWithTimestampsApplyTextNormalization.Auto => "auto",
                BodyTextToDialogueFullWithTimestampsApplyTextNormalization.On => "on",
                BodyTextToDialogueFullWithTimestampsApplyTextNormalization.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyTextToDialogueFullWithTimestampsApplyTextNormalization? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BodyTextToDialogueFullWithTimestampsApplyTextNormalization.Auto,
                "on" => BodyTextToDialogueFullWithTimestampsApplyTextNormalization.On,
                "off" => BodyTextToDialogueFullWithTimestampsApplyTextNormalization.Off,
                _ => null,
            };
        }
    }
}