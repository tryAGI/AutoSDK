//HintName: G.Models.RunStreamEventEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunStreamEventEvent
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStreamEventEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStreamEventEvent value)
        {
            return value switch
            {
                RunStreamEventEvent.ThreadRunCreated => "thread.run.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStreamEventEvent? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.created" => RunStreamEventEvent.ThreadRunCreated,
                _ => null,
            };
        }
    }
}