//HintName: G.Models.RunStepStreamEventVariant7Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunStepStreamEventVariant7Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunStepExpired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepStreamEventVariant7EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepStreamEventVariant7Event value)
        {
            return value switch
            {
                RunStepStreamEventVariant7Event.ThreadRunStepExpired => "thread.run.step.expired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepStreamEventVariant7Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.step.expired" => RunStepStreamEventVariant7Event.ThreadRunStepExpired,
                _ => null,
            };
        }
    }
}