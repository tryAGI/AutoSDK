//HintName: G.Models.EvalStringCheckGraderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `string_check`.
    /// </summary>
    public enum EvalStringCheckGraderType
    {
        /// <summary>
        /// 
        /// </summary>
        StringCheck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalStringCheckGraderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalStringCheckGraderType value)
        {
            return value switch
            {
                EvalStringCheckGraderType.StringCheck => "string_check",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalStringCheckGraderType? ToEnum(string value)
        {
            return value switch
            {
                "string_check" => EvalStringCheckGraderType.StringCheck,
                _ => null,
            };
        }
    }
}