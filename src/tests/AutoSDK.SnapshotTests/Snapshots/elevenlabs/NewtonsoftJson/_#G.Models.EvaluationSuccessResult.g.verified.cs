//HintName: G.Models.EvaluationSuccessResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvaluationSuccessResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failure")]
        Failure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
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