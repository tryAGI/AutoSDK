//HintName: G.Models.GetMcpServersByServerIdInstancesOrderDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort direction (ascending or descending)<br/>
    /// Default Value: desc<br/>
    /// Example: desc
    /// </summary>
    public enum GetMcpServersByServerIdInstancesOrderDirection
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
    public static class GetMcpServersByServerIdInstancesOrderDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMcpServersByServerIdInstancesOrderDirection value)
        {
            return value switch
            {
                GetMcpServersByServerIdInstancesOrderDirection.Asc => "asc",
                GetMcpServersByServerIdInstancesOrderDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMcpServersByServerIdInstancesOrderDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetMcpServersByServerIdInstancesOrderDirection.Asc,
                "desc" => GetMcpServersByServerIdInstancesOrderDirection.Desc,
                _ => null,
            };
        }
    }
}