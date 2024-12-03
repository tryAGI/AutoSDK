//HintName: G.Models.AssistantStreamEventVariant20Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantStreamEventVariant20Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.step.expired")]
        ThreadRunStepExpired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant20EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant20Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant20Event.ThreadRunStepExpired => "thread.run.step.expired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant20Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.step.expired" => AssistantStreamEventVariant20Event.ThreadRunStepExpired,
                _ => null,
            };
        }
    }
}