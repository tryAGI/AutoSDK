//HintName: G.Models.BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType
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
    public static class BetaRequestTextBlockCitationsVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.CharLocation => "char_location",
                BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.ContentBlockLocation => "content_block_location",
                BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.PageLocation => "page_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.CharLocation,
                "content_block_location" => BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.ContentBlockLocation,
                "page_location" => BetaRequestTextBlockCitationsVariant1ItemDiscriminatorType.PageLocation,
                _ => null,
            };
        }
    }
}