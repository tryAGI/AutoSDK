//HintName: G.Models.Update1ResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of object to be stored
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Update1ResponseType
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
    public static class Update1ResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Update1ResponseType value)
        {
            return value switch
            {
                Update1ResponseType.Document => "document",
                Update1ResponseType.Knowledge => "knowledge",
                Update1ResponseType.Record => "record",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Update1ResponseType? ToEnum(string value)
        {
            return value switch
            {
                "document" => Update1ResponseType.Document,
                "knowledge" => Update1ResponseType.Knowledge,
                "record" => Update1ResponseType.Record,
                _ => null,
            };
        }
    }
}