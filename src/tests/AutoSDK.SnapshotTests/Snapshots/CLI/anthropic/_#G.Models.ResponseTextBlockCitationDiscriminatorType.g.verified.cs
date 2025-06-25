//HintName: G.Models.ResponseTextBlockCitationDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseTextBlockCitationDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        CharLocation,
        /// <summary>
        /// 
        /// </summary>
        ContentBlockLocation,
        /// <summary>
        /// 
        /// </summary>
        PageLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseTextBlockCitationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseTextBlockCitationDiscriminatorType value)
        {
            return value switch
            {
                ResponseTextBlockCitationDiscriminatorType.CharLocation => "char_location",
                ResponseTextBlockCitationDiscriminatorType.ContentBlockLocation => "content_block_location",
                ResponseTextBlockCitationDiscriminatorType.PageLocation => "page_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseTextBlockCitationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => ResponseTextBlockCitationDiscriminatorType.CharLocation,
                "content_block_location" => ResponseTextBlockCitationDiscriminatorType.ContentBlockLocation,
                "page_location" => ResponseTextBlockCitationDiscriminatorType.PageLocation,
                _ => null,
            };
        }
    }
}