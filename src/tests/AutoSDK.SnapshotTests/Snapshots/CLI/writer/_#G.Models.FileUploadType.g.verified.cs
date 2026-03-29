//HintName: G.Models.FileUploadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of file upload method supported by the application.
    /// </summary>
    public enum FileUploadType
    {
        /// <summary>
        /// 
        /// </summary>
        FileId,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileUploadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileUploadType value)
        {
            return value switch
            {
                FileUploadType.FileId => "file_id",
                FileUploadType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileUploadType? ToEnum(string value)
        {
            return value switch
            {
                "file_id" => FileUploadType.FileId,
                "url" => FileUploadType.Url,
                _ => null,
            };
        }
    }
}