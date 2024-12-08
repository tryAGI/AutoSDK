//HintName: G.Models.BetaRequestTextBlockCacheControlDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaRequestTextBlockCacheControlDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ephemeral")]
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestTextBlockCacheControlDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestTextBlockCacheControlDiscriminatorType value)
        {
            return value switch
            {
                BetaRequestTextBlockCacheControlDiscriminatorType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestTextBlockCacheControlDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => BetaRequestTextBlockCacheControlDiscriminatorType.Ephemeral,
                _ => null,
            };
        }
    }
}