//HintName: G.Models.ServiceTierEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ServiceTierEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Flex,
        /// <summary>
        /// 
        /// </summary>
        Priority,
        /// <summary>
        /// 
        /// </summary>
        Scale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServiceTierEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServiceTierEnum value)
        {
            return value switch
            {
                ServiceTierEnum.Auto => "auto",
                ServiceTierEnum.Default => "default",
                ServiceTierEnum.Flex => "flex",
                ServiceTierEnum.Priority => "priority",
                ServiceTierEnum.Scale => "scale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServiceTierEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ServiceTierEnum.Auto,
                "default" => ServiceTierEnum.Default,
                "flex" => ServiceTierEnum.Flex,
                "priority" => ServiceTierEnum.Priority,
                "scale" => ServiceTierEnum.Scale,
                _ => null,
            };
        }
    }
}