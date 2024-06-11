//HintName: G.Models.RunStreamEventVariant9Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunStreamEventVariant9Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunExpired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStreamEventVariant9EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStreamEventVariant9Event value)
        {
            return value switch
            {
                RunStreamEventVariant9Event.ThreadRunExpired => "thread.run.expired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStreamEventVariant9Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.expired" => RunStreamEventVariant9Event.ThreadRunExpired,
                _ => null,
            };
        }
    }
}