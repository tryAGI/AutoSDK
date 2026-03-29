//HintName: G.Models.EvalRunResultStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the status of the eval run result.<br/>
    /// The status is only 'pass' or 'fail' for an eval run result.<br/>
    /// Currently, An eval is considered `pass` only if all the Assistant Judge messages are evaluated to pass.<br/>
    /// Example: pass
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalRunResultStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fail")]
        Fail,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pass")]
        Pass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalRunResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalRunResultStatus value)
        {
            return value switch
            {
                EvalRunResultStatus.Fail => "fail",
                EvalRunResultStatus.Pass => "pass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalRunResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "fail" => EvalRunResultStatus.Fail,
                "pass" => EvalRunResultStatus.Pass,
                _ => null,
            };
        }
    }
}