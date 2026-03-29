//HintName: G.Models.DatasetItemSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DatasetItemSource
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
    public static class DatasetItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetItemSource value)
        {
            return value switch
            {
                DatasetItemSource.Manual => "manual",
                DatasetItemSource.Sdk => "sdk",
                DatasetItemSource.Span => "span",
                DatasetItemSource.Trace => "trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetItemSource? ToEnum(string value)
        {
            return value switch
            {
                "manual" => DatasetItemSource.Manual,
                "sdk" => DatasetItemSource.Sdk,
                "span" => DatasetItemSource.Span,
                "trace" => DatasetItemSource.Trace,
                _ => null,
            };
        }
    }
}