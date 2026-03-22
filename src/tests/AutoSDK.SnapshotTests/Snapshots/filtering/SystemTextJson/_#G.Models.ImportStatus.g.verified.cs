//HintName: G.Models.ImportStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImportStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Auth,
        /// <summary>
        /// 
        /// </summary>
        AuthFailed,
        /// <summary>
        /// 
        /// </summary>
        Choose,
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        Detecting,
        /// <summary>
        /// 
        /// </summary>
        DetectionFoundMultiple,
        /// <summary>
        /// 
        /// </summary>
        DetectionFoundNothing,
        /// <summary>
        /// 
        /// </summary>
        DetectionNeedsAuth,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Importing,
        /// <summary>
        /// 
        /// </summary>
        Mapping,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Pushing,
        /// <summary>
        /// 
        /// </summary>
        Setup,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        WaitingToPush,
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
                ImportStatus.AuthFailed => "auth_failed",
                ImportStatus.Choose => "choose",
                ImportStatus.Complete => "complete",
                ImportStatus.Detecting => "detecting",
                ImportStatus.DetectionFoundMultiple => "detection_found_multiple",
                ImportStatus.DetectionFoundNothing => "detection_found_nothing",
                ImportStatus.DetectionNeedsAuth => "detection_needs_auth",
                ImportStatus.Error => "error",
                ImportStatus.Importing => "importing",
                ImportStatus.Mapping => "mapping",
                ImportStatus.None => "none",
                ImportStatus.Pushing => "pushing",
                ImportStatus.Setup => "setup",
                ImportStatus.Unknown => "unknown",
                ImportStatus.WaitingToPush => "waiting_to_push",
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
                "auth_failed" => ImportStatus.AuthFailed,
                "choose" => ImportStatus.Choose,
                "complete" => ImportStatus.Complete,
                "detecting" => ImportStatus.Detecting,
                "detection_found_multiple" => ImportStatus.DetectionFoundMultiple,
                "detection_found_nothing" => ImportStatus.DetectionFoundNothing,
                "detection_needs_auth" => ImportStatus.DetectionNeedsAuth,
                "error" => ImportStatus.Error,
                "importing" => ImportStatus.Importing,
                "mapping" => ImportStatus.Mapping,
                "none" => ImportStatus.None,
                "pushing" => ImportStatus.Pushing,
                "setup" => ImportStatus.Setup,
                "unknown" => ImportStatus.Unknown,
                "waiting_to_push" => ImportStatus.WaitingToPush,
                _ => null,
            };
        }
    }
}