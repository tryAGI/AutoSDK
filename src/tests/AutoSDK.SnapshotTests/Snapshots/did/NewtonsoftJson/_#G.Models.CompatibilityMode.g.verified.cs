//HintName: G.Models.CompatibilityMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CompatibilityMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off")]
        Off,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="on")]
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