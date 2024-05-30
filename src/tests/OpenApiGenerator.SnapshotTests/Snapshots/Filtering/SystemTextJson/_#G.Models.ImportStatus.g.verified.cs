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
        Error,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Detecting,
        /// <summary>
        /// 
        /// </summary>
        Choose,
        /// <summary>
        /// 
        /// </summary>
        AuthFailed,
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
        WaitingToPush,
        /// <summary>
        /// 
        /// </summary>
        Pushing,
        /// <summary>
        /// 
        /// </summary>
        Complete,
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
        DetectionFoundMultiple,
        /// <summary>
        /// 
        /// </summary>
        DetectionFoundNothing,
        /// <summary>
        /// 
        /// </summary>
        DetectionNeedsAuth,
    }

    public static class ImportStatusExtensions
    {
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
        public static ImportStatus ToEnum(string value)
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
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ImportStatus ToEnum(int value)
        {
            return value switch
            {
                0 => ImportStatus.Auth,
                1 => ImportStatus.Error,
                2 => ImportStatus.None,
                3 => ImportStatus.Detecting,
                4 => ImportStatus.Choose,
                5 => ImportStatus.AuthFailed,
                6 => ImportStatus.Importing,
                7 => ImportStatus.Mapping,
                8 => ImportStatus.WaitingToPush,
                9 => ImportStatus.Pushing,
                10 => ImportStatus.Complete,
                11 => ImportStatus.Setup,
                12 => ImportStatus.Unknown,
                13 => ImportStatus.DetectionFoundMultiple,
                14 => ImportStatus.DetectionFoundNothing,
                15 => ImportStatus.DetectionNeedsAuth,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}