//HintName: G.Models.VoiceSharingResponseModelStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceSharingResponseModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Copied,
        /// <summary>
        /// 
        /// </summary>
        CopiedDisabled,
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
                VoiceSharingResponseModelStatus.Enabled => "enabled",
                VoiceSharingResponseModelStatus.Disabled => "disabled",
                VoiceSharingResponseModelStatus.Copied => "copied",
                VoiceSharingResponseModelStatus.CopiedDisabled => "copied_disabled",
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
                "enabled" => VoiceSharingResponseModelStatus.Enabled,
                "disabled" => VoiceSharingResponseModelStatus.Disabled,
                "copied" => VoiceSharingResponseModelStatus.Copied,
                "copied_disabled" => VoiceSharingResponseModelStatus.CopiedDisabled,
                _ => null,
            };
        }
    }
}