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
        Long,
        /// <summary>
        /// 
        /// </summary>
        Short,
        /// <summary>
        /// 
        /// </summary>
        Formal,
        /// <summary>
        /// 
        /// </summary>
        Casual,
        /// <summary>
        /// 
        /// </summary>
        General,
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
                StyleType.Long => "long",
                StyleType.Short => "short",
                StyleType.Formal => "formal",
                StyleType.Casual => "casual",
                StyleType.General => "general",
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
                "long" => StyleType.Long,
                "short" => StyleType.Short,
                "formal" => StyleType.Formal,
                "casual" => StyleType.Casual,
                "general" => StyleType.General,
                _ => null,
            };
        }
    }
}