//HintName: G.Models.RunStreamEventVariant3Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStreamEventVariant3Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.in_progress")]
        ThreadRunInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStreamEventVariant3EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStreamEventVariant3Event value)
        {
            return value switch
            {
                RunStreamEventVariant3Event.ThreadRunInProgress => "thread.run.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStreamEventVariant3Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.in_progress" => RunStreamEventVariant3Event.ThreadRunInProgress,
                _ => null,
            };
        }
    }
}