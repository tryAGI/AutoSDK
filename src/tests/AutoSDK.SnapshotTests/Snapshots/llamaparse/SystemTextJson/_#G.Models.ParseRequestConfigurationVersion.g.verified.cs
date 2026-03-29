//HintName: G.Models.ParseRequestConfigurationVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ParseRequestConfigurationVersion
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
    public static class ParseRequestConfigurationVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseRequestConfigurationVersion value)
        {
            return value switch
            {
                ParseRequestConfigurationVersion.x20251211 => "2025-12-11",
                ParseRequestConfigurationVersion.x20251218 => "2025-12-18",
                ParseRequestConfigurationVersion.x20251231 => "2025-12-31",
                ParseRequestConfigurationVersion.x20260108 => "2026-01-08",
                ParseRequestConfigurationVersion.x20260109 => "2026-01-09",
                ParseRequestConfigurationVersion.x20260116 => "2026-01-16",
                ParseRequestConfigurationVersion.x20260121 => "2026-01-21",
                ParseRequestConfigurationVersion.x20260122 => "2026-01-22",
                ParseRequestConfigurationVersion.x20260124 => "2026-01-24",
                ParseRequestConfigurationVersion.x20260129 => "2026-01-29",
                ParseRequestConfigurationVersion.x20260130 => "2026-01-30",
                ParseRequestConfigurationVersion.x20260203 => "2026-02-03",
                ParseRequestConfigurationVersion.x20260218 => "2026-02-18",
                ParseRequestConfigurationVersion.x20260220 => "2026-02-20",
                ParseRequestConfigurationVersion.x20260224 => "2026-02-24",
                ParseRequestConfigurationVersion.x20260226 => "2026-02-26",
                ParseRequestConfigurationVersion.x20260302 => "2026-03-02",
                ParseRequestConfigurationVersion.x20260303 => "2026-03-03",
                ParseRequestConfigurationVersion.x20260304 => "2026-03-04",
                ParseRequestConfigurationVersion.x20260305 => "2026-03-05",
                ParseRequestConfigurationVersion.x20260309 => "2026-03-09",
                ParseRequestConfigurationVersion.x20260310 => "2026-03-10",
                ParseRequestConfigurationVersion.x20260311 => "2026-03-11",
                ParseRequestConfigurationVersion.x20260312 => "2026-03-12",
                ParseRequestConfigurationVersion.x20260317 => "2026-03-17",
                ParseRequestConfigurationVersion.x20260319 => "2026-03-19",
                ParseRequestConfigurationVersion.x20260320 => "2026-03-20",
                ParseRequestConfigurationVersion.x20260322 => "2026-03-22",
                ParseRequestConfigurationVersion.x20260323 => "2026-03-23",
                ParseRequestConfigurationVersion.x20260324 => "2026-03-24",
                ParseRequestConfigurationVersion.x20260325 => "2026-03-25",
                ParseRequestConfigurationVersion.x20260326 => "2026-03-26",
                ParseRequestConfigurationVersion.x20260327 => "2026-03-27",
                ParseRequestConfigurationVersion.Latest => "latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseRequestConfigurationVersion? ToEnum(string value)
        {
            return value switch
            {
                "2025-12-11" => ParseRequestConfigurationVersion.x20251211,
                "2025-12-18" => ParseRequestConfigurationVersion.x20251218,
                "2025-12-31" => ParseRequestConfigurationVersion.x20251231,
                "2026-01-08" => ParseRequestConfigurationVersion.x20260108,
                "2026-01-09" => ParseRequestConfigurationVersion.x20260109,
                "2026-01-16" => ParseRequestConfigurationVersion.x20260116,
                "2026-01-21" => ParseRequestConfigurationVersion.x20260121,
                "2026-01-22" => ParseRequestConfigurationVersion.x20260122,
                "2026-01-24" => ParseRequestConfigurationVersion.x20260124,
                "2026-01-29" => ParseRequestConfigurationVersion.x20260129,
                "2026-01-30" => ParseRequestConfigurationVersion.x20260130,
                "2026-02-03" => ParseRequestConfigurationVersion.x20260203,
                "2026-02-18" => ParseRequestConfigurationVersion.x20260218,
                "2026-02-20" => ParseRequestConfigurationVersion.x20260220,
                "2026-02-24" => ParseRequestConfigurationVersion.x20260224,
                "2026-02-26" => ParseRequestConfigurationVersion.x20260226,
                "2026-03-02" => ParseRequestConfigurationVersion.x20260302,
                "2026-03-03" => ParseRequestConfigurationVersion.x20260303,
                "2026-03-04" => ParseRequestConfigurationVersion.x20260304,
                "2026-03-05" => ParseRequestConfigurationVersion.x20260305,
                "2026-03-09" => ParseRequestConfigurationVersion.x20260309,
                "2026-03-10" => ParseRequestConfigurationVersion.x20260310,
                "2026-03-11" => ParseRequestConfigurationVersion.x20260311,
                "2026-03-12" => ParseRequestConfigurationVersion.x20260312,
                "2026-03-17" => ParseRequestConfigurationVersion.x20260317,
                "2026-03-19" => ParseRequestConfigurationVersion.x20260319,
                "2026-03-20" => ParseRequestConfigurationVersion.x20260320,
                "2026-03-22" => ParseRequestConfigurationVersion.x20260322,
                "2026-03-23" => ParseRequestConfigurationVersion.x20260323,
                "2026-03-24" => ParseRequestConfigurationVersion.x20260324,
                "2026-03-25" => ParseRequestConfigurationVersion.x20260325,
                "2026-03-26" => ParseRequestConfigurationVersion.x20260326,
                "2026-03-27" => ParseRequestConfigurationVersion.x20260327,
                "latest" => ParseRequestConfigurationVersion.Latest,
                _ => null,
            };
        }
    }
}