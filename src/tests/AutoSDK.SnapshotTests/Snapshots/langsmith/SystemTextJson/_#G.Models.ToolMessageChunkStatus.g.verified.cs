//HintName: G.Models.ToolMessageChunkStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: success
    /// </summary>
    public enum ToolMessageChunkStatus
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
    public static class ToolMessageChunkStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolMessageChunkStatus value)
        {
            return value switch
            {
                ToolMessageChunkStatus.Success => "success",
                ToolMessageChunkStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolMessageChunkStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => ToolMessageChunkStatus.Success,
                "error" => ToolMessageChunkStatus.Error,
                _ => null,
            };
        }
    }
}