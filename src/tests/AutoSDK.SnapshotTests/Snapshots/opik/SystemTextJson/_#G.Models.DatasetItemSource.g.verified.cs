//HintName: G.Models.DatasetItemSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DatasetItemSource
    {
        /// <summary>
        /// 
        /// </summary>
        Manual,
        /// <summary>
        /// 
        /// </summary>
        Sdk,
        /// <summary>
        /// 
        /// </summary>
        Span,
        /// <summary>
        /// 
        /// </summary>
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