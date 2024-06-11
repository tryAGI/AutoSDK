//HintName: G.Models.RunStreamEventVariant7Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunStreamEventVariant7Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunCancelling,
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
                RunStreamEventVariant7Event.ThreadRunCancelling => "thread.run.cancelling",
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
                "thread.run.cancelling" => RunStreamEventVariant7Event.ThreadRunCancelling,
                _ => null,
            };
        }
    }
}