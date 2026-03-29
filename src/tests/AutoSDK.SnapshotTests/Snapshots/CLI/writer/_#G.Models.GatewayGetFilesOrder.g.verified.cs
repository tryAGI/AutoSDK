//HintName: G.Models.GatewayGetFilesOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum GatewayGetFilesOrder
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
    public static class GatewayGetFilesOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GatewayGetFilesOrder value)
        {
            return value switch
            {
                GatewayGetFilesOrder.Asc => "asc",
                GatewayGetFilesOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GatewayGetFilesOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GatewayGetFilesOrder.Asc,
                "desc" => GatewayGetFilesOrder.Desc,
                _ => null,
            };
        }
    }
}