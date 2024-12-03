//HintName: G.Models.AssistantStreamEventVariant15Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantStreamEventVariant15Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.step.in_progress")]
        ThreadRunStepInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant15EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant15Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant15Event.ThreadRunStepInProgress => "thread.run.step.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant15Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.step.in_progress" => AssistantStreamEventVariant15Event.ThreadRunStepInProgress,
                _ => null,
            };
        }
    }
}