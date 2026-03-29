//HintName: G.Models.AssetContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// AssetContentType specifies the MIME type of a particular asset, and provides some helper methods and properties
    /// </summary>
    public enum AssetContentType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplicationFontWoff,
        /// <summary>
        /// 
        /// </summary>
        ApplicationJson,
        /// <summary>
        /// 
        /// </summary>
        ApplicationPdf,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndMsPowerpoint,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndSynthesiaFolder,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndSynthesiaFontFamily,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndSynthesiaStudioDubbedVideo,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndSynthesiaStudioImportedVideo,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndSynthesiaStudioPhotoAvatarVideo,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndSynthesiaStudioSynthesiaAcademyVideo,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndSynthesiaStudioSynthesiaDemoVideo,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndSynthesiaStudioSynthesiaExampleVideo,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndSynthesiaStudioSynthesiaFeatureOverviewVideo,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndSynthesiaStudioSynthesiaProcessedGif,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndSynthesiaStudioSynthesiaTemplate,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndSynthesiaStudioSynthesiaWelcomeWebinarVideo,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndSynthesiaStudioUserCourse,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndSynthesiaStudioUserTemplate,
        /// <summary>
        /// 
        /// </summary>
        ApplicationVndSynthesiaStudioVideo,
        /// <summary>
        /// 
        /// </summary>
        ApplicationXXliffPlusxml,
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
        AudioMp4,
        /// <summary>
        /// 
        /// </summary>
        AudioMpeg,
        /// <summary>
        /// 
        /// </summary>
        AudioOgg,
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
        FontOtf,
        /// <summary>
        /// 
        /// </summary>
        FontTtf,
        /// <summary>
        /// 
        /// </summary>
        FontWoff,
        /// <summary>
        /// 
        /// </summary>
        FontWoff2,
        /// <summary>
        /// 
        /// </summary>
        ImageGif,
        /// <summary>
        /// 
        /// </summary>
        ImageJpeg,
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
        ImageWebp,
        /// <summary>
        /// 
        /// </summary>
        TextCsv,
        /// <summary>
        /// 
        /// </summary>
        VideoMp4,
        /// <summary>
        /// 
        /// </summary>
        VideoQuicktime,
        /// <summary>
        /// 
        /// </summary>
        VideoWebm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetContentType value)
        {
            return value switch
            {
                AssetContentType.ApplicationFontWoff => "application/font-woff",
                AssetContentType.ApplicationJson => "application/json",
                AssetContentType.ApplicationPdf => "application/pdf",
                AssetContentType.ApplicationVndMsPowerpoint => "application/vnd.ms-powerpoint",
                AssetContentType.ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation => "application/vnd.openxmlformats-officedocument.presentationml.presentation",
                AssetContentType.ApplicationVndSynthesiaFolder => "application/vnd.synthesia.folder",
                AssetContentType.ApplicationVndSynthesiaFontFamily => "application/vnd.synthesia.font-family",
                AssetContentType.ApplicationVndSynthesiaStudioDubbedVideo => "application/vnd.synthesia.studio-dubbed-video",
                AssetContentType.ApplicationVndSynthesiaStudioImportedVideo => "application/vnd.synthesia.studio-imported-video",
                AssetContentType.ApplicationVndSynthesiaStudioPhotoAvatarVideo => "application/vnd.synthesia.studio-photo-avatar-video",
                AssetContentType.ApplicationVndSynthesiaStudioSynthesiaAcademyVideo => "application/vnd.synthesia.studio-synthesia-academy-video",
                AssetContentType.ApplicationVndSynthesiaStudioSynthesiaDemoVideo => "application/vnd.synthesia.studio-synthesia-demo-video",
                AssetContentType.ApplicationVndSynthesiaStudioSynthesiaExampleVideo => "application/vnd.synthesia.studio-synthesia-example-video",
                AssetContentType.ApplicationVndSynthesiaStudioSynthesiaFeatureOverviewVideo => "application/vnd.synthesia.studio-synthesia-feature-overview-video",
                AssetContentType.ApplicationVndSynthesiaStudioSynthesiaProcessedGif => "application/vnd.synthesia.studio-synthesia-processed-gif",
                AssetContentType.ApplicationVndSynthesiaStudioSynthesiaTemplate => "application/vnd.synthesia.studio-synthesia-template",
                AssetContentType.ApplicationVndSynthesiaStudioSynthesiaWelcomeWebinarVideo => "application/vnd.synthesia.studio-synthesia-welcome-webinar-video",
                AssetContentType.ApplicationVndSynthesiaStudioUserCourse => "application/vnd.synthesia.studio-user-course",
                AssetContentType.ApplicationVndSynthesiaStudioUserTemplate => "application/vnd.synthesia.studio-user-template",
                AssetContentType.ApplicationVndSynthesiaStudioVideo => "application/vnd.synthesia.studio-video",
                AssetContentType.ApplicationXXliffPlusxml => "application/x-xliff+xml",
                AssetContentType.AudioAac => "audio/aac",
                AssetContentType.AudioFlac => "audio/flac",
                AssetContentType.AudioMp4 => "audio/mp4",
                AssetContentType.AudioMpeg => "audio/mpeg",
                AssetContentType.AudioOgg => "audio/ogg",
                AssetContentType.AudioWav => "audio/wav",
                AssetContentType.AudioWebm => "audio/webm",
                AssetContentType.FontOtf => "font/otf",
                AssetContentType.FontTtf => "font/ttf",
                AssetContentType.FontWoff => "font/woff",
                AssetContentType.FontWoff2 => "font/woff2",
                AssetContentType.ImageGif => "image/gif",
                AssetContentType.ImageJpeg => "image/jpeg",
                AssetContentType.ImagePng => "image/png",
                AssetContentType.ImageSvgPlusxml => "image/svg+xml",
                AssetContentType.ImageWebp => "image/webp",
                AssetContentType.TextCsv => "text/csv",
                AssetContentType.VideoMp4 => "video/mp4",
                AssetContentType.VideoQuicktime => "video/quicktime",
                AssetContentType.VideoWebm => "video/webm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetContentType? ToEnum(string value)
        {
            return value switch
            {
                "application/font-woff" => AssetContentType.ApplicationFontWoff,
                "application/json" => AssetContentType.ApplicationJson,
                "application/pdf" => AssetContentType.ApplicationPdf,
                "application/vnd.ms-powerpoint" => AssetContentType.ApplicationVndMsPowerpoint,
                "application/vnd.openxmlformats-officedocument.presentationml.presentation" => AssetContentType.ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation,
                "application/vnd.synthesia.folder" => AssetContentType.ApplicationVndSynthesiaFolder,
                "application/vnd.synthesia.font-family" => AssetContentType.ApplicationVndSynthesiaFontFamily,
                "application/vnd.synthesia.studio-dubbed-video" => AssetContentType.ApplicationVndSynthesiaStudioDubbedVideo,
                "application/vnd.synthesia.studio-imported-video" => AssetContentType.ApplicationVndSynthesiaStudioImportedVideo,
                "application/vnd.synthesia.studio-photo-avatar-video" => AssetContentType.ApplicationVndSynthesiaStudioPhotoAvatarVideo,
                "application/vnd.synthesia.studio-synthesia-academy-video" => AssetContentType.ApplicationVndSynthesiaStudioSynthesiaAcademyVideo,
                "application/vnd.synthesia.studio-synthesia-demo-video" => AssetContentType.ApplicationVndSynthesiaStudioSynthesiaDemoVideo,
                "application/vnd.synthesia.studio-synthesia-example-video" => AssetContentType.ApplicationVndSynthesiaStudioSynthesiaExampleVideo,
                "application/vnd.synthesia.studio-synthesia-feature-overview-video" => AssetContentType.ApplicationVndSynthesiaStudioSynthesiaFeatureOverviewVideo,
                "application/vnd.synthesia.studio-synthesia-processed-gif" => AssetContentType.ApplicationVndSynthesiaStudioSynthesiaProcessedGif,
                "application/vnd.synthesia.studio-synthesia-template" => AssetContentType.ApplicationVndSynthesiaStudioSynthesiaTemplate,
                "application/vnd.synthesia.studio-synthesia-welcome-webinar-video" => AssetContentType.ApplicationVndSynthesiaStudioSynthesiaWelcomeWebinarVideo,
                "application/vnd.synthesia.studio-user-course" => AssetContentType.ApplicationVndSynthesiaStudioUserCourse,
                "application/vnd.synthesia.studio-user-template" => AssetContentType.ApplicationVndSynthesiaStudioUserTemplate,
                "application/vnd.synthesia.studio-video" => AssetContentType.ApplicationVndSynthesiaStudioVideo,
                "application/x-xliff+xml" => AssetContentType.ApplicationXXliffPlusxml,
                "audio/aac" => AssetContentType.AudioAac,
                "audio/flac" => AssetContentType.AudioFlac,
                "audio/mp4" => AssetContentType.AudioMp4,
                "audio/mpeg" => AssetContentType.AudioMpeg,
                "audio/ogg" => AssetContentType.AudioOgg,
                "audio/wav" => AssetContentType.AudioWav,
                "audio/webm" => AssetContentType.AudioWebm,
                "font/otf" => AssetContentType.FontOtf,
                "font/ttf" => AssetContentType.FontTtf,
                "font/woff" => AssetContentType.FontWoff,
                "font/woff2" => AssetContentType.FontWoff2,
                "image/gif" => AssetContentType.ImageGif,
                "image/jpeg" => AssetContentType.ImageJpeg,
                "image/png" => AssetContentType.ImagePng,
                "image/svg+xml" => AssetContentType.ImageSvgPlusxml,
                "image/webp" => AssetContentType.ImageWebp,
                "text/csv" => AssetContentType.TextCsv,
                "video/mp4" => AssetContentType.VideoMp4,
                "video/quicktime" => AssetContentType.VideoQuicktime,
                "video/webm" => AssetContentType.VideoWebm,
                _ => null,
            };
        }
    }
}