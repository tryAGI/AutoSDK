//HintName: G.Models.RunStepStreamEventEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunStepStreamEventEvent
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunStepCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepStreamEventEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepStreamEventEvent value)
        {
            return value switch
            {
                RunStepStreamEventEvent.ThreadRunStepCreated => "thread.run.step.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepStreamEventEvent? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.step.created" => RunStepStreamEventEvent.ThreadRunStepCreated,
                _ => null,
            };
        }
    }
}