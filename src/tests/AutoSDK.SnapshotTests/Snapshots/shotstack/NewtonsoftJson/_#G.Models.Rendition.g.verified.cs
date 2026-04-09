//HintName: G.Models.Rendition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A rendition is a new output file that is generated from the source. The rendition can be encoded to a different format and have transformations applied to it such as resizing, cropping, etc...
    /// </summary>
    public sealed partial class Rendition
    {
        /// <summary>
        /// The output format to encode the file to. You can only encode a file to the same type, i.e. a video to a video or an image to an image. You can't encode a video as an image. The following formats are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`mp4` - mp4 video file (video only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`webm` - webm video file (video only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`mov` - mov video file (video only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`avi` - avi video file (video only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`mkv` - mkv video file (video only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`ogv` - ogv video file (video only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`wmv` - wmv video file (video only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`avif` - avif video file (video only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`gif` - animated gif file (video only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`jpg` - jpg image file (image only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`png` - png image file (image only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`webp` - webp image file (image only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`tif` - tif image file (image only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`mp3` - mp3 audio file (audio only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`wav` - wav audio file (audio only)&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: mp4
        /// </summary>
        /// <example>mp4</example>
        [global::Newtonsoft.Json.JsonProperty("format")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RenditionFormatJsonConverter))]
        public global::G.RenditionFormat? Format { get; set; }

        /// <summary>
        /// Set a custom size for a video or image in pixels. When using a custom size omit the `resolution` and `aspectRatio`. Custom sizes must be divisible by 2 based on the encoder specifications.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public global::G.Size? Size { get; set; }

        /// <summary>
        /// Set how the rendition should be scaled and cropped when using a size with an aspect ratio that is different from the source. Fit applies to both videos and images. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`crop` &lt;b&gt;(default)&lt;/b&gt; - scale the rendition to fill the output area while maintaining the aspect ratio. The rendition will be cropped if it exceeds the bounds of the output.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`cover` - stretch the rendition to fill the output without maintaining the aspect ratio.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`contain` - fit the entire rendition within the output while maintaining the original aspect ratio.&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: crop
        /// </summary>
        /// <example>crop</example>
        [global::Newtonsoft.Json.JsonProperty("fit")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RenditionFitJsonConverter))]
        public global::G.RenditionFit? Fit { get; set; }

        /// <summary>
        /// The preset output resolution of the video or image. This is a convenience property that sets the width and height based on industry standard resolutions. The following resolutions are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`preview` - 512px x 288px&lt;/li&gt;<br/>
        ///   &lt;li&gt;`mobile` - 640px x 360px&lt;/li&gt;<br/>
        ///   &lt;li&gt;`sd` - 1024px x 576px&lt;/li&gt;<br/>
        ///   &lt;li&gt;`hd` - 1280px x 720px&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fhd` - 1920px x 1080px&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: hd
        /// </summary>
        /// <example>hd</example>
        [global::Newtonsoft.Json.JsonProperty("resolution")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RenditionResolutionJsonConverter))]
        public global::G.RenditionResolution? Resolution { get; set; }

        /// <summary>
        /// Adjust the visual quality of the video or image. The higher the value, the sharper the image quality but the larger file size and slower the encoding process. When specifying quality, the goal is to balance file size vs visual quality.<br/>
        /// Quality is a value between 1 and 100 where 1 is fully compressed with low image quality and 100 is close to lossless with high image quality and large file size. Sane values are between 50 and 75. Omitting the quality parameter will result in an asset optimised for encoding speed, file size and visual quality.<br/>
        /// Example: 70
        /// </summary>
        /// <example>70</example>
        [global::Newtonsoft.Json.JsonProperty("quality")]
        public int? Quality { get; set; }

        /// <summary>
        /// Change the frame rate of a video asset. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`12` - 12fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`15` - 15fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`24` - 24fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`23.976` - 23.976fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`25` (default) - 25fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`29.97` - 29.97fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`30` - 30fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`48` - 48fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`50` - 50fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`59.94` - 59.94fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`60` - 60fps&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: 25
        /// </summary>
        /// <example>25</example>
        [global::Newtonsoft.Json.JsonProperty("fps")]
        public double? Fps { get; set; }

        /// <summary>
        /// Set the playback speed of a video or audio file. Allows you to preserve the pitch of the audio so that it is sped up without sounding too high pitched or too low.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public global::G.Speed? Speed { get; set; }

        /// <summary>
        /// The keyframe interval is useful to optimize playback, seeking and smoother scrubbing in browsers. The value sets the number of frames between a keyframe. The lower the number, the larger the file. Try a value between 10 and 25 for smooth scrubbing.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::Newtonsoft.Json.JsonProperty("keyframeInterval")]
        public int? KeyframeInterval { get; set; }

        /// <summary>
        /// Attempt to fix audio and video sync issues. This can occur when recording devices, such as smartphones and<br/>
        ///  web cams use compression techniques like [Variable Frame Rate](https://en.wikipedia.org/wiki/Variable_frame_rate)<br/>
        ///  (VFR) which can cause audio and video to go out of sync. This option will attempt to fix the sync issues.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("fixOffset")]
        public bool? FixOffset { get; set; }

        /// <summary>
        /// Automatically reset the rotation of the video based on the orientation metadata in the video file. This is useful for videos recorded on smartphones that have orientation metadata that may not work correctly with certain video editing software, including the Shotstack Edit API.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("fixRotation")]
        public bool? FixRotation { get; set; }

        /// <summary>
        /// Enhancements that can be applied to a rendition. Currently only supports the Dolby audio enhancement.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enhance")]
        public global::G.Enhancements? Enhance { get; set; }

        /// <summary>
        /// A custom name for the generated rendition file. The file extension will be automatically added based on the format of the rendition. If no filename is provided, the rendition ID will be used.<br/>
        /// Example: my-video
        /// </summary>
        /// <example>my-video</example>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Rendition" /> class.
        /// </summary>
        /// <param name="format">
        /// The output format to encode the file to. You can only encode a file to the same type, i.e. a video to a video or an image to an image. You can't encode a video as an image. The following formats are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`mp4` - mp4 video file (video only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`webm` - webm video file (video only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`mov` - mov video file (video only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`avi` - avi video file (video only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`mkv` - mkv video file (video only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`ogv` - ogv video file (video only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`wmv` - wmv video file (video only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`avif` - avif video file (video only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`gif` - animated gif file (video only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`jpg` - jpg image file (image only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`png` - png image file (image only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`webp` - webp image file (image only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`tif` - tif image file (image only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`mp3` - mp3 audio file (audio only)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`wav` - wav audio file (audio only)&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: mp4
        /// </param>
        /// <param name="size">
        /// Set a custom size for a video or image in pixels. When using a custom size omit the `resolution` and `aspectRatio`. Custom sizes must be divisible by 2 based on the encoder specifications.
        /// </param>
        /// <param name="fit">
        /// Set how the rendition should be scaled and cropped when using a size with an aspect ratio that is different from the source. Fit applies to both videos and images. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`crop` &lt;b&gt;(default)&lt;/b&gt; - scale the rendition to fill the output area while maintaining the aspect ratio. The rendition will be cropped if it exceeds the bounds of the output.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`cover` - stretch the rendition to fill the output without maintaining the aspect ratio.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`contain` - fit the entire rendition within the output while maintaining the original aspect ratio.&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: crop
        /// </param>
        /// <param name="resolution">
        /// The preset output resolution of the video or image. This is a convenience property that sets the width and height based on industry standard resolutions. The following resolutions are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`preview` - 512px x 288px&lt;/li&gt;<br/>
        ///   &lt;li&gt;`mobile` - 640px x 360px&lt;/li&gt;<br/>
        ///   &lt;li&gt;`sd` - 1024px x 576px&lt;/li&gt;<br/>
        ///   &lt;li&gt;`hd` - 1280px x 720px&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fhd` - 1920px x 1080px&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: hd
        /// </param>
        /// <param name="quality">
        /// Adjust the visual quality of the video or image. The higher the value, the sharper the image quality but the larger file size and slower the encoding process. When specifying quality, the goal is to balance file size vs visual quality.<br/>
        /// Quality is a value between 1 and 100 where 1 is fully compressed with low image quality and 100 is close to lossless with high image quality and large file size. Sane values are between 50 and 75. Omitting the quality parameter will result in an asset optimised for encoding speed, file size and visual quality.<br/>
        /// Example: 70
        /// </param>
        /// <param name="fps">
        /// Change the frame rate of a video asset. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`12` - 12fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`15` - 15fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`24` - 24fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`23.976` - 23.976fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`25` (default) - 25fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`29.97` - 29.97fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`30` - 30fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`48` - 48fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`50` - 50fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`59.94` - 59.94fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`60` - 60fps&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: 25
        /// </param>
        /// <param name="speed">
        /// Set the playback speed of a video or audio file. Allows you to preserve the pitch of the audio so that it is sped up without sounding too high pitched or too low.
        /// </param>
        /// <param name="keyframeInterval">
        /// The keyframe interval is useful to optimize playback, seeking and smoother scrubbing in browsers. The value sets the number of frames between a keyframe. The lower the number, the larger the file. Try a value between 10 and 25 for smooth scrubbing.<br/>
        /// Example: 10
        /// </param>
        /// <param name="fixOffset">
        /// Attempt to fix audio and video sync issues. This can occur when recording devices, such as smartphones and<br/>
        ///  web cams use compression techniques like [Variable Frame Rate](https://en.wikipedia.org/wiki/Variable_frame_rate)<br/>
        ///  (VFR) which can cause audio and video to go out of sync. This option will attempt to fix the sync issues.<br/>
        /// Example: true
        /// </param>
        /// <param name="fixRotation">
        /// Automatically reset the rotation of the video based on the orientation metadata in the video file. This is useful for videos recorded on smartphones that have orientation metadata that may not work correctly with certain video editing software, including the Shotstack Edit API.<br/>
        /// Example: true
        /// </param>
        /// <param name="enhance">
        /// Enhancements that can be applied to a rendition. Currently only supports the Dolby audio enhancement.
        /// </param>
        /// <param name="filename">
        /// A custom name for the generated rendition file. The file extension will be automatically added based on the format of the rendition. If no filename is provided, the rendition ID will be used.<br/>
        /// Example: my-video
        /// </param>
        public Rendition(
            global::G.RenditionFormat? format,
            global::G.Size? size,
            global::G.RenditionFit? fit,
            global::G.RenditionResolution? resolution,
            int? quality,
            double? fps,
            global::G.Speed? speed,
            int? keyframeInterval,
            bool? fixOffset,
            bool? fixRotation,
            global::G.Enhancements? enhance,
            string? filename)
        {
            this.Format = format;
            this.Size = size;
            this.Fit = fit;
            this.Resolution = resolution;
            this.Quality = quality;
            this.Fps = fps;
            this.Speed = speed;
            this.KeyframeInterval = keyframeInterval;
            this.FixOffset = fixOffset;
            this.FixRotation = fixRotation;
            this.Enhance = enhance;
            this.Filename = filename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rendition" /> class.
        /// </summary>
        public Rendition()
        {
        }
    }
}