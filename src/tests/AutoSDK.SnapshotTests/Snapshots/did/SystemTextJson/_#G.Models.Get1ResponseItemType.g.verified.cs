//HintName: G.Models.Get1ResponseItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of object to be stored
    /// </summary>
    public enum Get1ResponseItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Document,
        /// <summary>
        /// 
        /// </summary>
        Knowledge,
        /// <summary>
        /// 
        /// </summary>
        Record,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Get1ResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Get1ResponseItemType value)
        {
            return value switch
            {
                Get1ResponseItemType.Document => "document",
                Get1ResponseItemType.Knowledge => "knowledge",
                Get1ResponseItemType.Record => "record",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Get1ResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "document" => Get1ResponseItemType.Document,
                "knowledge" => Get1ResponseItemType.Knowledge,
                "record" => Get1ResponseItemType.Record,
                _ => null,
            };
        }
    }
}