//HintName: G.Models.EvalRunObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the object. Always "eval.run".<br/>
    /// Default Value: eval.run
    /// </summary>
    public enum EvalRunObject
    {
        /// <summary>
        /// 
        /// </summary>
        EvalRun,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalRunObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalRunObject value)
        {
            return value switch
            {
                EvalRunObject.EvalRun => "eval.run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalRunObject? ToEnum(string value)
        {
            return value switch
            {
                "eval.run" => EvalRunObject.EvalRun,
                _ => null,
            };
        }
    }
}