//HintName: G.Models.RunStreamEventVariant8Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStreamEventVariant8Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.cancelling")]
        ThreadRunCancelling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStreamEventVariant8EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStreamEventVariant8Event value)
        {
            return value switch
            {
                RunStreamEventVariant8Event.ThreadRunCancelling => "thread.run.cancelling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStreamEventVariant8Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.cancelling" => RunStreamEventVariant8Event.ThreadRunCancelling,
                _ => null,
            };
        }
    }
}