//HintName: G.Models.EvaluationSuccessResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EvaluationSuccessResult
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Failure,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationSuccessResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationSuccessResult value)
        {
            return value switch
            {
                EvaluationSuccessResult.Success => "success",
                EvaluationSuccessResult.Failure => "failure",
                EvaluationSuccessResult.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationSuccessResult? ToEnum(string value)
        {
            return value switch
            {
                "success" => EvaluationSuccessResult.Success,
                "failure" => EvaluationSuccessResult.Failure,
                "unknown" => EvaluationSuccessResult.Unknown,
                _ => null,
            };
        }
    }
}