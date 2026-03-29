//HintName: G.Models.CreateBatchCallResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBatchCallResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBatchCallResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBatchCallResponseStatus2 value)
        {
            return value switch
            {
                CreateBatchCallResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBatchCallResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateBatchCallResponseStatus2.Error,
                _ => null,
            };
        }
    }
}