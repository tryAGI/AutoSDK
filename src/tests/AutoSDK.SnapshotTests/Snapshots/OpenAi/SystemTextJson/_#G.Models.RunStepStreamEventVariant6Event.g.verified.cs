//HintName: G.Models.RunStepStreamEventVariant6Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunStepStreamEventVariant6Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunStepCancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepStreamEventVariant6EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepStreamEventVariant6Event value)
        {
            return value switch
            {
                RunStepStreamEventVariant6Event.ThreadRunStepCancelled => "thread.run.step.cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepStreamEventVariant6Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.step.cancelled" => RunStepStreamEventVariant6Event.ThreadRunStepCancelled,
                _ => null,
            };
        }
    }
}