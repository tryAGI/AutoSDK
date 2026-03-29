//HintName: G.Models.CreateResponseResponseServiceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The service tier used for processing.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateResponseResponseServiceTier
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
    public static class CreateResponseResponseServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseResponseServiceTier value)
        {
            return value switch
            {
                CreateResponseResponseServiceTier.Auto => "auto",
                CreateResponseResponseServiceTier.Default => "default",
                CreateResponseResponseServiceTier.Flex => "flex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseResponseServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateResponseResponseServiceTier.Auto,
                "default" => CreateResponseResponseServiceTier.Default,
                "flex" => CreateResponseResponseServiceTier.Flex,
                _ => null,
            };
        }
    }
}