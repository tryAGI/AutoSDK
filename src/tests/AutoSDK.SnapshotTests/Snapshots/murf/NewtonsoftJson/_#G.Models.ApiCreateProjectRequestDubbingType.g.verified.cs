//HintName: G.Models.ApiCreateProjectRequestDubbingType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApiCreateProjectRequestDubbingType
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
    public static class ApiCreateProjectRequestDubbingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiCreateProjectRequestDubbingType value)
        {
            return value switch
            {
                ApiCreateProjectRequestDubbingType.Automated => "AUTOMATED",
                ApiCreateProjectRequestDubbingType.Qa => "QA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiCreateProjectRequestDubbingType? ToEnum(string value)
        {
            return value switch
            {
                "AUTOMATED" => ApiCreateProjectRequestDubbingType.Automated,
                "QA" => ApiCreateProjectRequestDubbingType.Qa,
                _ => null,
            };
        }
    }
}