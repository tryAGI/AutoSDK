//HintName: G.Models.CreateMCPServerRequestConfigDiscriminatorMcpServerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateMCPServerRequestConfigDiscriminatorMcpServerType
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
    public static class CreateMCPServerRequestConfigDiscriminatorMcpServerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMCPServerRequestConfigDiscriminatorMcpServerType value)
        {
            return value switch
            {
                CreateMCPServerRequestConfigDiscriminatorMcpServerType.Sse => "sse",
                CreateMCPServerRequestConfigDiscriminatorMcpServerType.Stdio => "stdio",
                CreateMCPServerRequestConfigDiscriminatorMcpServerType.StreamableHttp => "streamable_http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMCPServerRequestConfigDiscriminatorMcpServerType? ToEnum(string value)
        {
            return value switch
            {
                "sse" => CreateMCPServerRequestConfigDiscriminatorMcpServerType.Sse,
                "stdio" => CreateMCPServerRequestConfigDiscriminatorMcpServerType.Stdio,
                "streamable_http" => CreateMCPServerRequestConfigDiscriminatorMcpServerType.StreamableHttp,
                _ => null,
            };
        }
    }
}