//HintName: G.Models.ParseV2ParametersVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ParseV2ParametersVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2025-12-11")]
        x20251211,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2025-12-18")]
        x20251218,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2025-12-31")]
        x20251231,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-01-08")]
        x20260108,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-01-09")]
        x20260109,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-01-16")]
        x20260116,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-01-21")]
        x20260121,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-01-22")]
        x20260122,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-01-24")]
        x20260124,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-01-29")]
        x20260129,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-01-30")]
        x20260130,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-02-03")]
        x20260203,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-02-18")]
        x20260218,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-02-20")]
        x20260220,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-02-24")]
        x20260224,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-02-26")]
        x20260226,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-03-02")]
        x20260302,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-03-03")]
        x20260303,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-03-04")]
        x20260304,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-03-05")]
        x20260305,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-03-09")]
        x20260309,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-03-10")]
        x20260310,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-03-11")]
        x20260311,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-03-12")]
        x20260312,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-03-17")]
        x20260317,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-03-19")]
        x20260319,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-03-20")]
        x20260320,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-03-22")]
        x20260322,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-03-23")]
        x20260323,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-03-24")]
        x20260324,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-03-25")]
        x20260325,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-03-26")]
        x20260326,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2026-03-27")]
        x20260327,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="latest")]
        Latest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParseV2ParametersVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseV2ParametersVersion value)
        {
            return value switch
            {
                ParseV2ParametersVersion.x20251211 => "2025-12-11",
                ParseV2ParametersVersion.x20251218 => "2025-12-18",
                ParseV2ParametersVersion.x20251231 => "2025-12-31",
                ParseV2ParametersVersion.x20260108 => "2026-01-08",
                ParseV2ParametersVersion.x20260109 => "2026-01-09",
                ParseV2ParametersVersion.x20260116 => "2026-01-16",
                ParseV2ParametersVersion.x20260121 => "2026-01-21",
                ParseV2ParametersVersion.x20260122 => "2026-01-22",
                ParseV2ParametersVersion.x20260124 => "2026-01-24",
                ParseV2ParametersVersion.x20260129 => "2026-01-29",
                ParseV2ParametersVersion.x20260130 => "2026-01-30",
                ParseV2ParametersVersion.x20260203 => "2026-02-03",
                ParseV2ParametersVersion.x20260218 => "2026-02-18",
                ParseV2ParametersVersion.x20260220 => "2026-02-20",
                ParseV2ParametersVersion.x20260224 => "2026-02-24",
                ParseV2ParametersVersion.x20260226 => "2026-02-26",
                ParseV2ParametersVersion.x20260302 => "2026-03-02",
                ParseV2ParametersVersion.x20260303 => "2026-03-03",
                ParseV2ParametersVersion.x20260304 => "2026-03-04",
                ParseV2ParametersVersion.x20260305 => "2026-03-05",
                ParseV2ParametersVersion.x20260309 => "2026-03-09",
                ParseV2ParametersVersion.x20260310 => "2026-03-10",
                ParseV2ParametersVersion.x20260311 => "2026-03-11",
                ParseV2ParametersVersion.x20260312 => "2026-03-12",
                ParseV2ParametersVersion.x20260317 => "2026-03-17",
                ParseV2ParametersVersion.x20260319 => "2026-03-19",
                ParseV2ParametersVersion.x20260320 => "2026-03-20",
                ParseV2ParametersVersion.x20260322 => "2026-03-22",
                ParseV2ParametersVersion.x20260323 => "2026-03-23",
                ParseV2ParametersVersion.x20260324 => "2026-03-24",
                ParseV2ParametersVersion.x20260325 => "2026-03-25",
                ParseV2ParametersVersion.x20260326 => "2026-03-26",
                ParseV2ParametersVersion.x20260327 => "2026-03-27",
                ParseV2ParametersVersion.Latest => "latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseV2ParametersVersion? ToEnum(string value)
        {
            return value switch
            {
                "2025-12-11" => ParseV2ParametersVersion.x20251211,
                "2025-12-18" => ParseV2ParametersVersion.x20251218,
                "2025-12-31" => ParseV2ParametersVersion.x20251231,
                "2026-01-08" => ParseV2ParametersVersion.x20260108,
                "2026-01-09" => ParseV2ParametersVersion.x20260109,
                "2026-01-16" => ParseV2ParametersVersion.x20260116,
                "2026-01-21" => ParseV2ParametersVersion.x20260121,
                "2026-01-22" => ParseV2ParametersVersion.x20260122,
                "2026-01-24" => ParseV2ParametersVersion.x20260124,
                "2026-01-29" => ParseV2ParametersVersion.x20260129,
                "2026-01-30" => ParseV2ParametersVersion.x20260130,
                "2026-02-03" => ParseV2ParametersVersion.x20260203,
                "2026-02-18" => ParseV2ParametersVersion.x20260218,
                "2026-02-20" => ParseV2ParametersVersion.x20260220,
                "2026-02-24" => ParseV2ParametersVersion.x20260224,
                "2026-02-26" => ParseV2ParametersVersion.x20260226,
                "2026-03-02" => ParseV2ParametersVersion.x20260302,
                "2026-03-03" => ParseV2ParametersVersion.x20260303,
                "2026-03-04" => ParseV2ParametersVersion.x20260304,
                "2026-03-05" => ParseV2ParametersVersion.x20260305,
                "2026-03-09" => ParseV2ParametersVersion.x20260309,
                "2026-03-10" => ParseV2ParametersVersion.x20260310,
                "2026-03-11" => ParseV2ParametersVersion.x20260311,
                "2026-03-12" => ParseV2ParametersVersion.x20260312,
                "2026-03-17" => ParseV2ParametersVersion.x20260317,
                "2026-03-19" => ParseV2ParametersVersion.x20260319,
                "2026-03-20" => ParseV2ParametersVersion.x20260320,
                "2026-03-22" => ParseV2ParametersVersion.x20260322,
                "2026-03-23" => ParseV2ParametersVersion.x20260323,
                "2026-03-24" => ParseV2ParametersVersion.x20260324,
                "2026-03-25" => ParseV2ParametersVersion.x20260325,
                "2026-03-26" => ParseV2ParametersVersion.x20260326,
                "2026-03-27" => ParseV2ParametersVersion.x20260327,
                "latest" => ParseV2ParametersVersion.Latest,
                _ => null,
            };
        }
    }
}