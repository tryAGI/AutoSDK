//HintName: G.Models.Create1ResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of object to be stored
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Create1ResponseType
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
    public static class Create1ResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create1ResponseType value)
        {
            return value switch
            {
                Create1ResponseType.Document => "document",
                Create1ResponseType.Knowledge => "knowledge",
                Create1ResponseType.Record => "record",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create1ResponseType? ToEnum(string value)
        {
            return value switch
            {
                "document" => Create1ResponseType.Document,
                "knowledge" => Create1ResponseType.Knowledge,
                "record" => Create1ResponseType.Record,
                _ => null,
            };
        }
    }
}