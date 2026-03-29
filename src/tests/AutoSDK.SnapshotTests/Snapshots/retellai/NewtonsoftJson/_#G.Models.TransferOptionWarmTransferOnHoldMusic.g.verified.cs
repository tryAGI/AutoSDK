//HintName: G.Models.TransferOptionWarmTransferOnHoldMusic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The music to play while the caller is being transferred.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TransferOptionWarmTransferOnHoldMusic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="relaxing_sound")]
        RelaxingSound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ringtone")]
        Ringtone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uplifting_beats")]
        UpliftingBeats,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferOptionWarmTransferOnHoldMusicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferOptionWarmTransferOnHoldMusic value)
        {
            return value switch
            {
                TransferOptionWarmTransferOnHoldMusic.None => "none",
                TransferOptionWarmTransferOnHoldMusic.RelaxingSound => "relaxing_sound",
                TransferOptionWarmTransferOnHoldMusic.Ringtone => "ringtone",
                TransferOptionWarmTransferOnHoldMusic.UpliftingBeats => "uplifting_beats",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferOptionWarmTransferOnHoldMusic? ToEnum(string value)
        {
            return value switch
            {
                "none" => TransferOptionWarmTransferOnHoldMusic.None,
                "relaxing_sound" => TransferOptionWarmTransferOnHoldMusic.RelaxingSound,
                "ringtone" => TransferOptionWarmTransferOnHoldMusic.Ringtone,
                "uplifting_beats" => TransferOptionWarmTransferOnHoldMusic.UpliftingBeats,
                _ => null,
            };
        }
    }
}