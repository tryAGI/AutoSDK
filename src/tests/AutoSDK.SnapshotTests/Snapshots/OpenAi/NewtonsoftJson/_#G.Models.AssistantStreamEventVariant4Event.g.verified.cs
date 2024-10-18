//HintName: G.Models.AssistantStreamEventVariant4Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantStreamEventVariant4Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.created")]
        ThreadRunCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant4EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant4Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant4Event.ThreadRunCreated => "thread.run.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant4Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.created" => AssistantStreamEventVariant4Event.ThreadRunCreated,
                _ => null,
            };
        }
    }
}