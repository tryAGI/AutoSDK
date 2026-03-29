//HintName: G.Models.StatusResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum StatusResponseStatus
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
    public static class StatusResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StatusResponseStatus value)
        {
            return value switch
            {
                StatusResponseStatus.Error => "error",
                StatusResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StatusResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => StatusResponseStatus.Error,
                "success" => StatusResponseStatus.Success,
                _ => null,
            };
        }
    }
}