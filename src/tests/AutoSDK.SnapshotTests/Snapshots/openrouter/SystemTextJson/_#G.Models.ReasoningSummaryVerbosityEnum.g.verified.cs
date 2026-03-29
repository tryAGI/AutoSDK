//HintName: G.Models.ReasoningSummaryVerbosityEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReasoningSummaryVerbosityEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Concise,
        /// <summary>
        /// 
        /// </summary>
        Detailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningSummaryVerbosityEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningSummaryVerbosityEnum value)
        {
            return value switch
            {
                ReasoningSummaryVerbosityEnum.Auto => "auto",
                ReasoningSummaryVerbosityEnum.Concise => "concise",
                ReasoningSummaryVerbosityEnum.Detailed => "detailed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningSummaryVerbosityEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ReasoningSummaryVerbosityEnum.Auto,
                "concise" => ReasoningSummaryVerbosityEnum.Concise,
                "detailed" => ReasoningSummaryVerbosityEnum.Detailed,
                _ => null,
            };
        }
    }
}