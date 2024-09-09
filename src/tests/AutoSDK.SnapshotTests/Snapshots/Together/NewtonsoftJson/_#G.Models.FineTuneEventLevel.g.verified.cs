//HintName: G.Models.FineTuneEventLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FineTuneEventLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="info")]
        Info,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="warning")]
        Warning,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="legacy_info")]
        LegacyInfo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="legacy_iwarning")]
        LegacyIwarning,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="legacy_ierror")]
        LegacyIerror,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneEventLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneEventLevel value)
        {
            return value switch
            {
                FineTuneEventLevel.Info => "info",
                FineTuneEventLevel.Warning => "warning",
                FineTuneEventLevel.Error => "error",
                FineTuneEventLevel.LegacyInfo => "legacy_info",
                FineTuneEventLevel.LegacyIwarning => "legacy_iwarning",
                FineTuneEventLevel.LegacyIerror => "legacy_ierror",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneEventLevel? ToEnum(string value)
        {
            return value switch
            {
                "info" => FineTuneEventLevel.Info,
                "warning" => FineTuneEventLevel.Warning,
                "error" => FineTuneEventLevel.Error,
                "legacy_info" => FineTuneEventLevel.LegacyInfo,
                "legacy_iwarning" => FineTuneEventLevel.LegacyIwarning,
                "legacy_ierror" => FineTuneEventLevel.LegacyIerror,
                _ => null,
            };
        }
    }
}