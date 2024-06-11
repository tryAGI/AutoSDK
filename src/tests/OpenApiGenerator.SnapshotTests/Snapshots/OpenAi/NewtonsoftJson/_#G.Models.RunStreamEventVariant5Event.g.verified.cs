//HintName: G.Models.RunStreamEventVariant5Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStreamEventVariant5Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.completed")]
        ThreadRunCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStreamEventVariant5EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStreamEventVariant5Event value)
        {
            return value switch
            {
                RunStreamEventVariant5Event.ThreadRunCompleted => "thread.run.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStreamEventVariant5Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.completed" => RunStreamEventVariant5Event.ThreadRunCompleted,
                _ => null,
            };
        }
    }
}