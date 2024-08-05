//HintName: G.Models.UploadObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always "upload".
    /// </summary>
    public enum UploadObject
    {
        /// <summary>
        /// 
        /// </summary>
        Upload,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadObject value)
        {
            return value switch
            {
                UploadObject.Upload => "upload",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadObject? ToEnum(string value)
        {
            return value switch
            {
                "upload" => UploadObject.Upload,
                _ => null,
            };
        }
    }
}