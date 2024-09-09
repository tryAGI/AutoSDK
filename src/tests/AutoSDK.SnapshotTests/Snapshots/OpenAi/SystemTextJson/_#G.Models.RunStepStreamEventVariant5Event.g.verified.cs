//HintName: G.Models.RunStepStreamEventVariant5Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunStepStreamEventVariant5Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunStepFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepStreamEventVariant5EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepStreamEventVariant5Event value)
        {
            return value switch
            {
                RunStepStreamEventVariant5Event.ThreadRunStepFailed => "thread.run.step.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepStreamEventVariant5Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.step.failed" => RunStepStreamEventVariant5Event.ThreadRunStepFailed,
                _ => null,
            };
        }
    }
}