//HintName: G.Models.AnalysisCostType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of cost, always 'analysis' for this class.
    /// </summary>
    public enum AnalysisCostType
    {
        /// <summary>
        /// 
        /// </summary>
        Analysis,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalysisCostTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalysisCostType value)
        {
            return value switch
            {
                AnalysisCostType.Analysis => "analysis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalysisCostType? ToEnum(string value)
        {
            return value switch
            {
                "analysis" => AnalysisCostType.Analysis,
                _ => null,
            };
        }
    }
}