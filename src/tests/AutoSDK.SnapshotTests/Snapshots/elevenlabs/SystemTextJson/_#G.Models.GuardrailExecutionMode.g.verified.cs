//HintName: G.Models.GuardrailExecutionMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GuardrailExecutionMode
    {
        /// <summary>
        /// 
        /// </summary>
        Blocking,
        /// <summary>
        /// 
        /// </summary>
        Streaming,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailExecutionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailExecutionMode value)
        {
            return value switch
            {
                GuardrailExecutionMode.Blocking => "blocking",
                GuardrailExecutionMode.Streaming => "streaming",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailExecutionMode? ToEnum(string value)
        {
            return value switch
            {
                "blocking" => GuardrailExecutionMode.Blocking,
                "streaming" => GuardrailExecutionMode.Streaming,
                _ => null,
            };
        }
    }
}