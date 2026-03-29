//HintName: G.Models.AutoModeParsingConfVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AutoModeParsingConfVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x20251211,
        /// <summary>
        /// 
        /// </summary>
        x20251218,
        /// <summary>
        /// 
        /// </summary>
        x20251231,
        /// <summary>
        /// 
        /// </summary>
        x20260108,
        /// <summary>
        /// 
        /// </summary>
        x20260109,
        /// <summary>
        /// 
        /// </summary>
        x20260116,
        /// <summary>
        /// 
        /// </summary>
        x20260121,
        /// <summary>
        /// 
        /// </summary>
        x20260122,
        /// <summary>
        /// 
        /// </summary>
        x20260124,
        /// <summary>
        /// 
        /// </summary>
        x20260129,
        /// <summary>
        /// 
        /// </summary>
        x20260130,
        /// <summary>
        /// 
        /// </summary>
        x20260203,
        /// <summary>
        /// 
        /// </summary>
        x20260218,
        /// <summary>
        /// 
        /// </summary>
        x20260220,
        /// <summary>
        /// 
        /// </summary>
        x20260224,
        /// <summary>
        /// 
        /// </summary>
        x20260226,
        /// <summary>
        /// 
        /// </summary>
        x20260302,
        /// <summary>
        /// 
        /// </summary>
        x20260303,
        /// <summary>
        /// 
        /// </summary>
        x20260304,
        /// <summary>
        /// 
        /// </summary>
        x20260305,
        /// <summary>
        /// 
        /// </summary>
        x20260309,
        /// <summary>
        /// 
        /// </summary>
        x20260310,
        /// <summary>
        /// 
        /// </summary>
        x20260311,
        /// <summary>
        /// 
        /// </summary>
        x20260312,
        /// <summary>
        /// 
        /// </summary>
        x20260317,
        /// <summary>
        /// 
        /// </summary>
        x20260319,
        /// <summary>
        /// 
        /// </summary>
        x20260320,
        /// <summary>
        /// 
        /// </summary>
        x20260322,
        /// <summary>
        /// 
        /// </summary>
        x20260323,
        /// <summary>
        /// 
        /// </summary>
        x20260324,
        /// <summary>
        /// 
        /// </summary>
        x20260325,
        /// <summary>
        /// 
        /// </summary>
        x20260326,
        /// <summary>
        /// 
        /// </summary>
        x20260327,
        /// <summary>
        /// 
        /// </summary>
        Latest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoModeParsingConfVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoModeParsingConfVersion value)
        {
            return value switch
            {
                AutoModeParsingConfVersion.x20251211 => "2025-12-11",
                AutoModeParsingConfVersion.x20251218 => "2025-12-18",
                AutoModeParsingConfVersion.x20251231 => "2025-12-31",
                AutoModeParsingConfVersion.x20260108 => "2026-01-08",
                AutoModeParsingConfVersion.x20260109 => "2026-01-09",
                AutoModeParsingConfVersion.x20260116 => "2026-01-16",
                AutoModeParsingConfVersion.x20260121 => "2026-01-21",
                AutoModeParsingConfVersion.x20260122 => "2026-01-22",
                AutoModeParsingConfVersion.x20260124 => "2026-01-24",
                AutoModeParsingConfVersion.x20260129 => "2026-01-29",
                AutoModeParsingConfVersion.x20260130 => "2026-01-30",
                AutoModeParsingConfVersion.x20260203 => "2026-02-03",
                AutoModeParsingConfVersion.x20260218 => "2026-02-18",
                AutoModeParsingConfVersion.x20260220 => "2026-02-20",
                AutoModeParsingConfVersion.x20260224 => "2026-02-24",
                AutoModeParsingConfVersion.x20260226 => "2026-02-26",
                AutoModeParsingConfVersion.x20260302 => "2026-03-02",
                AutoModeParsingConfVersion.x20260303 => "2026-03-03",
                AutoModeParsingConfVersion.x20260304 => "2026-03-04",
                AutoModeParsingConfVersion.x20260305 => "2026-03-05",
                AutoModeParsingConfVersion.x20260309 => "2026-03-09",
                AutoModeParsingConfVersion.x20260310 => "2026-03-10",
                AutoModeParsingConfVersion.x20260311 => "2026-03-11",
                AutoModeParsingConfVersion.x20260312 => "2026-03-12",
                AutoModeParsingConfVersion.x20260317 => "2026-03-17",
                AutoModeParsingConfVersion.x20260319 => "2026-03-19",
                AutoModeParsingConfVersion.x20260320 => "2026-03-20",
                AutoModeParsingConfVersion.x20260322 => "2026-03-22",
                AutoModeParsingConfVersion.x20260323 => "2026-03-23",
                AutoModeParsingConfVersion.x20260324 => "2026-03-24",
                AutoModeParsingConfVersion.x20260325 => "2026-03-25",
                AutoModeParsingConfVersion.x20260326 => "2026-03-26",
                AutoModeParsingConfVersion.x20260327 => "2026-03-27",
                AutoModeParsingConfVersion.Latest => "latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoModeParsingConfVersion? ToEnum(string value)
        {
            return value switch
            {
                "2025-12-11" => AutoModeParsingConfVersion.x20251211,
                "2025-12-18" => AutoModeParsingConfVersion.x20251218,
                "2025-12-31" => AutoModeParsingConfVersion.x20251231,
                "2026-01-08" => AutoModeParsingConfVersion.x20260108,
                "2026-01-09" => AutoModeParsingConfVersion.x20260109,
                "2026-01-16" => AutoModeParsingConfVersion.x20260116,
                "2026-01-21" => AutoModeParsingConfVersion.x20260121,
                "2026-01-22" => AutoModeParsingConfVersion.x20260122,
                "2026-01-24" => AutoModeParsingConfVersion.x20260124,
                "2026-01-29" => AutoModeParsingConfVersion.x20260129,
                "2026-01-30" => AutoModeParsingConfVersion.x20260130,
                "2026-02-03" => AutoModeParsingConfVersion.x20260203,
                "2026-02-18" => AutoModeParsingConfVersion.x20260218,
                "2026-02-20" => AutoModeParsingConfVersion.x20260220,
                "2026-02-24" => AutoModeParsingConfVersion.x20260224,
                "2026-02-26" => AutoModeParsingConfVersion.x20260226,
                "2026-03-02" => AutoModeParsingConfVersion.x20260302,
                "2026-03-03" => AutoModeParsingConfVersion.x20260303,
                "2026-03-04" => AutoModeParsingConfVersion.x20260304,
                "2026-03-05" => AutoModeParsingConfVersion.x20260305,
                "2026-03-09" => AutoModeParsingConfVersion.x20260309,
                "2026-03-10" => AutoModeParsingConfVersion.x20260310,
                "2026-03-11" => AutoModeParsingConfVersion.x20260311,
                "2026-03-12" => AutoModeParsingConfVersion.x20260312,
                "2026-03-17" => AutoModeParsingConfVersion.x20260317,
                "2026-03-19" => AutoModeParsingConfVersion.x20260319,
                "2026-03-20" => AutoModeParsingConfVersion.x20260320,
                "2026-03-22" => AutoModeParsingConfVersion.x20260322,
                "2026-03-23" => AutoModeParsingConfVersion.x20260323,
                "2026-03-24" => AutoModeParsingConfVersion.x20260324,
                "2026-03-25" => AutoModeParsingConfVersion.x20260325,
                "2026-03-26" => AutoModeParsingConfVersion.x20260326,
                "2026-03-27" => AutoModeParsingConfVersion.x20260327,
                "latest" => AutoModeParsingConfVersion.Latest,
                _ => null,
            };
        }
    }
}