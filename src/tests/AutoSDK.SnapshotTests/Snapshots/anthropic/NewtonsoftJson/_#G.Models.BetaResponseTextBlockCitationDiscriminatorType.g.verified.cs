//HintName: G.Models.BetaResponseTextBlockCitationDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaResponseTextBlockCitationDiscriminatorType
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
    public static class BetaResponseTextBlockCitationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseTextBlockCitationDiscriminatorType value)
        {
            return value switch
            {
                BetaResponseTextBlockCitationDiscriminatorType.CharLocation => "char_location",
                BetaResponseTextBlockCitationDiscriminatorType.ContentBlockLocation => "content_block_location",
                BetaResponseTextBlockCitationDiscriminatorType.PageLocation => "page_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseTextBlockCitationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => BetaResponseTextBlockCitationDiscriminatorType.CharLocation,
                "content_block_location" => BetaResponseTextBlockCitationDiscriminatorType.ContentBlockLocation,
                "page_location" => BetaResponseTextBlockCitationDiscriminatorType.PageLocation,
                _ => null,
            };
        }
    }
}