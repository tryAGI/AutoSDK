//HintName: G.Models.AssistantStreamEventVariant9Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantStreamEventVariant9Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.incomplete")]
        ThreadRunIncomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant9EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant9Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant9Event.ThreadRunIncomplete => "thread.run.incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant9Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.incomplete" => AssistantStreamEventVariant9Event.ThreadRunIncomplete,
                _ => null,
            };
        }
    }
}