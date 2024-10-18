//HintName: G.Models.AssistantStreamEventVariant16Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantStreamEventVariant16Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunStepDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant16EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant16Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant16Event.ThreadRunStepDelta => "thread.run.step.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant16Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.step.delta" => AssistantStreamEventVariant16Event.ThreadRunStepDelta,
                _ => null,
            };
        }
    }
}