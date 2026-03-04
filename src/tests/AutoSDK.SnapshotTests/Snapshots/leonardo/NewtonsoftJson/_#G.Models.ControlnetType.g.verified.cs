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
        Pose,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANNY")]
        Canny,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DEPTH")]
        Depth,
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
                ControlnetType.Pose => "POSE",
                ControlnetType.Canny => "CANNY",
                ControlnetType.Depth => "DEPTH",
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
                "POSE" => ControlnetType.Pose,
                "CANNY" => ControlnetType.Canny,
                "DEPTH" => ControlnetType.Depth,
                _ => null,
            };
        }
    }
}