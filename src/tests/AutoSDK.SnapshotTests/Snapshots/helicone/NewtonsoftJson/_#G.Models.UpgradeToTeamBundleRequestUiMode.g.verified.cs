//HintName: G.Models.UpgradeToTeamBundleRequestUiMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpgradeToTeamBundleRequestUiMode
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
    public static class UpgradeToTeamBundleRequestUiModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpgradeToTeamBundleRequestUiMode value)
        {
            return value switch
            {
                UpgradeToTeamBundleRequestUiMode.Embedded => "embedded",
                UpgradeToTeamBundleRequestUiMode.Hosted => "hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpgradeToTeamBundleRequestUiMode? ToEnum(string value)
        {
            return value switch
            {
                "embedded" => UpgradeToTeamBundleRequestUiMode.Embedded,
                "hosted" => UpgradeToTeamBundleRequestUiMode.Hosted,
                _ => null,
            };
        }
    }
}