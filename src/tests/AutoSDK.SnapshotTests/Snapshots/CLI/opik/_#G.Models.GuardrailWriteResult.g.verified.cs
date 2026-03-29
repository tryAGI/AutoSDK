//HintName: G.Models.GuardrailWriteResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GuardrailWriteResult
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Passed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailWriteResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailWriteResult value)
        {
            return value switch
            {
                GuardrailWriteResult.Failed => "failed",
                GuardrailWriteResult.Passed => "passed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailWriteResult? ToEnum(string value)
        {
            return value switch
            {
                "failed" => GuardrailWriteResult.Failed,
                "passed" => GuardrailWriteResult.Passed,
                _ => null,
            };
        }
    }
}