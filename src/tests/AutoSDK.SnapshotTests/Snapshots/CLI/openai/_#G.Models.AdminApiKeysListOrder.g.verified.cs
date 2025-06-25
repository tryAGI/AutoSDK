//HintName: G.Models.AdminApiKeysListOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Order results by creation time, ascending or descending.<br/>
    /// Default Value: asc
    /// </summary>
    public enum AdminApiKeysListOrder
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
    public static class AdminApiKeysListOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminApiKeysListOrder value)
        {
            return value switch
            {
                AdminApiKeysListOrder.Asc => "asc",
                AdminApiKeysListOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminApiKeysListOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => AdminApiKeysListOrder.Asc,
                "desc" => AdminApiKeysListOrder.Desc,
                _ => null,
            };
        }
    }
}