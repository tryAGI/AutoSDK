//HintName: G.Models.ToolMessageChunkStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: success
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolMessageChunkStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
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
                ToolMessageChunkStatus.Error => "error",
                ToolMessageChunkStatus.Success => "success",
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
                "error" => ToolMessageChunkStatus.Error,
                "success" => ToolMessageChunkStatus.Success,
                _ => null,
            };
        }
    }
}