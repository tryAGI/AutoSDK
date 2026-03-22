//HintName: G.Models.VoiceSharingResponseModelStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the voice sharing.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VoiceSharingResponseModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="copied")]
        Copied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="copied_disabled")]
        CopiedDisabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disabled")]
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enabled")]
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceSharingResponseModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceSharingResponseModelStatus value)
        {
            return value switch
            {
                VoiceSharingResponseModelStatus.Copied => "copied",
                VoiceSharingResponseModelStatus.CopiedDisabled => "copied_disabled",
                VoiceSharingResponseModelStatus.Disabled => "disabled",
                VoiceSharingResponseModelStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceSharingResponseModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "copied" => VoiceSharingResponseModelStatus.Copied,
                "copied_disabled" => VoiceSharingResponseModelStatus.CopiedDisabled,
                "disabled" => VoiceSharingResponseModelStatus.Disabled,
                "enabled" => VoiceSharingResponseModelStatus.Enabled,
                _ => null,
            };
        }
    }
}