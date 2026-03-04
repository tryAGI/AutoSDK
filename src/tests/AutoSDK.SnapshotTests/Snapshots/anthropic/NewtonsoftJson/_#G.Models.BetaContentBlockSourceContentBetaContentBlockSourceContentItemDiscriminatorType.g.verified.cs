//HintName: G.Models.BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminatorType value)
        {
            return value switch
            {
                BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminatorType.Image => "image",
                BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminatorType.Image,
                "text" => BetaContentBlockSourceContentBetaContentBlockSourceContentItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}