//HintName: G.Models.TransferOptionAgenticWarmTransferOnHoldMusic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The music to play while the caller is being transferred.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TransferOptionAgenticWarmTransferOnHoldMusic
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
    public static class TransferOptionAgenticWarmTransferOnHoldMusicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferOptionAgenticWarmTransferOnHoldMusic value)
        {
            return value switch
            {
                TransferOptionAgenticWarmTransferOnHoldMusic.None => "none",
                TransferOptionAgenticWarmTransferOnHoldMusic.RelaxingSound => "relaxing_sound",
                TransferOptionAgenticWarmTransferOnHoldMusic.Ringtone => "ringtone",
                TransferOptionAgenticWarmTransferOnHoldMusic.UpliftingBeats => "uplifting_beats",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferOptionAgenticWarmTransferOnHoldMusic? ToEnum(string value)
        {
            return value switch
            {
                "none" => TransferOptionAgenticWarmTransferOnHoldMusic.None,
                "relaxing_sound" => TransferOptionAgenticWarmTransferOnHoldMusic.RelaxingSound,
                "ringtone" => TransferOptionAgenticWarmTransferOnHoldMusic.Ringtone,
                "uplifting_beats" => TransferOptionAgenticWarmTransferOnHoldMusic.UpliftingBeats,
                _ => null,
            };
        }
    }
}