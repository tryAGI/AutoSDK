//HintName: G.Models.RunStreamEventVariant2Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunStreamEventVariant2Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunQueued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStreamEventVariant2EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStreamEventVariant2Event value)
        {
            return value switch
            {
                RunStreamEventVariant2Event.ThreadRunQueued => "thread.run.queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStreamEventVariant2Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.queued" => RunStreamEventVariant2Event.ThreadRunQueued,
                _ => null,
            };
        }
    }
}