//HintName: G.Models.BetaRequestTextBlockCitationDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestTextBlockCitationDiscriminatorType
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
    public static class BetaRequestTextBlockCitationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestTextBlockCitationDiscriminatorType value)
        {
            return value switch
            {
                BetaRequestTextBlockCitationDiscriminatorType.CharLocation => "char_location",
                BetaRequestTextBlockCitationDiscriminatorType.ContentBlockLocation => "content_block_location",
                BetaRequestTextBlockCitationDiscriminatorType.PageLocation => "page_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestTextBlockCitationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => BetaRequestTextBlockCitationDiscriminatorType.CharLocation,
                "content_block_location" => BetaRequestTextBlockCitationDiscriminatorType.ContentBlockLocation,
                "page_location" => BetaRequestTextBlockCitationDiscriminatorType.PageLocation,
                _ => null,
            };
        }
    }
}