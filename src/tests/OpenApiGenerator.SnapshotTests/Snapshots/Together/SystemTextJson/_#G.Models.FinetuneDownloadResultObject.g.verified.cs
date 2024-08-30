//HintName: G.Models.FinetuneDownloadResultObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FinetuneDownloadResultObject
    {
        /// <summary>
        /// 
        /// </summary>
        Local,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinetuneDownloadResultObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinetuneDownloadResultObject value)
        {
            return value switch
            {
                FinetuneDownloadResultObject.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinetuneDownloadResultObject? ToEnum(string value)
        {
            return value switch
            {
                "local" => FinetuneDownloadResultObject.Local,
                _ => null,
            };
        }
    }
}