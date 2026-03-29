//HintName: G.Models.CreateBatchTestResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBatchTestResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBatchTestResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBatchTestResponseStatus value)
        {
            return value switch
            {
                CreateBatchTestResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBatchTestResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateBatchTestResponseStatus.Error,
                _ => null,
            };
        }
    }
}