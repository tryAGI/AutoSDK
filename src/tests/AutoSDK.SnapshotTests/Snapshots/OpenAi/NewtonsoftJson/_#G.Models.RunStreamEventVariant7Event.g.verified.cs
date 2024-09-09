//HintName: G.Models.RunStreamEventVariant7Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStreamEventVariant7Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.failed")]
        ThreadRunFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStreamEventVariant7EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStreamEventVariant7Event value)
        {
            return value switch
            {
                RunStreamEventVariant7Event.ThreadRunFailed => "thread.run.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStreamEventVariant7Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.failed" => RunStreamEventVariant7Event.ThreadRunFailed,
                _ => null,
            };
        }
    }
}