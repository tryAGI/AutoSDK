//HintName: G.Models.VectorStoreSearchResultContentObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of content.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VectorStoreSearchResultContentObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStoreSearchResultContentObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStoreSearchResultContentObjectType value)
        {
            return value switch
            {
                VectorStoreSearchResultContentObjectType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStoreSearchResultContentObjectType? ToEnum(string value)
        {
            return value switch
            {
                "text" => VectorStoreSearchResultContentObjectType.Text,
                _ => null,
            };
        }
    }
}