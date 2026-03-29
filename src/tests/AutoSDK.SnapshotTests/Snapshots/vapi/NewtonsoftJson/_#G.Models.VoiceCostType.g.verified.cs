//HintName: G.Models.VoiceCostType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of cost, always 'voice' for this class.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VoiceCostType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voice")]
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceCostTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceCostType value)
        {
            return value switch
            {
                VoiceCostType.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceCostType? ToEnum(string value)
        {
            return value switch
            {
                "voice" => VoiceCostType.Voice,
                _ => null,
            };
        }
    }
}