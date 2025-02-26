//HintName: G.Models.BetaRequestContentBlockLocationCitationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaRequestContentBlockLocationCitationType
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
    public static class BetaRequestContentBlockLocationCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestContentBlockLocationCitationType value)
        {
            return value switch
            {
                BetaRequestContentBlockLocationCitationType.ContentBlockLocation => "content_block_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestContentBlockLocationCitationType? ToEnum(string value)
        {
            return value switch
            {
                "content_block_location" => BetaRequestContentBlockLocationCitationType.ContentBlockLocation,
                _ => null,
            };
        }
    }
}