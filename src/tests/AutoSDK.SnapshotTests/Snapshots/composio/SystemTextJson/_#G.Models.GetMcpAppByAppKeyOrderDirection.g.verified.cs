//HintName: G.Models.GetMcpAppByAppKeyOrderDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort direction (ascending or descending)<br/>
    /// Default Value: desc<br/>
    /// Example: desc
    /// </summary>
    public enum GetMcpAppByAppKeyOrderDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMcpAppByAppKeyOrderDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMcpAppByAppKeyOrderDirection value)
        {
            return value switch
            {
                GetMcpAppByAppKeyOrderDirection.Asc => "asc",
                GetMcpAppByAppKeyOrderDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMcpAppByAppKeyOrderDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetMcpAppByAppKeyOrderDirection.Asc,
                "desc" => GetMcpAppByAppKeyOrderDirection.Desc,
                _ => null,
            };
        }
    }
}