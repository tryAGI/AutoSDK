//HintName: G.Models.EvaluatorResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvaluatorResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="evaluator")]
        Evaluator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluatorResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorResponseType value)
        {
            return value switch
            {
                EvaluatorResponseType.Evaluator => "evaluator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorResponseType? ToEnum(string value)
        {
            return value switch
            {
                "evaluator" => EvaluatorResponseType.Evaluator,
                _ => null,
            };
        }
    }
}