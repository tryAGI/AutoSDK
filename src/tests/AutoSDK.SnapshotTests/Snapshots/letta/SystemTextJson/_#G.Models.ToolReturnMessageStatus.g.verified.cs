//HintName: G.Models.ToolReturnMessageStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolReturnMessageStatus
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
    public static class ToolReturnMessageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolReturnMessageStatus value)
        {
            return value switch
            {
                ToolReturnMessageStatus.Error => "error",
                ToolReturnMessageStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolReturnMessageStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ToolReturnMessageStatus.Error,
                "success" => ToolReturnMessageStatus.Success,
                _ => null,
            };
        }
    }
}