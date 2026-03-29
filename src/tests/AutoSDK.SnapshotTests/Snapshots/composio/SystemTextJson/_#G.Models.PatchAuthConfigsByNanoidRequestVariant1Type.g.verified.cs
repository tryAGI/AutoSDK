//HintName: G.Models.PatchAuthConfigsByNanoidRequestVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchAuthConfigsByNanoidRequestVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchAuthConfigsByNanoidRequestVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAuthConfigsByNanoidRequestVariant1Type value)
        {
            return value switch
            {
                PatchAuthConfigsByNanoidRequestVariant1Type.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAuthConfigsByNanoidRequestVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "custom" => PatchAuthConfigsByNanoidRequestVariant1Type.Custom,
                _ => null,
            };
        }
    }
}