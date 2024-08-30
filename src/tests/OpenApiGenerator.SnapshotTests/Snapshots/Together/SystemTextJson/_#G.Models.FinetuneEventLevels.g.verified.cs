//HintName: G.Models.FinetuneEventLevels.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FinetuneEventLevels
    {
        /// <summary>
        /// 
        /// </summary>
        Info,
        /// <summary>
        /// 
        /// </summary>
        Warning,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        LegacyInfo,
        /// <summary>
        /// 
        /// </summary>
        LegacyIwarning,
        /// <summary>
        /// 
        /// </summary>
        LegacyIerror,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinetuneEventLevelsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinetuneEventLevels value)
        {
            return value switch
            {
                FinetuneEventLevels.Info => "info",
                FinetuneEventLevels.Warning => "warning",
                FinetuneEventLevels.Error => "error",
                FinetuneEventLevels.LegacyInfo => "legacy_info",
                FinetuneEventLevels.LegacyIwarning => "legacy_iwarning",
                FinetuneEventLevels.LegacyIerror => "legacy_ierror",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinetuneEventLevels? ToEnum(string value)
        {
            return value switch
            {
                "info" => FinetuneEventLevels.Info,
                "warning" => FinetuneEventLevels.Warning,
                "error" => FinetuneEventLevels.Error,
                "legacy_info" => FinetuneEventLevels.LegacyInfo,
                "legacy_iwarning" => FinetuneEventLevels.LegacyIwarning,
                "legacy_ierror" => FinetuneEventLevels.LegacyIerror,
                _ => null,
            };
        }
    }
}