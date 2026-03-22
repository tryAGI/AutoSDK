//HintName: G.Models.StyleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum StyleType
    {
        /// <summary>
        /// 
        /// </summary>
        Casual,
        /// <summary>
        /// 
        /// </summary>
        Formal,
        /// <summary>
        /// 
        /// </summary>
        General,
        /// <summary>
        /// 
        /// </summary>
        Long,
        /// <summary>
        /// 
        /// </summary>
        Short,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StyleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StyleType value)
        {
            return value switch
            {
                StyleType.Casual => "casual",
                StyleType.Formal => "formal",
                StyleType.General => "general",
                StyleType.Long => "long",
                StyleType.Short => "short",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StyleType? ToEnum(string value)
        {
            return value switch
            {
                "casual" => StyleType.Casual,
                "formal" => StyleType.Formal,
                "general" => StyleType.General,
                "long" => StyleType.Long,
                "short" => StyleType.Short,
                _ => null,
            };
        }
    }
}