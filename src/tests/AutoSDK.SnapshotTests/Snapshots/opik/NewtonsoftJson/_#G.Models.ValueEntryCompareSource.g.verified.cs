//HintName: G.Models.ValueEntryCompareSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ValueEntryCompareSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="online_scoring")]
        OnlineScoring,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sdk")]
        Sdk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ui")]
        Ui,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ValueEntryCompareSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ValueEntryCompareSource value)
        {
            return value switch
            {
                ValueEntryCompareSource.OnlineScoring => "online_scoring",
                ValueEntryCompareSource.Sdk => "sdk",
                ValueEntryCompareSource.Ui => "ui",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ValueEntryCompareSource? ToEnum(string value)
        {
            return value switch
            {
                "online_scoring" => ValueEntryCompareSource.OnlineScoring,
                "sdk" => ValueEntryCompareSource.Sdk,
                "ui" => ValueEntryCompareSource.Ui,
                _ => null,
            };
        }
    }
}