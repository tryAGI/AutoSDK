//HintName: G.Models.UpdateMCPServerRequestConfigDiscriminatorMcpServerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateMCPServerRequestConfigDiscriminatorMcpServerType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sse")]
        Sse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stdio")]
        Stdio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="streamable_http")]
        StreamableHttp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMCPServerRequestConfigDiscriminatorMcpServerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMCPServerRequestConfigDiscriminatorMcpServerType value)
        {
            return value switch
            {
                UpdateMCPServerRequestConfigDiscriminatorMcpServerType.Sse => "sse",
                UpdateMCPServerRequestConfigDiscriminatorMcpServerType.Stdio => "stdio",
                UpdateMCPServerRequestConfigDiscriminatorMcpServerType.StreamableHttp => "streamable_http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMCPServerRequestConfigDiscriminatorMcpServerType? ToEnum(string value)
        {
            return value switch
            {
                "sse" => UpdateMCPServerRequestConfigDiscriminatorMcpServerType.Sse,
                "stdio" => UpdateMCPServerRequestConfigDiscriminatorMcpServerType.Stdio,
                "streamable_http" => UpdateMCPServerRequestConfigDiscriminatorMcpServerType.StreamableHttp,
                _ => null,
            };
        }
    }
}