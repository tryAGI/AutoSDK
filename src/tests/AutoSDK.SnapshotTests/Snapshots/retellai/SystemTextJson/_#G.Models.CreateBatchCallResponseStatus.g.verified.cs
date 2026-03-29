//HintName: G.Models.CreateBatchCallResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBatchCallResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBatchCallResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBatchCallResponseStatus value)
        {
            return value switch
            {
                CreateBatchCallResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBatchCallResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateBatchCallResponseStatus.Error,
                _ => null,
            };
        }
    }
}