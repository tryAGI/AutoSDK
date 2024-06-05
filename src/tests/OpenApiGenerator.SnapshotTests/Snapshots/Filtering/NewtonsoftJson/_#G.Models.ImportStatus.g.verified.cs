//HintName: G.Models.ImportStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImportStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auth")]
        Auth,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="detecting")]
        Detecting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="choose")]
        Choose,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auth_failed")]
        AuthFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="importing")]
        Importing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mapping")]
        Mapping,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="waiting_to_push")]
        WaitingToPush,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pushing")]
        Pushing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="complete")]
        Complete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="setup")]
        Setup,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="detection_found_multiple")]
        DetectionFoundMultiple,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="detection_found_nothing")]
        DetectionFoundNothing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="detection_needs_auth")]
        DetectionNeedsAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportStatus value)
        {
            return value switch
            {
                ImportStatus.Auth => "auth",
                ImportStatus.Error => "error",
                ImportStatus.None => "none",
                ImportStatus.Detecting => "detecting",
                ImportStatus.Choose => "choose",
                ImportStatus.AuthFailed => "auth_failed",
                ImportStatus.Importing => "importing",
                ImportStatus.Mapping => "mapping",
                ImportStatus.WaitingToPush => "waiting_to_push",
                ImportStatus.Pushing => "pushing",
                ImportStatus.Complete => "complete",
                ImportStatus.Setup => "setup",
                ImportStatus.Unknown => "unknown",
                ImportStatus.DetectionFoundMultiple => "detection_found_multiple",
                ImportStatus.DetectionFoundNothing => "detection_found_nothing",
                ImportStatus.DetectionNeedsAuth => "detection_needs_auth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportStatus? ToEnum(string value)
        {
            return value switch
            {
                "auth" => ImportStatus.Auth,
                "error" => ImportStatus.Error,
                "none" => ImportStatus.None,
                "detecting" => ImportStatus.Detecting,
                "choose" => ImportStatus.Choose,
                "auth_failed" => ImportStatus.AuthFailed,
                "importing" => ImportStatus.Importing,
                "mapping" => ImportStatus.Mapping,
                "waiting_to_push" => ImportStatus.WaitingToPush,
                "pushing" => ImportStatus.Pushing,
                "complete" => ImportStatus.Complete,
                "setup" => ImportStatus.Setup,
                "unknown" => ImportStatus.Unknown,
                "detection_found_multiple" => ImportStatus.DetectionFoundMultiple,
                "detection_found_nothing" => ImportStatus.DetectionFoundNothing,
                "detection_needs_auth" => ImportStatus.DetectionNeedsAuth,
                _ => null,
            };
        }
    }
}