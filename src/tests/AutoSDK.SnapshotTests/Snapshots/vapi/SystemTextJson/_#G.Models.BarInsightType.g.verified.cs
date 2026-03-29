//HintName: G.Models.BarInsightType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the Insight.<br/>
    /// It is required to be `bar` to create a bar insight.
    /// </summary>
    public enum BarInsightType
    {
        /// <summary>
        /// 
        /// </summary>
        Bar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BarInsightTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BarInsightType value)
        {
            return value switch
            {
                BarInsightType.Bar => "bar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BarInsightType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => BarInsightType.Bar,
                _ => null,
            };
        }
    }
}