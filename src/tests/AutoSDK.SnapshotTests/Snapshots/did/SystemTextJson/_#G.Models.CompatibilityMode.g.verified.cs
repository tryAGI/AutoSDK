//HintName: G.Models.CompatibilityMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompatibilityMode
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Off,
        /// <summary>
        /// 
        /// </summary>
        On,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompatibilityModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompatibilityMode value)
        {
            return value switch
            {
                CompatibilityMode.Auto => "auto",
                CompatibilityMode.Off => "off",
                CompatibilityMode.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompatibilityMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CompatibilityMode.Auto,
                "off" => CompatibilityMode.Off,
                "on" => CompatibilityMode.On,
                _ => null,
            };
        }
    }
}