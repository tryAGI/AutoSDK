//HintName: G.Models.OutputMessagePhase1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputMessagePhase1
    {
        /// <summary>
        /// 
        /// </summary>
        FinalAnswer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputMessagePhase1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputMessagePhase1 value)
        {
            return value switch
            {
                OutputMessagePhase1.FinalAnswer => "final_answer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputMessagePhase1? ToEnum(string value)
        {
            return value switch
            {
                "final_answer" => OutputMessagePhase1.FinalAnswer,
                _ => null,
            };
        }
    }
}