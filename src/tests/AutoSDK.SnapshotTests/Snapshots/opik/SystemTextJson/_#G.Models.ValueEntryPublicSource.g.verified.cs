//HintName: G.Models.ValueEntryPublicSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ValueEntryPublicSource
    {
        /// <summary>
        /// 
        /// </summary>
        OnlineScoring,
        /// <summary>
        /// 
        /// </summary>
        Sdk,
        /// <summary>
        /// 
        /// </summary>
        Ui,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ValueEntryPublicSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ValueEntryPublicSource value)
        {
            return value switch
            {
                ValueEntryPublicSource.OnlineScoring => "online_scoring",
                ValueEntryPublicSource.Sdk => "sdk",
                ValueEntryPublicSource.Ui => "ui",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ValueEntryPublicSource? ToEnum(string value)
        {
            return value switch
            {
                "online_scoring" => ValueEntryPublicSource.OnlineScoring,
                "sdk" => ValueEntryPublicSource.Sdk,
                "ui" => ValueEntryPublicSource.Ui,
                _ => null,
            };
        }
    }
}