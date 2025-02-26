//HintName: G.Models.BetaRequestTextBlockCitationDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaRequestTextBlockCitationDiscriminatorType
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