//HintName: G.Models.DatasetItemWriteSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DatasetItemWriteSource
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
    public static class DatasetItemWriteSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetItemWriteSource value)
        {
            return value switch
            {
                DatasetItemWriteSource.Manual => "manual",
                DatasetItemWriteSource.Sdk => "sdk",
                DatasetItemWriteSource.Span => "span",
                DatasetItemWriteSource.Trace => "trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetItemWriteSource? ToEnum(string value)
        {
            return value switch
            {
                "manual" => DatasetItemWriteSource.Manual,
                "sdk" => DatasetItemWriteSource.Sdk,
                "span" => DatasetItemWriteSource.Span,
                "trace" => DatasetItemWriteSource.Trace,
                _ => null,
            };
        }
    }
}