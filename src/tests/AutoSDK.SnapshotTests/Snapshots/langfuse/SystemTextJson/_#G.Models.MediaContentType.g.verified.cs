//HintName: G.Models.MediaContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The MIME type of the media record
    /// </summary>
    public enum MediaContentType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplicationGzip,
        /// <summary>
        /// 
        /// </summary>
        ApplicationJavascript,
        /// <summary>
        /// 
        /// </summary>
        ApplicationJson,
        /// <summary>
        /// 
        /// </summary>
        ApplicationMsword,
        /// <summary>
        /// 
        /// </summary>
        ApplicationOctetStream,
        /// <summary>
        /// 
        /// </summary>
        ApplicationPdf,
        /// <summary>
        /// 
        /// </summary>
        ApplicationRtf,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndApacheParquet,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndMsExcel,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlSheet,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlDocument,
        /// <summary>
        /// 
        /// </summary>
        ApplicationX7zCompressed,
        /// <summary>
        /// 
        /// </summary>
        ApplicationXNdjson,
        /// <summary>
        /// 
        /// </summary>
        ApplicationXTar,
        /// <summary>
        /// 
        /// </summary>
        ApplicationXYaml,
        /// <summary>
        /// 
        /// </summary>
        ApplicationXml,
        /// <summary>
        /// 
        /// </summary>
        ApplicationZip,
        /// <summary>
        /// 
        /// </summary>
        AudioAac,
        /// <summary>
        /// 
        /// </summary>
        AudioFlac,
        /// <summary>
        /// 
        /// </summary>
        AudioMp3,
        /// <summary>
        /// 
        /// </summary>
        AudioMp4,
        /// <summary>
        /// 
        /// </summary>
        AudioMpeg,
        /// <summary>
        /// 
        /// </summary>
        AudioOga,
        /// <summary>
        /// 
        /// </summary>
        AudioOgg,
        /// <summary>
        /// 
        /// </summary>
        AudioOpus,
        /// <summary>
        /// 
        /// </summary>
        AudioWav,
        /// <summary>
        /// 
        /// </summary>
        AudioWebm,
        /// <summary>
        /// 
        /// </summary>
        ImageAvif,
        /// <summary>
        /// 
        /// </summary>
        ImageBmp,
        /// <summary>
        /// 
        /// </summary>
        ImageGif,
        /// <summary>
        /// 
        /// </summary>
        ImageHeic,
        /// <summary>
        /// 
        /// </summary>
        ImageJpeg,
        /// <summary>
        /// 
        /// </summary>
        ImageJpg,
        /// <summary>
        /// 
        /// </summary>
        ImagePng,
        /// <summary>
        /// 
        /// </summary>
        ImageSvgPlusxml,
        /// <summary>
        /// 
        /// </summary>
        ImageTiff,
        /// <summary>
        /// 
        /// </summary>
        ImageWebp,
        /// <summary>
        /// 
        /// </summary>
        TextCss,
        /// <summary>
        /// 
        /// </summary>
        TextCsv,
        /// <summary>
        /// 
        /// </summary>
        TextHtml,
        /// <summary>
        /// 
        /// </summary>
        TextMarkdown,
        /// <summary>
        /// 
        /// </summary>
        TextPlain,
        /// <summary>
        /// 
        /// </summary>
        TextXPython,
        /// <summary>
        /// 
        /// </summary>
        TextXTypescript,
        /// <summary>
        /// 
        /// </summary>
        VideoMp4,
        /// <summary>
        /// 
        /// </summary>
        VideoMpeg,
        /// <summary>
        /// 
        /// </summary>
        VideoOgg,
        /// <summary>
        /// 
        /// </summary>
        VideoQuicktime,
        /// <summary>
        /// 
        /// </summary>
        VideoWebm,
        /// <summary>
        /// 
        /// </summary>
        VideoXMatroska,
        /// <summary>
        /// 
        /// </summary>
        VideoXMsvideo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MediaContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MediaContentType value)
        {
            return value switch
            {
                MediaContentType.ApplicationGzip => "application/gzip",
                MediaContentType.ApplicationJavascript => "application/javascript",
                MediaContentType.ApplicationJson => "application/json",
                MediaContentType.ApplicationMsword => "application/msword",
                MediaContentType.ApplicationOctetStream => "application/octet-stream",
                MediaContentType.ApplicationPdf => "application/pdf",
                MediaContentType.ApplicationRtf => "application/rtf",
                MediaContentType.ApplicationVndApacheParquet => "application/vnd.apache.parquet",
                MediaContentType.ApplicationVndMsExcel => "application/vnd.ms-excel",
                MediaContentType.ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation => "application/vnd.openxmlformats-officedocument.presentationml.presentation",
                MediaContentType.ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlSheet => "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                MediaContentType.ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlDocument => "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
                MediaContentType.ApplicationX7zCompressed => "application/x-7z-compressed",
                MediaContentType.ApplicationXNdjson => "application/x-ndjson",
                MediaContentType.ApplicationXTar => "application/x-tar",
                MediaContentType.ApplicationXYaml => "application/x-yaml",
                MediaContentType.ApplicationXml => "application/xml",
                MediaContentType.ApplicationZip => "application/zip",
                MediaContentType.AudioAac => "audio/aac",
                MediaContentType.AudioFlac => "audio/flac",
                MediaContentType.AudioMp3 => "audio/mp3",
                MediaContentType.AudioMp4 => "audio/mp4",
                MediaContentType.AudioMpeg => "audio/mpeg",
                MediaContentType.AudioOga => "audio/oga",
                MediaContentType.AudioOgg => "audio/ogg",
                MediaContentType.AudioOpus => "audio/opus",
                MediaContentType.AudioWav => "audio/wav",
                MediaContentType.AudioWebm => "audio/webm",
                MediaContentType.ImageAvif => "image/avif",
                MediaContentType.ImageBmp => "image/bmp",
                MediaContentType.ImageGif => "image/gif",
                MediaContentType.ImageHeic => "image/heic",
                MediaContentType.ImageJpeg => "image/jpeg",
                MediaContentType.ImageJpg => "image/jpg",
                MediaContentType.ImagePng => "image/png",
                MediaContentType.ImageSvgPlusxml => "image/svg+xml",
                MediaContentType.ImageTiff => "image/tiff",
                MediaContentType.ImageWebp => "image/webp",
                MediaContentType.TextCss => "text/css",
                MediaContentType.TextCsv => "text/csv",
                MediaContentType.TextHtml => "text/html",
                MediaContentType.TextMarkdown => "text/markdown",
                MediaContentType.TextPlain => "text/plain",
                MediaContentType.TextXPython => "text/x-python",
                MediaContentType.TextXTypescript => "text/x-typescript",
                MediaContentType.VideoMp4 => "video/mp4",
                MediaContentType.VideoMpeg => "video/mpeg",
                MediaContentType.VideoOgg => "video/ogg",
                MediaContentType.VideoQuicktime => "video/quicktime",
                MediaContentType.VideoWebm => "video/webm",
                MediaContentType.VideoXMatroska => "video/x-matroska",
                MediaContentType.VideoXMsvideo => "video/x-msvideo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MediaContentType? ToEnum(string value)
        {
            return value switch
            {
                "application/gzip" => MediaContentType.ApplicationGzip,
                "application/javascript" => MediaContentType.ApplicationJavascript,
                "application/json" => MediaContentType.ApplicationJson,
                "application/msword" => MediaContentType.ApplicationMsword,
                "application/octet-stream" => MediaContentType.ApplicationOctetStream,
                "application/pdf" => MediaContentType.ApplicationPdf,
                "application/rtf" => MediaContentType.ApplicationRtf,
                "application/vnd.apache.parquet" => MediaContentType.ApplicationVndApacheParquet,
                "application/vnd.ms-excel" => MediaContentType.ApplicationVndMsExcel,
                "application/vnd.openxmlformats-officedocument.presentationml.presentation" => MediaContentType.ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" => MediaContentType.ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlSheet,
                "application/vnd.openxmlformats-officedocument.wordprocessingml.document" => MediaContentType.ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlDocument,
                "application/x-7z-compressed" => MediaContentType.ApplicationX7zCompressed,
                "application/x-ndjson" => MediaContentType.ApplicationXNdjson,
                "application/x-tar" => MediaContentType.ApplicationXTar,
                "application/x-yaml" => MediaContentType.ApplicationXYaml,
                "application/xml" => MediaContentType.ApplicationXml,
                "application/zip" => MediaContentType.ApplicationZip,
                "audio/aac" => MediaContentType.AudioAac,
                "audio/flac" => MediaContentType.AudioFlac,
                "audio/mp3" => MediaContentType.AudioMp3,
                "audio/mp4" => MediaContentType.AudioMp4,
                "audio/mpeg" => MediaContentType.AudioMpeg,
                "audio/oga" => MediaContentType.AudioOga,
                "audio/ogg" => MediaContentType.AudioOgg,
                "audio/opus" => MediaContentType.AudioOpus,
                "audio/wav" => MediaContentType.AudioWav,
                "audio/webm" => MediaContentType.AudioWebm,
                "image/avif" => MediaContentType.ImageAvif,
                "image/bmp" => MediaContentType.ImageBmp,
                "image/gif" => MediaContentType.ImageGif,
                "image/heic" => MediaContentType.ImageHeic,
                "image/jpeg" => MediaContentType.ImageJpeg,
                "image/jpg" => MediaContentType.ImageJpg,
                "image/png" => MediaContentType.ImagePng,
                "image/svg+xml" => MediaContentType.ImageSvgPlusxml,
                "image/tiff" => MediaContentType.ImageTiff,
                "image/webp" => MediaContentType.ImageWebp,
                "text/css" => MediaContentType.TextCss,
                "text/csv" => MediaContentType.TextCsv,
                "text/html" => MediaContentType.TextHtml,
                "text/markdown" => MediaContentType.TextMarkdown,
                "text/plain" => MediaContentType.TextPlain,
                "text/x-python" => MediaContentType.TextXPython,
                "text/x-typescript" => MediaContentType.TextXTypescript,
                "video/mp4" => MediaContentType.VideoMp4,
                "video/mpeg" => MediaContentType.VideoMpeg,
                "video/ogg" => MediaContentType.VideoOgg,
                "video/quicktime" => MediaContentType.VideoQuicktime,
                "video/webm" => MediaContentType.VideoWebm,
                "video/x-matroska" => MediaContentType.VideoXMatroska,
                "video/x-msvideo" => MediaContentType.VideoXMsvideo,
                _ => null,
            };
        }
    }
}