//HintName: G.Models.CreateBatchTestResponseStatus5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBatchTestResponseStatus5
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBatchTestResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBatchTestResponseStatus5 value)
        {
            return value switch
            {
                CreateBatchTestResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBatchTestResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateBatchTestResponseStatus5.Error,
                _ => null,
            };
        }
    }
}