//HintName: G.Models.CreateBatchTestResponseStatus4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBatchTestResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBatchTestResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBatchTestResponseStatus4 value)
        {
            return value switch
            {
                CreateBatchTestResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBatchTestResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateBatchTestResponseStatus4.Error,
                _ => null,
            };
        }
    }
}