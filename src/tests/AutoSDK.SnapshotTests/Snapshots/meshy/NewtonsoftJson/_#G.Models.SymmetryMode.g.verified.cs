//HintName: G.Models.SymmetryMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: auto
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SymmetryMode
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
    public static class SymmetryModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SymmetryMode value)
        {
            return value switch
            {
                SymmetryMode.Auto => "auto",
                SymmetryMode.Off => "off",
                SymmetryMode.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SymmetryMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => SymmetryMode.Auto,
                "off" => SymmetryMode.Off,
                "on" => SymmetryMode.On,
                _ => null,
            };
        }
    }
}