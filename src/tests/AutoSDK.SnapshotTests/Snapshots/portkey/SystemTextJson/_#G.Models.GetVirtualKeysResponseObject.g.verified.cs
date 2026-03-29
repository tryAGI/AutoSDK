//HintName: G.Models.GetVirtualKeysResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetVirtualKeysResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetVirtualKeysResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVirtualKeysResponseObject value)
        {
            return value switch
            {
                GetVirtualKeysResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVirtualKeysResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => GetVirtualKeysResponseObject.List,
                _ => null,
            };
        }
    }
}