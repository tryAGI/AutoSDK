//HintName: G.Models.FeedbackResponseSchemaStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackResponseSchemaStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedbackResponseSchemaStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackResponseSchemaStatus value)
        {
            return value switch
            {
                FeedbackResponseSchemaStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackResponseSchemaStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => FeedbackResponseSchemaStatus.Success,
                _ => null,
            };
        }
    }
}