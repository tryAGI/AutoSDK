//HintName: G.Models.SessionCreatedHookOn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the event that triggers this hook
    /// </summary>
    public enum SessionCreatedHookOn
    {
        /// <summary>
        /// 
        /// </summary>
        SessionCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionCreatedHookOnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionCreatedHookOn value)
        {
            return value switch
            {
                SessionCreatedHookOn.SessionCreated => "session.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionCreatedHookOn? ToEnum(string value)
        {
            return value switch
            {
                "session.created" => SessionCreatedHookOn.SessionCreated,
                _ => null,
            };
        }
    }
}