//HintName: G.Models.EvalRunType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the run.<br/>
    /// Currently it is fixed to `eval`.<br/>
    /// Example: eval
    /// </summary>
    public enum EvalRunType
    {
        /// <summary>
        /// 
        /// </summary>
        Eval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalRunTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalRunType value)
        {
            return value switch
            {
                EvalRunType.Eval => "eval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalRunType? ToEnum(string value)
        {
            return value switch
            {
                "eval" => EvalRunType.Eval,
                _ => null,
            };
        }
    }
}