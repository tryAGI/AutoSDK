//HintName: G.Models.BetaContentBlockSourceContentVariant2ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaContentBlockSourceContentVariant2ItemDiscriminatorType
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
    public static class BetaContentBlockSourceContentVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaContentBlockSourceContentVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                BetaContentBlockSourceContentVariant2ItemDiscriminatorType.Image => "image",
                BetaContentBlockSourceContentVariant2ItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaContentBlockSourceContentVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => BetaContentBlockSourceContentVariant2ItemDiscriminatorType.Image,
                "text" => BetaContentBlockSourceContentVariant2ItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}