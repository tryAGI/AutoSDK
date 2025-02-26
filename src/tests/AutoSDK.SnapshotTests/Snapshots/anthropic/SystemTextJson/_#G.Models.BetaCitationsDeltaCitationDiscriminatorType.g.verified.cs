//HintName: G.Models.BetaCitationsDeltaCitationDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaCitationsDeltaCitationDiscriminatorType
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
    public static class BetaCitationsDeltaCitationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCitationsDeltaCitationDiscriminatorType value)
        {
            return value switch
            {
                BetaCitationsDeltaCitationDiscriminatorType.CharLocation => "char_location",
                BetaCitationsDeltaCitationDiscriminatorType.ContentBlockLocation => "content_block_location",
                BetaCitationsDeltaCitationDiscriminatorType.PageLocation => "page_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCitationsDeltaCitationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => BetaCitationsDeltaCitationDiscriminatorType.CharLocation,
                "content_block_location" => BetaCitationsDeltaCitationDiscriminatorType.ContentBlockLocation,
                "page_location" => BetaCitationsDeltaCitationDiscriminatorType.PageLocation,
                _ => null,
            };
        }
    }
}