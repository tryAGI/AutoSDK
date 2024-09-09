//HintName: G.Models.CustomModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CustomModelType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="j2-large")]
        J2Large,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="j2-grande")]
        J2Grande,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="j2-jumbo")]
        J2Jumbo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="j2-light")]
        J2Light,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="j2-mid")]
        J2Mid,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="j2-ultra")]
        J2Ultra,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomModelType value)
        {
            return value switch
            {
                CustomModelType.J2Large => "j2-large",
                CustomModelType.J2Grande => "j2-grande",
                CustomModelType.J2Jumbo => "j2-jumbo",
                CustomModelType.J2Light => "j2-light",
                CustomModelType.J2Mid => "j2-mid",
                CustomModelType.J2Ultra => "j2-ultra",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomModelType? ToEnum(string value)
        {
            return value switch
            {
                "j2-large" => CustomModelType.J2Large,
                "j2-grande" => CustomModelType.J2Grande,
                "j2-jumbo" => CustomModelType.J2Jumbo,
                "j2-light" => CustomModelType.J2Light,
                "j2-mid" => CustomModelType.J2Mid,
                "j2-ultra" => CustomModelType.J2Ultra,
                _ => null,
            };
        }
    }
}