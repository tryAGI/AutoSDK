//HintName: G.Models.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="classify_v2")]
        ClassifyV2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="extract_v2")]
        ExtractV2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parse_v2")]
        ParseV2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="split_v1")]
        SplitV1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item value)
        {
            return value switch
            {
                ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item.ClassifyV2 => "classify_v2",
                ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item.ExtractV2 => "extract_v2",
                ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item.ParseV2 => "parse_v2",
                ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item.SplitV1 => "split_v1",
                ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "classify_v2" => ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item.ClassifyV2,
                "extract_v2" => ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item.ExtractV2,
                "parse_v2" => ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item.ParseV2,
                "split_v1" => ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item.SplitV1,
                "unknown" => ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item.Unknown,
                _ => null,
            };
        }
    }
}