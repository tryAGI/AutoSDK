//HintName: G.Models.CreateResponseResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the response generation. One of `completed`, `failed`, `in_progress`, or `incomplete`.
    /// </summary>
    public enum CreateResponseResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateResponseResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseResponseStatus value)
        {
            return value switch
            {
                CreateResponseResponseStatus.Completed => "completed",
                CreateResponseResponseStatus.Failed => "failed",
                CreateResponseResponseStatus.InProgress => "in_progress",
                CreateResponseResponseStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => CreateResponseResponseStatus.Completed,
                "failed" => CreateResponseResponseStatus.Failed,
                "in_progress" => CreateResponseResponseStatus.InProgress,
                "incomplete" => CreateResponseResponseStatus.Incomplete,
                _ => null,
            };
        }
    }
}