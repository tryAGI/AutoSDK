//HintName: G.Models.AssistantStreamEventVariant19Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantStreamEventVariant19Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.step.cancelled")]
        ThreadRunStepCancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant19EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant19Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant19Event.ThreadRunStepCancelled => "thread.run.step.cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant19Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.step.cancelled" => AssistantStreamEventVariant19Event.ThreadRunStepCancelled,
                _ => null,
            };
        }
    }
}