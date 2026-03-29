//HintName: G.Models.ApiProjectResponseDubbingType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Dubbing Type
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApiProjectResponseDubbingType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AUTOMATED")]
        Automated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="QA")]
        Qa,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiProjectResponseDubbingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiProjectResponseDubbingType value)
        {
            return value switch
            {
                ApiProjectResponseDubbingType.Automated => "AUTOMATED",
                ApiProjectResponseDubbingType.Qa => "QA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiProjectResponseDubbingType? ToEnum(string value)
        {
            return value switch
            {
                "AUTOMATED" => ApiProjectResponseDubbingType.Automated,
                "QA" => ApiProjectResponseDubbingType.Qa,
                _ => null,
            };
        }
    }
}