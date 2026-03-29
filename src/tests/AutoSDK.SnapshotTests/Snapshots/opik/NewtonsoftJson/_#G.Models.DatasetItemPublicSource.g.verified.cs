//HintName: G.Models.DatasetItemPublicSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DatasetItemPublicSource
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
    public static class DatasetItemPublicSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetItemPublicSource value)
        {
            return value switch
            {
                DatasetItemPublicSource.Manual => "manual",
                DatasetItemPublicSource.Sdk => "sdk",
                DatasetItemPublicSource.Span => "span",
                DatasetItemPublicSource.Trace => "trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetItemPublicSource? ToEnum(string value)
        {
            return value switch
            {
                "manual" => DatasetItemPublicSource.Manual,
                "sdk" => DatasetItemPublicSource.Sdk,
                "span" => DatasetItemPublicSource.Span,
                "trace" => DatasetItemPublicSource.Trace,
                _ => null,
            };
        }
    }
}