//HintName: G.Models.ThreadStreamEventEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ThreadStreamEventEvent
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThreadStreamEventEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThreadStreamEventEvent value)
        {
            return value switch
            {
                ThreadStreamEventEvent.ThreadCreated => "thread.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThreadStreamEventEvent? ToEnum(string value)
        {
            return value switch
            {
                "thread.created" => ThreadStreamEventEvent.ThreadCreated,
                _ => null,
            };
        }
    }
}