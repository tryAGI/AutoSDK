//HintName: G.Models.PatchAuthConfigsByNanoidByStatusStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The new status to set for the auth configuration
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PatchAuthConfigsByNanoidByStatusStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DISABLED")]
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ENABLED")]
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchAuthConfigsByNanoidByStatusStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAuthConfigsByNanoidByStatusStatus value)
        {
            return value switch
            {
                PatchAuthConfigsByNanoidByStatusStatus.Disabled => "DISABLED",
                PatchAuthConfigsByNanoidByStatusStatus.Enabled => "ENABLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAuthConfigsByNanoidByStatusStatus? ToEnum(string value)
        {
            return value switch
            {
                "DISABLED" => PatchAuthConfigsByNanoidByStatusStatus.Disabled,
                "ENABLED" => PatchAuthConfigsByNanoidByStatusStatus.Enabled,
                _ => null,
            };
        }
    }
}