//HintName: G.Models.EvalResponsesSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of run data source. Always `responses`.
    /// </summary>
    public enum EvalResponsesSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Responses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalResponsesSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalResponsesSourceType value)
        {
            return value switch
            {
                EvalResponsesSourceType.Responses => "responses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalResponsesSourceType? ToEnum(string value)
        {
            return value switch
            {
                "responses" => EvalResponsesSourceType.Responses,
                _ => null,
            };
        }
    }
}