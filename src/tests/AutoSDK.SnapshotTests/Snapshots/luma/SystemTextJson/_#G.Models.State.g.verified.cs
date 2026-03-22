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
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Dreaming,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Queued,
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
                State.Completed => "completed",
                State.Dreaming => "dreaming",
                State.Failed => "failed",
                State.Queued => "queued",
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
                "completed" => State.Completed,
                "dreaming" => State.Dreaming,
                "failed" => State.Failed,
                "queued" => State.Queued,
                _ => null,
            };
        }
    }
}