//HintName: G.Models.State.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the generation<br/>
    /// Example: completed
    /// </summary>
    public enum State
    {
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Dreaming,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this State value)
        {
            return value switch
            {
                State.Queued => "queued",
                State.Dreaming => "dreaming",
                State.Completed => "completed",
                State.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static State? ToEnum(string value)
        {
            return value switch
            {
                "queued" => State.Queued,
                "dreaming" => State.Dreaming,
                "completed" => State.Completed,
                "failed" => State.Failed,
                _ => null,
            };
        }
    }
}