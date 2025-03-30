//HintName: G.Models.ReaderResourceResponseModelResourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of resource.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReaderResourceResponseModelResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read")]
        Read,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="collection")]
        Collection,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReaderResourceResponseModelResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReaderResourceResponseModelResourceType value)
        {
            return value switch
            {
                ReaderResourceResponseModelResourceType.Read => "read",
                ReaderResourceResponseModelResourceType.Collection => "collection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReaderResourceResponseModelResourceType? ToEnum(string value)
        {
            return value switch
            {
                "read" => ReaderResourceResponseModelResourceType.Read,
                "collection" => ReaderResourceResponseModelResourceType.Collection,
                _ => null,
            };
        }
    }
}