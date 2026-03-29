//HintName: G.Models.RunStepStreamEventVariant2Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunStepStreamEventVariant2Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunStepInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepStreamEventVariant2EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepStreamEventVariant2Event value)
        {
            return value switch
            {
                RunStepStreamEventVariant2Event.ThreadRunStepInProgress => "thread.run.step.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepStreamEventVariant2Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.step.in_progress" => RunStepStreamEventVariant2Event.ThreadRunStepInProgress,
                _ => null,
            };
        }
    }
}