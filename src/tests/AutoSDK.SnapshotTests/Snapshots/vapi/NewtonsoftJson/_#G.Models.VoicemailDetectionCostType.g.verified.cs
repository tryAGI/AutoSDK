//HintName: G.Models.VoicemailDetectionCostType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of cost, always 'voicemail-detection' for this class.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VoicemailDetectionCostType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voicemail-detection")]
        VoicemailDetection,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoicemailDetectionCostTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicemailDetectionCostType value)
        {
            return value switch
            {
                VoicemailDetectionCostType.VoicemailDetection => "voicemail-detection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicemailDetectionCostType? ToEnum(string value)
        {
            return value switch
            {
                "voicemail-detection" => VoicemailDetectionCostType.VoicemailDetection,
                _ => null,
            };
        }
    }
}