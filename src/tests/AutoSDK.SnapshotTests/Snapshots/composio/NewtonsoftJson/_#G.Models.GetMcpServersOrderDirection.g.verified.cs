//HintName: G.Models.GetMcpServersOrderDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort direction (ascending or descending)<br/>
    /// Default Value: desc<br/>
    /// Example: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetMcpServersOrderDirection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asc")]
        Asc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="desc")]
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMcpServersOrderDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMcpServersOrderDirection value)
        {
            return value switch
            {
                GetMcpServersOrderDirection.Asc => "asc",
                GetMcpServersOrderDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMcpServersOrderDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetMcpServersOrderDirection.Asc,
                "desc" => GetMcpServersOrderDirection.Desc,
                _ => null,
            };
        }
    }
}