//HintName: G.Models.DatasetItemCompareSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DatasetItemCompareSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="manual")]
        Manual,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sdk")]
        Sdk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="span")]
        Span,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trace")]
        Trace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetItemCompareSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetItemCompareSource value)
        {
            return value switch
            {
                DatasetItemCompareSource.Manual => "manual",
                DatasetItemCompareSource.Sdk => "sdk",
                DatasetItemCompareSource.Span => "span",
                DatasetItemCompareSource.Trace => "trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetItemCompareSource? ToEnum(string value)
        {
            return value switch
            {
                "manual" => DatasetItemCompareSource.Manual,
                "sdk" => DatasetItemCompareSource.Sdk,
                "span" => DatasetItemCompareSource.Span,
                "trace" => DatasetItemCompareSource.Trace,
                _ => null,
            };
        }
    }
}