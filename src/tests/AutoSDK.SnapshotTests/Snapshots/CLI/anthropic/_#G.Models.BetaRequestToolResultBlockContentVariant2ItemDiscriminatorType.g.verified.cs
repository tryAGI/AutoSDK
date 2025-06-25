//HintName: G.Models.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestToolResultBlockContentVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType.Image => "image",
                BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType.Image,
                "text" => BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}