//HintName: G.Models.ResponseItemListObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of object returned, must be `list`.
    /// </summary>
    public enum ResponseItemListObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseItemListObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemListObject value)
        {
            return value switch
            {
                ResponseItemListObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemListObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ResponseItemListObject.List,
                _ => null,
            };
        }
    }
}