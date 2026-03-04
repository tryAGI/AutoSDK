//HintName: G.Models.Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status describes the output of an execution.<br/>
    ///  - STATUS_COMPLETED: Successfully completed.<br/>
    ///  - STATUS_ERRORED: Finished with error.
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// Successfully completed.
        /// </summary>
        Completed,
        /// <summary>
        /// Finished with error.
        /// </summary>
        Errored,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Status value)
        {
            return value switch
            {
                Status.Completed => "STATUS_COMPLETED",
                Status.Errored => "STATUS_ERRORED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Status? ToEnum(string value)
        {
            return value switch
            {
                "STATUS_COMPLETED" => Status.Completed,
                "STATUS_ERRORED" => Status.Errored,
                _ => null,
            };
        }
    }
}