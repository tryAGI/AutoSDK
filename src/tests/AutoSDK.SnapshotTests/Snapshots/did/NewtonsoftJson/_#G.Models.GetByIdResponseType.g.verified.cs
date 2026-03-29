//HintName: G.Models.GetByIdResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of object to be stored
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetByIdResponseType
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
    public static class GetByIdResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetByIdResponseType value)
        {
            return value switch
            {
                GetByIdResponseType.Document => "document",
                GetByIdResponseType.Knowledge => "knowledge",
                GetByIdResponseType.Record => "record",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetByIdResponseType? ToEnum(string value)
        {
            return value switch
            {
                "document" => GetByIdResponseType.Document,
                "knowledge" => GetByIdResponseType.Knowledge,
                "record" => GetByIdResponseType.Record,
                _ => null,
            };
        }
    }
}