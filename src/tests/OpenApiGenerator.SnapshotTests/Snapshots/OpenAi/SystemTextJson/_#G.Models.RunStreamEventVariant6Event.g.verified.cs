//HintName: G.Models.RunStreamEventVariant6Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunStreamEventVariant6Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStreamEventVariant6EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStreamEventVariant6Event value)
        {
            return value switch
            {
                RunStreamEventVariant6Event.ThreadRunFailed => "thread.run.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStreamEventVariant6Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.failed" => RunStreamEventVariant6Event.ThreadRunFailed,
                _ => null,
            };
        }
    }
}