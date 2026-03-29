//HintName: G.Models.AWSStsAuthenticationPlanType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of authentication plan
    /// </summary>
    public enum AWSStsAuthenticationPlanType
    {
        /// <summary>
        /// 
        /// </summary>
        AwsSts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AWSStsAuthenticationPlanTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AWSStsAuthenticationPlanType value)
        {
            return value switch
            {
                AWSStsAuthenticationPlanType.AwsSts => "aws-sts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AWSStsAuthenticationPlanType? ToEnum(string value)
        {
            return value switch
            {
                "aws-sts" => AWSStsAuthenticationPlanType.AwsSts,
                _ => null,
            };
        }
    }
}