//HintName: G.Models.FunctionResponseScheduling.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional. Specifies how the response should be scheduled in the conversation. Only applicable to NON_BLOCKING function calls, is ignored otherwise. Defaults to WHEN_IDLE.
    /// </summary>
    public enum FunctionResponseScheduling
    {
        /// <summary>
        /// Add the result to the conversation context, interrupt ongoing generation and prompt to generate output.
        /// </summary>
        Interrupt,
        /// <summary>
        /// This value is unused.
        /// </summary>
        SchedulingUnspecified,
        /// <summary>
        /// Only add the result to the conversation context, do not interrupt or trigger generation.
        /// </summary>
        Silent,
        /// <summary>
        /// Add the result to the conversation context, and prompt to generate output without interrupting ongoing generation.
        /// </summary>
        WhenIdle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionResponseSchedulingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionResponseScheduling value)
        {
            return value switch
            {
                FunctionResponseScheduling.Interrupt => "INTERRUPT",
                FunctionResponseScheduling.SchedulingUnspecified => "SCHEDULING_UNSPECIFIED",
                FunctionResponseScheduling.Silent => "SILENT",
                FunctionResponseScheduling.WhenIdle => "WHEN_IDLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionResponseScheduling? ToEnum(string value)
        {
            return value switch
            {
                "INTERRUPT" => FunctionResponseScheduling.Interrupt,
                "SCHEDULING_UNSPECIFIED" => FunctionResponseScheduling.SchedulingUnspecified,
                "SILENT" => FunctionResponseScheduling.Silent,
                "WHEN_IDLE" => FunctionResponseScheduling.WhenIdle,
                _ => null,
            };
        }
    }
}