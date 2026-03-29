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
        [global::System.Runtime.Serialization.EnumMember(Value="DEFAULT")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OPTITEX")]
        Optitex,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UNREAL")]
        Unreal,
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
                CompatibilityMode.Default => "DEFAULT",
                CompatibilityMode.Optitex => "OPTITEX",
                CompatibilityMode.Unreal => "UNREAL",
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
                "DEFAULT" => CompatibilityMode.Default,
                "OPTITEX" => CompatibilityMode.Optitex,
                "UNREAL" => CompatibilityMode.Unreal,
                _ => null,
            };
        }
    }
}