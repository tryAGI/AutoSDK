//HintName: G.Models.ToolMessageStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: success
    /// </summary>
    public enum ToolMessageStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolMessageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolMessageStatus value)
        {
            return value switch
            {
                ToolMessageStatus.Success => "success",
                ToolMessageStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolMessageStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => ToolMessageStatus.Success,
                "error" => ToolMessageStatus.Error,
                _ => null,
            };
        }
    }
}