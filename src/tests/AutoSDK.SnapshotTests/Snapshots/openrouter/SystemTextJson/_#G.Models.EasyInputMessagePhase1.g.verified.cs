//HintName: G.Models.EasyInputMessagePhase1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EasyInputMessagePhase1
    {
        /// <summary>
        /// 
        /// </summary>
        FinalAnswer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EasyInputMessagePhase1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EasyInputMessagePhase1 value)
        {
            return value switch
            {
                EasyInputMessagePhase1.FinalAnswer => "final_answer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EasyInputMessagePhase1? ToEnum(string value)
        {
            return value switch
            {
                "final_answer" => EasyInputMessagePhase1.FinalAnswer,
                _ => null,
            };
        }
    }
}