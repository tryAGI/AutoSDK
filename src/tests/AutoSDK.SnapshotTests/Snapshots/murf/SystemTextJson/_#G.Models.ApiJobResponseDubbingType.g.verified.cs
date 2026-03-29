//HintName: G.Models.ApiJobResponseDubbingType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Dubbing Type
    /// </summary>
    public enum ApiJobResponseDubbingType
    {
        /// <summary>
        /// 
        /// </summary>
        Automated,
        /// <summary>
        /// 
        /// </summary>
        Qa,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiJobResponseDubbingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiJobResponseDubbingType value)
        {
            return value switch
            {
                ApiJobResponseDubbingType.Automated => "AUTOMATED",
                ApiJobResponseDubbingType.Qa => "QA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiJobResponseDubbingType? ToEnum(string value)
        {
            return value switch
            {
                "AUTOMATED" => ApiJobResponseDubbingType.Automated,
                "QA" => ApiJobResponseDubbingType.Qa,
                _ => null,
            };
        }
    }
}