//HintName: G.Models.GetDocumentsResponseItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of object
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetDocumentsResponseItemType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="document")]
        Document,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="knowledge")]
        Knowledge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="record")]
        Record,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDocumentsResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDocumentsResponseItemType value)
        {
            return value switch
            {
                GetDocumentsResponseItemType.Document => "document",
                GetDocumentsResponseItemType.Knowledge => "knowledge",
                GetDocumentsResponseItemType.Record => "record",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDocumentsResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "document" => GetDocumentsResponseItemType.Document,
                "knowledge" => GetDocumentsResponseItemType.Knowledge,
                "record" => GetDocumentsResponseItemType.Record,
                _ => null,
            };
        }
    }
}