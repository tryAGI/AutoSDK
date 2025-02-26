//HintName: G.Models.BetaResponseContentBlockLocationCitationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: content_block_location
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaResponseContentBlockLocationCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_block_location")]
        ContentBlockLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseContentBlockLocationCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseContentBlockLocationCitationType value)
        {
            return value switch
            {
                BetaResponseContentBlockLocationCitationType.ContentBlockLocation => "content_block_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseContentBlockLocationCitationType? ToEnum(string value)
        {
            return value switch
            {
                "content_block_location" => BetaResponseContentBlockLocationCitationType.ContentBlockLocation,
                _ => null,
            };
        }
    }
}