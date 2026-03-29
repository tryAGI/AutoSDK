//HintName: G.Models.Output.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The output format, render range and type of media to generate.
    /// </summary>
    public sealed partial class Output
    {
        /// <summary>
        /// The output format and type of media file to generate. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`mp4` - mp4 video file&lt;/li&gt;<br/>
        ///   &lt;li&gt;`gif` - animated gif&lt;/li&gt;<br/>
        ///   &lt;li&gt;`jpg` - jpg image file&lt;/li&gt;<br/>
        ///   &lt;li&gt;`png` - png image file&lt;/li&gt;<br/>
        ///   &lt;li&gt;`bmp` - bmp image file&lt;/li&gt;<br/>
        ///   &lt;li&gt;`mp3` - mp3 audio file (audio only)&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: mp4
        /// </summary>
        /// <example>mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OutputFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OutputFormat Format { get; set; }

        /// <summary>
        /// The preset output resolution of the video or image. For custom sizes use the `size` property. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`preview` - 512px x 288px @ 15fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`mobile` - 640px x 360px @ 25fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`sd` - 1024px x 576px @ 25fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`hd` - 1280px x 720px @ 25fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`1080` - 1920px x 1080px @ 25fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`4k` - 3840px x 2160px @ 25fps&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: hd
        /// </summary>
        /// <example>hd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OutputResolutionJsonConverter))]
        public global::G.OutputResolution? Resolution { get; set; }

        /// <summary>
        /// The aspect ratio (shape) of the video or image. Useful for social media output formats. Options are: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`16:9` (default) - regular landscape/horizontal aspect ratio&lt;/li&gt;<br/>
        ///   &lt;li&gt;`9:16` - vertical/portrait aspect ratio&lt;/li&gt;<br/>
        ///   &lt;li&gt;`1:1` - square aspect ratio&lt;/li&gt;<br/>
        ///   &lt;li&gt;`4:5` - short vertical/portrait aspect ratio&lt;/li&gt;<br/>
        ///   &lt;li&gt;`4:3` - legacy TV aspect ratio&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: 16:9
        /// </summary>
        /// <example>16:9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspectRatio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OutputAspectRatioJsonConverter))]
        public global::G.OutputAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Set a custom size for a video or image in pixels. When using a custom size omit the `resolution` and `aspectRatio`. Custom sizes must be divisible by 2 based on the encoder specifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public global::G.Size? Size { get; set; }

        /// <summary>
        /// Override the default frames per second. Useful for when the source footage is recorded at 30fps, i.e. on  mobile devices. Lower frame rates can be used to add cinematic quality (24fps) or to create smaller file size/faster render times or animated gifs (12 or 15fps). Default is 25fps. &lt;ul&gt;<br/>
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
        [global::System.Text.Json.Serialization.JsonPropertyName("fps")]
        public double? Fps { get; set; }

        /// <summary>
        /// Override the resolution and scale the video or image to render at a different size. When using scaleTo the asset should be edited at the resolution dimensions, i.e. use font sizes that look best at HD, then use scaleTo to output the file at SD and the text will be scaled to the correct size. This is useful if you want to create multiple asset sizes. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`preview` - 512px x 288px @ 15fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`mobile` - 640px x 360px @ 25fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`sd` - 1024px x 576px @25fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`hd` - 1280px x 720px @25fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`1080` - 1920px x 1080px @25fps&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scaleTo")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OutputScaleToJsonConverter))]
        public global::G.OutputScaleTo? ScaleTo { get; set; }

        /// <summary>
        /// Adjust the output quality of the video, image or audio. Adjusting quality affects  render speed, download speeds and storage requirements due to file size. The default `medium` provides the most optimized choice for all three  factors. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`verylow` - reduced quality, smallest file size&lt;/li&gt;<br/>
        ///   &lt;li&gt;`low` - slightly reduced quality, smaller file size&lt;/li&gt;<br/>
        ///   &lt;li&gt;`medium` (default) - optimized quality, render speeds and file size&lt;/li&gt;<br/>
        ///   &lt;li&gt;`high` - slightly increased quality, larger file size&lt;/li&gt;<br/>
        ///   &lt;li&gt;`veryhigh` - highest quality, largest file size&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: medium
        /// </summary>
        /// <example>medium</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OutputQualityJsonConverter))]
        public global::G.OutputQuality? Quality { get; set; }

        /// <summary>
        /// Loop settings for gif files. Set to `true` to loop, `false` to play only once.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repeat")]
        public bool? Repeat { get; set; }

        /// <summary>
        /// Mute the audio track of the output video. Set to `true` to mute, `false` to un-mute.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mute")]
        public bool? Mute { get; set; }

        /// <summary>
        /// Specify a time range to render, i.e. to render only a portion of a video or audio file. Omit this setting to  export the entire video. Range can also be used to render a frame at a specific time point - setting a range and output format as `jpg` will output a single frame image at the range `start` point.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        public global::G.Range? Range { get; set; }

        /// <summary>
        /// Generate a poster image for the video at a specific point from the timeline. The poster image size will match the size of the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("poster")]
        public global::G.Poster? Poster { get; set; }

        /// <summary>
        /// Generate a thumbnail image for the video or image at a specific point from the timeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail")]
        public global::G.Thumbnail? Thumbnail { get; set; }

        /// <summary>
        /// Specify the storage locations and hosting services to send rendered videos to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destinations")]
        public global::System.Collections.Generic.IList<global::G.Destinations>? Destinations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Output" /> class.
        /// </summary>
        /// <param name="format">
        /// The output format and type of media file to generate. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`mp4` - mp4 video file&lt;/li&gt;<br/>
        ///   &lt;li&gt;`gif` - animated gif&lt;/li&gt;<br/>
        ///   &lt;li&gt;`jpg` - jpg image file&lt;/li&gt;<br/>
        ///   &lt;li&gt;`png` - png image file&lt;/li&gt;<br/>
        ///   &lt;li&gt;`bmp` - bmp image file&lt;/li&gt;<br/>
        ///   &lt;li&gt;`mp3` - mp3 audio file (audio only)&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: mp4
        /// </param>
        /// <param name="resolution">
        /// The preset output resolution of the video or image. For custom sizes use the `size` property. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`preview` - 512px x 288px @ 15fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`mobile` - 640px x 360px @ 25fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`sd` - 1024px x 576px @ 25fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`hd` - 1280px x 720px @ 25fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`1080` - 1920px x 1080px @ 25fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`4k` - 3840px x 2160px @ 25fps&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: hd
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio (shape) of the video or image. Useful for social media output formats. Options are: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`16:9` (default) - regular landscape/horizontal aspect ratio&lt;/li&gt;<br/>
        ///   &lt;li&gt;`9:16` - vertical/portrait aspect ratio&lt;/li&gt;<br/>
        ///   &lt;li&gt;`1:1` - square aspect ratio&lt;/li&gt;<br/>
        ///   &lt;li&gt;`4:5` - short vertical/portrait aspect ratio&lt;/li&gt;<br/>
        ///   &lt;li&gt;`4:3` - legacy TV aspect ratio&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: 16:9
        /// </param>
        /// <param name="size">
        /// Set a custom size for a video or image in pixels. When using a custom size omit the `resolution` and `aspectRatio`. Custom sizes must be divisible by 2 based on the encoder specifications.
        /// </param>
        /// <param name="fps">
        /// Override the default frames per second. Useful for when the source footage is recorded at 30fps, i.e. on  mobile devices. Lower frame rates can be used to add cinematic quality (24fps) or to create smaller file size/faster render times or animated gifs (12 or 15fps). Default is 25fps. &lt;ul&gt;<br/>
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
        /// <param name="scaleTo">
        /// Override the resolution and scale the video or image to render at a different size. When using scaleTo the asset should be edited at the resolution dimensions, i.e. use font sizes that look best at HD, then use scaleTo to output the file at SD and the text will be scaled to the correct size. This is useful if you want to create multiple asset sizes. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`preview` - 512px x 288px @ 15fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`mobile` - 640px x 360px @ 25fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`sd` - 1024px x 576px @25fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`hd` - 1280px x 720px @25fps&lt;/li&gt;<br/>
        ///   &lt;li&gt;`1080` - 1920px x 1080px @25fps&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </param>
        /// <param name="quality">
        /// Adjust the output quality of the video, image or audio. Adjusting quality affects  render speed, download speeds and storage requirements due to file size. The default `medium` provides the most optimized choice for all three  factors. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`verylow` - reduced quality, smallest file size&lt;/li&gt;<br/>
        ///   &lt;li&gt;`low` - slightly reduced quality, smaller file size&lt;/li&gt;<br/>
        ///   &lt;li&gt;`medium` (default) - optimized quality, render speeds and file size&lt;/li&gt;<br/>
        ///   &lt;li&gt;`high` - slightly increased quality, larger file size&lt;/li&gt;<br/>
        ///   &lt;li&gt;`veryhigh` - highest quality, largest file size&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: medium
        /// </param>
        /// <param name="repeat">
        /// Loop settings for gif files. Set to `true` to loop, `false` to play only once.<br/>
        /// Example: true
        /// </param>
        /// <param name="mute">
        /// Mute the audio track of the output video. Set to `true` to mute, `false` to un-mute.<br/>
        /// Example: false
        /// </param>
        /// <param name="range">
        /// Specify a time range to render, i.e. to render only a portion of a video or audio file. Omit this setting to  export the entire video. Range can also be used to render a frame at a specific time point - setting a range and output format as `jpg` will output a single frame image at the range `start` point.
        /// </param>
        /// <param name="poster">
        /// Generate a poster image for the video at a specific point from the timeline. The poster image size will match the size of the output video.
        /// </param>
        /// <param name="thumbnail">
        /// Generate a thumbnail image for the video or image at a specific point from the timeline.
        /// </param>
        /// <param name="destinations">
        /// Specify the storage locations and hosting services to send rendered videos to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Output(
            global::G.OutputFormat format,
            global::G.OutputResolution? resolution,
            global::G.OutputAspectRatio? aspectRatio,
            global::G.Size? size,
            double? fps,
            global::G.OutputScaleTo? scaleTo,
            global::G.OutputQuality? quality,
            bool? repeat,
            bool? mute,
            global::G.Range? range,
            global::G.Poster? poster,
            global::G.Thumbnail? thumbnail,
            global::System.Collections.Generic.IList<global::G.Destinations>? destinations)
        {
            this.Format = format;
            this.Resolution = resolution;
            this.AspectRatio = aspectRatio;
            this.Size = size;
            this.Fps = fps;
            this.ScaleTo = scaleTo;
            this.Quality = quality;
            this.Repeat = repeat;
            this.Mute = mute;
            this.Range = range;
            this.Poster = poster;
            this.Thumbnail = thumbnail;
            this.Destinations = destinations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Output" /> class.
        /// </summary>
        public Output()
        {
        }
    }
}