//HintName: G.Models.ILogicalDocumentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of object
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ILogicalDocumentType
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
    public static class ILogicalDocumentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ILogicalDocumentType value)
        {
            return value switch
            {
                ILogicalDocumentType.Document => "document",
                ILogicalDocumentType.Knowledge => "knowledge",
                ILogicalDocumentType.Record => "record",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ILogicalDocumentType? ToEnum(string value)
        {
            return value switch
            {
                "document" => ILogicalDocumentType.Document,
                "knowledge" => ILogicalDocumentType.Knowledge,
                "record" => ILogicalDocumentType.Record,
                _ => null,
            };
        }
    }
}