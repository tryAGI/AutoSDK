//HintName: G.Models.RunStreamEventVariant10Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunStreamEventVariant10Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunExpired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStreamEventVariant10EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStreamEventVariant10Event value)
        {
            return value switch
            {
                RunStreamEventVariant10Event.ThreadRunExpired => "thread.run.expired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStreamEventVariant10Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.expired" => RunStreamEventVariant10Event.ThreadRunExpired,
                _ => null,
            };
        }
    }
}