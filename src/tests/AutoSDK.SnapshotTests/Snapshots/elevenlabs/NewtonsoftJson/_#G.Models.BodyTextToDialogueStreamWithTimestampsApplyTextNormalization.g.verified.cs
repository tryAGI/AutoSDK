//HintName: G.Models.BodyTextToDialogueStreamWithTimestampsApplyTextNormalization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This parameter controls text normalization with three modes: 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped.<br/>
    /// Default Value: auto
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyTextToDialogueStreamWithTimestampsApplyTextNormalization
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
    public static class BodyTextToDialogueStreamWithTimestampsApplyTextNormalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyTextToDialogueStreamWithTimestampsApplyTextNormalization value)
        {
            return value switch
            {
                BodyTextToDialogueStreamWithTimestampsApplyTextNormalization.Auto => "auto",
                BodyTextToDialogueStreamWithTimestampsApplyTextNormalization.On => "on",
                BodyTextToDialogueStreamWithTimestampsApplyTextNormalization.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyTextToDialogueStreamWithTimestampsApplyTextNormalization? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BodyTextToDialogueStreamWithTimestampsApplyTextNormalization.Auto,
                "on" => BodyTextToDialogueStreamWithTimestampsApplyTextNormalization.On,
                "off" => BodyTextToDialogueStreamWithTimestampsApplyTextNormalization.Off,
                _ => null,
            };
        }
    }
}