//HintName: G.Models.UpgradeToProRequestUiMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpgradeToProRequestUiMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="embedded")]
        Embedded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hosted")]
        Hosted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpgradeToProRequestUiModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpgradeToProRequestUiMode value)
        {
            return value switch
            {
                UpgradeToProRequestUiMode.Embedded => "embedded",
                UpgradeToProRequestUiMode.Hosted => "hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpgradeToProRequestUiMode? ToEnum(string value)
        {
            return value switch
            {
                "embedded" => UpgradeToProRequestUiMode.Embedded,
                "hosted" => UpgradeToProRequestUiMode.Hosted,
                _ => null,
            };
        }
    }
}