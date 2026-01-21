//HintName: G.Models.BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType
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
    public static class BetaResponseTextBlockCitationsVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.CharLocation => "char_location",
                BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.ContentBlockLocation => "content_block_location",
                BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.PageLocation => "page_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.CharLocation,
                "content_block_location" => BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.ContentBlockLocation,
                "page_location" => BetaResponseTextBlockCitationsVariant1ItemDiscriminatorType.PageLocation,
                _ => null,
            };
        }
    }
}