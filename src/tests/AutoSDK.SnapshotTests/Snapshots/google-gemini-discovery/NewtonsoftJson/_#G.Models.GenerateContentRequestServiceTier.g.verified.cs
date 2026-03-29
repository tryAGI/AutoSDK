//HintName: G.Models.GenerateContentRequestServiceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional. The service tier of the request.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GenerateContentRequestServiceTier
    {
        /// <summary>
        /// Flex service tier.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="flex")]
        Flex,
        /// <summary>
        /// Priority service tier.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="priority")]
        Priority,
        /// <summary>
        /// Standard service tier.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="standard")]
        Standard,
        /// <summary>
        /// Default service tier, which is standard.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unspecified")]
        Unspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateContentRequestServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateContentRequestServiceTier value)
        {
            return value switch
            {
                GenerateContentRequestServiceTier.Flex => "flex",
                GenerateContentRequestServiceTier.Priority => "priority",
                GenerateContentRequestServiceTier.Standard => "standard",
                GenerateContentRequestServiceTier.Unspecified => "unspecified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateContentRequestServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "flex" => GenerateContentRequestServiceTier.Flex,
                "priority" => GenerateContentRequestServiceTier.Priority,
                "standard" => GenerateContentRequestServiceTier.Standard,
                "unspecified" => GenerateContentRequestServiceTier.Unspecified,
                _ => null,
            };
        }
    }
}