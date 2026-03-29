//HintName: G.Models.CreateResponseRequestServiceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the latency tier to use for processing the request.<br/>
    /// Default Value: auto
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateResponseRequestServiceTier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="flex")]
        Flex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateResponseRequestServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseRequestServiceTier value)
        {
            return value switch
            {
                CreateResponseRequestServiceTier.Auto => "auto",
                CreateResponseRequestServiceTier.Default => "default",
                CreateResponseRequestServiceTier.Flex => "flex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseRequestServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateResponseRequestServiceTier.Auto,
                "default" => CreateResponseRequestServiceTier.Default,
                "flex" => CreateResponseRequestServiceTier.Flex,
                _ => null,
            };
        }
    }
}