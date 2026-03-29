//HintName: G.Models.ValueEntrySource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ValueEntrySource
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
    public static class ValueEntrySourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ValueEntrySource value)
        {
            return value switch
            {
                ValueEntrySource.OnlineScoring => "online_scoring",
                ValueEntrySource.Sdk => "sdk",
                ValueEntrySource.Ui => "ui",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ValueEntrySource? ToEnum(string value)
        {
            return value switch
            {
                "online_scoring" => ValueEntrySource.OnlineScoring,
                "sdk" => ValueEntrySource.Sdk,
                "ui" => ValueEntrySource.Ui,
                _ => null,
            };
        }
    }
}