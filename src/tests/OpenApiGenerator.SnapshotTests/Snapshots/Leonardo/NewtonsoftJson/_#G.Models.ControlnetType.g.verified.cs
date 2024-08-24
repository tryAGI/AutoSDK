//HintName: G.Models.ControlnetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This parameter will be deprecated in September 2024. Please use the controlnets array instead.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ControlnetType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="POSE")]
        POSE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANNY")]
        CANNY,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DEPTH")]
        DEPTH,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ControlnetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ControlnetType value)
        {
            return value switch
            {
                ControlnetType.POSE => "POSE",
                ControlnetType.CANNY => "CANNY",
                ControlnetType.DEPTH => "DEPTH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ControlnetType? ToEnum(string value)
        {
            return value switch
            {
                "POSE" => ControlnetType.POSE,
                "CANNY" => ControlnetType.CANNY,
                "DEPTH" => ControlnetType.DEPTH,
                _ => null,
            };
        }
    }
}