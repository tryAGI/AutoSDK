//HintName: G.Models.PatchAuthConfigsByNanoidRequestVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchAuthConfigsByNanoidRequestVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchAuthConfigsByNanoidRequestVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAuthConfigsByNanoidRequestVariant2Type value)
        {
            return value switch
            {
                PatchAuthConfigsByNanoidRequestVariant2Type.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAuthConfigsByNanoidRequestVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "default" => PatchAuthConfigsByNanoidRequestVariant2Type.Default,
                _ => null,
            };
        }
    }
}