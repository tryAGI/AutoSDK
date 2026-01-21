//HintName: G.Models.ResponseTextBlockCitationsVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseTextBlockCitationsVariant1ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="char_location")]
        CharLocation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_block_location")]
        ContentBlockLocation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="page_location")]
        PageLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseTextBlockCitationsVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseTextBlockCitationsVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                ResponseTextBlockCitationsVariant1ItemDiscriminatorType.CharLocation => "char_location",
                ResponseTextBlockCitationsVariant1ItemDiscriminatorType.ContentBlockLocation => "content_block_location",
                ResponseTextBlockCitationsVariant1ItemDiscriminatorType.PageLocation => "page_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseTextBlockCitationsVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => ResponseTextBlockCitationsVariant1ItemDiscriminatorType.CharLocation,
                "content_block_location" => ResponseTextBlockCitationsVariant1ItemDiscriminatorType.ContentBlockLocation,
                "page_location" => ResponseTextBlockCitationsVariant1ItemDiscriminatorType.PageLocation,
                _ => null,
            };
        }
    }
}