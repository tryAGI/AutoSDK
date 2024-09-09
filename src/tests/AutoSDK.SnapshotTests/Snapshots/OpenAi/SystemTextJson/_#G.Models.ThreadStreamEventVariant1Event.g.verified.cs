//HintName: G.Models.ThreadStreamEventVariant1Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ThreadStreamEventVariant1Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThreadStreamEventVariant1EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThreadStreamEventVariant1Event value)
        {
            return value switch
            {
                ThreadStreamEventVariant1Event.ThreadCreated => "thread.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThreadStreamEventVariant1Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.created" => ThreadStreamEventVariant1Event.ThreadCreated,
                _ => null,
            };
        }
    }
}