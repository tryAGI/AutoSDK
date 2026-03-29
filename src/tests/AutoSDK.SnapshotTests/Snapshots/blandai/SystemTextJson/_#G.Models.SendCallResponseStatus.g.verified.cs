//HintName: G.Models.SendCallResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SendCallResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SendCallResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SendCallResponseStatus value)
        {
            return value switch
            {
                SendCallResponseStatus.Error => "error",
                SendCallResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SendCallResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => SendCallResponseStatus.Error,
                "success" => SendCallResponseStatus.Success,
                _ => null,
            };
        }
    }
}