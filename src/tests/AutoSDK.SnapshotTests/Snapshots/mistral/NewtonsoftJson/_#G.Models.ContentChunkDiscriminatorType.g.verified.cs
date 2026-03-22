//HintName: G.Models.ContentChunkDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ContentChunkDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="document_url")]
        DocumentUrl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_url")]
        ImageUrl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reference")]
        Reference,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentChunkDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentChunkDiscriminatorType value)
        {
            return value switch
            {
                ContentChunkDiscriminatorType.DocumentUrl => "document_url",
                ContentChunkDiscriminatorType.ImageUrl => "image_url",
                ContentChunkDiscriminatorType.Reference => "reference",
                ContentChunkDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentChunkDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "document_url" => ContentChunkDiscriminatorType.DocumentUrl,
                "image_url" => ContentChunkDiscriminatorType.ImageUrl,
                "reference" => ContentChunkDiscriminatorType.Reference,
                "text" => ContentChunkDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}