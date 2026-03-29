//HintName: G.Models.Asset.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset to display for the duration of the Clip, i.e. a video clip or an image. Choose from one of the available asset types below.
    /// </summary>
    public readonly partial struct Asset : global::System.IEquatable<Asset>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.AssetDiscriminatorType? Type { get; }

        /// <summary>
        /// The VideoAsset is used to create video sequences from video files. The src must be a publicly accessible URL to a video resource such as an mp4 file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VideoAsset? Video { get; init; }
#else
        public global::G.VideoAsset? Video { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Video))]
#endif
        public bool IsVideo => Video != null;

        /// <summary>
        /// The ImageAsset is used to create video from images to compose an image. The src must be a publicly accessible URL to an image resource such as a jpg or png file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImageAsset? Image { get; init; }
#else
        public global::G.ImageAsset? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// The TextAsset is used to add text and titles to a video. The text can be styled with built in and custom<br/>
        /// [Fonts](#tocs_font). You can also add a background bounding box used to control wrapping and overflow. Emoticons are also supported.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextAsset? Text { get; init; }
#else
        public global::G.TextAsset? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// The RichTextAsset provides advanced text rendering with support for custom fonts, gradients, shadows, strokes,<br/>
        /// animations, and styling options. It offers more flexibility and visual effects than the basic TextAsset.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RichTextAsset? RichText { get; init; }
#else
        public global::G.RichTextAsset? RichText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RichText))]
#endif
        public bool IsRichText => RichText != null;

        /// <summary>
        /// The AudioAsset is used to add sound effects and audio at specific intervals on the timeline. The src must be a publicly accessible URL to an audio resource such  as an mp3 file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AudioAsset? Audio { get; init; }
#else
        public global::G.AudioAsset? Audio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Audio))]
#endif
        public bool IsAudio => Audio != null;

        /// <summary>
        /// The LumaAsset is used to create luma matte masks, transitions and effects between other assets. A luma matte is a grey scale image or animated video where the black areas are transparent and the white areas solid. The luma matte animation should be provided as an mp4 video file. The src must be a publicly accessible URL to the file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LumaAsset? Luma { get; init; }
#else
        public global::G.LumaAsset? Luma { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Luma))]
#endif
        public bool IsLuma => Luma != null;

        /// <summary>
        /// The CaptionAsset is used to add captions (subtitles) to a video. It uses a supplied SRT or VTT file which will<br/>
        /// be read and burnt to the video.<br/>
        /// Captions can be applied independently from a video or audio file for greater<br/>
        /// flexibility with styling and layout. For example you can scale, position or crop a video without modifying the<br/>
        /// captions.<br/>
        /// To sync captions with a video or audio file use a [Video](#tocs_videoasset") or [Audio](#tocs_audioasset") with<br/>
        /// matching start and end time.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CaptionAsset? Caption { get; init; }
#else
        public global::G.CaptionAsset? Caption { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Caption))]
#endif
        public bool IsCaption => Caption != null;

        /// <summary>
        /// The RichCaptionAsset provides word-level caption animations with rich-text styling. It supports<br/>
        /// karaoke-style highlighting, word-by-word animations, and advanced typography. Use with SRT/VTT<br/>
        /// files or auto-transcription via aliases.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RichCaptionAsset? RichCaption { get; init; }
#else
        public global::G.RichCaptionAsset? RichCaption { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RichCaption))]
#endif
        public bool IsRichCaption => RichCaption != null;

        /// <summary>
        /// **Notice: The HtmlAsset is deprecated, use the [TextAsset](#tocs_textasset) instead.**<br/>
        /// The HtmlAsset clip type lets you create text based layout and formatting using<br/>
        /// HTML and CSS. You can also set the height and width of a bounding box for the HTML<br/>
        /// content to sit within. Text and elements will wrap within the bounding box.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.HtmlAsset? Html { get; init; }
#else
        public global::G.HtmlAsset? Html { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Html))]
#endif
        public bool IsHtml => Html != null;

        /// <summary>
        /// **Notice: The TitleAsset is deprecated, use the [TextAsset](#tocs_textasset) instead.**<br/>
        /// The TitleAsset clip type lets you create video titles from a text string and apply styling and positioning.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TitleAsset? Title { get; init; }
#else
        public global::G.TitleAsset? Title { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Title))]
#endif
        public bool IsTitle => Title != null;

        /// <summary>
        /// The ShapeAsset is used to add shapes to a video. The shape can be styled with a fill and a stroke.<br/>
        /// You can manipulate properties such as rotation to create dynamic effects like a diamond shape or stripes.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ShapeAsset? Shape { get; init; }
#else
        public global::G.ShapeAsset? Shape { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shape))]
#endif
        public bool IsShape => Shape != null;

        /// <summary>
        /// The SvgAsset is used to add scalable vector graphics (SVG) shapes to a video.<br/>
        /// It provides two mutually exclusive ways to define shapes:<br/>
        /// **Option 1: Import SVG markup using `src`**<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "svg",<br/>
        ///   "src": "&lt;svg width=\"100\" height=\"100\"&gt;&lt;circle cx=\"50\" cy=\"50\" r=\"40\" fill=\"#FF0000\"/&gt;&lt;/svg&gt;"<br/>
        /// }<br/>
        /// ```<br/>
        /// When using `src`, no other properties are allowed. The fill, stroke, and dimensions<br/>
        /// are automatically extracted from the SVG markup.<br/>
        /// **Option 2: Define shapes programmatically using `shape`**<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "svg",<br/>
        ///   "shape": { "type": "circle", "radius": 50 },<br/>
        ///   "fill": { "type": "solid", "color": "#FF0000" }<br/>
        /// }<br/>
        /// ```<br/>
        /// When using `shape`, you can customize fill, stroke, shadow, transform, and other properties.<br/>
        /// The `src` property is not allowed in this mode.<br/>
        /// **Important:** You must provide either `src` OR `shape`, but not both.<br/>
        /// These two modes are mutually exclusive.<br/>
        /// **Available Shapes (Option 2 only):**<br/>
        /// - `rectangle` - Rectangles with optional rounded corners<br/>
        /// - `circle` - Perfect circles<br/>
        /// - `ellipse` - Ellipses/ovals with separate x and y radii<br/>
        /// - `line` - Straight lines with configurable thickness<br/>
        /// - `polygon` - Regular polygons (triangle, pentagon, hexagon, etc.)<br/>
        /// - `star` - Multi-pointed stars<br/>
        /// - `arrow` - Directional arrows<br/>
        /// - `heart` - Heart shapes<br/>
        /// - `cross` - Plus/cross shapes<br/>
        /// - `ring` - Donut/ring shapes<br/>
        /// - `path` - Custom shapes using SVG path data<br/>
        /// See [W3C SVG 2 Specification](https://www.w3.org/TR/SVG2/) for path data syntax.<br/>
        /// Example: {"type":"svg","shape":{"type":"star","points":5,"outerRadius":100,"innerRadius":50},"fill":{"type":"linear","angle":45,"stops":[{"offset":0,"color":"#FFD700"},{"offset":1,"color":"#FF6B6B"}],"opacity":1},"stroke":{"color":"#2C3E50","width":3,"opacity":1,"lineCap":"round","lineJoin":"round"},"transform":{"x":200,"y":150,"rotation":0,"scale":1},"opacity":1}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SvgAsset? Svg { get; init; }
#else
        public global::G.SvgAsset? Svg { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Svg))]
#endif
        public bool IsSvg => Svg != null;

        /// <summary>
        /// The TextToImageAsset lets you create a dynamic image from a text prompt.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextToImageAsset? TextToImage { get; init; }
#else
        public global::G.TextToImageAsset? TextToImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToImage))]
#endif
        public bool IsTextToImage => TextToImage != null;

        /// <summary>
        /// The ImageToVideoAsset lets you create a video from an image and a text prompt.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImageToVideoAsset? ImageToVideo { get; init; }
#else
        public global::G.ImageToVideoAsset? ImageToVideo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageToVideo))]
#endif
        public bool IsImageToVideo => ImageToVideo != null;

        /// <summary>
        /// The TextToSpeechAsset lets you generate a voice over from text using a text-to-speech service. The generated audio can be trimmed, faded and have its volume and speed adjusted using the same properties available on the AudioAsset.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextToSpeechAsset? TextToSpeech { get; init; }
#else
        public global::G.TextToSpeechAsset? TextToSpeech { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToSpeech))]
#endif
        public bool IsTextToSpeech => TextToSpeech != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::G.VideoAsset value) => new Asset((global::G.VideoAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VideoAsset?(Asset @this) => @this.Video;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::G.VideoAsset? value)
        {
            Video = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::G.ImageAsset value) => new Asset((global::G.ImageAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageAsset?(Asset @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::G.ImageAsset? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::G.TextAsset value) => new Asset((global::G.TextAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextAsset?(Asset @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::G.TextAsset? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::G.RichTextAsset value) => new Asset((global::G.RichTextAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RichTextAsset?(Asset @this) => @this.RichText;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::G.RichTextAsset? value)
        {
            RichText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::G.AudioAsset value) => new Asset((global::G.AudioAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AudioAsset?(Asset @this) => @this.Audio;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::G.AudioAsset? value)
        {
            Audio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::G.LumaAsset value) => new Asset((global::G.LumaAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LumaAsset?(Asset @this) => @this.Luma;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::G.LumaAsset? value)
        {
            Luma = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::G.CaptionAsset value) => new Asset((global::G.CaptionAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CaptionAsset?(Asset @this) => @this.Caption;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::G.CaptionAsset? value)
        {
            Caption = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::G.RichCaptionAsset value) => new Asset((global::G.RichCaptionAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RichCaptionAsset?(Asset @this) => @this.RichCaption;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::G.RichCaptionAsset? value)
        {
            RichCaption = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::G.HtmlAsset value) => new Asset((global::G.HtmlAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.HtmlAsset?(Asset @this) => @this.Html;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::G.HtmlAsset? value)
        {
            Html = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::G.TitleAsset value) => new Asset((global::G.TitleAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TitleAsset?(Asset @this) => @this.Title;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::G.TitleAsset? value)
        {
            Title = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::G.ShapeAsset value) => new Asset((global::G.ShapeAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ShapeAsset?(Asset @this) => @this.Shape;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::G.ShapeAsset? value)
        {
            Shape = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::G.SvgAsset value) => new Asset((global::G.SvgAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SvgAsset?(Asset @this) => @this.Svg;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::G.SvgAsset? value)
        {
            Svg = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::G.TextToImageAsset value) => new Asset((global::G.TextToImageAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextToImageAsset?(Asset @this) => @this.TextToImage;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::G.TextToImageAsset? value)
        {
            TextToImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::G.ImageToVideoAsset value) => new Asset((global::G.ImageToVideoAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageToVideoAsset?(Asset @this) => @this.ImageToVideo;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::G.ImageToVideoAsset? value)
        {
            ImageToVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset(global::G.TextToSpeechAsset value) => new Asset((global::G.TextToSpeechAsset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextToSpeechAsset?(Asset @this) => @this.TextToSpeech;

        /// <summary>
        /// 
        /// </summary>
        public Asset(global::G.TextToSpeechAsset? value)
        {
            TextToSpeech = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Asset(
            global::G.AssetDiscriminatorType? type,
            global::G.VideoAsset? video,
            global::G.ImageAsset? image,
            global::G.TextAsset? text,
            global::G.RichTextAsset? richText,
            global::G.AudioAsset? audio,
            global::G.LumaAsset? luma,
            global::G.CaptionAsset? caption,
            global::G.RichCaptionAsset? richCaption,
            global::G.HtmlAsset? html,
            global::G.TitleAsset? title,
            global::G.ShapeAsset? shape,
            global::G.SvgAsset? svg,
            global::G.TextToImageAsset? textToImage,
            global::G.ImageToVideoAsset? imageToVideo,
            global::G.TextToSpeechAsset? textToSpeech
            )
        {
            Type = type;

            Video = video;
            Image = image;
            Text = text;
            RichText = richText;
            Audio = audio;
            Luma = luma;
            Caption = caption;
            RichCaption = richCaption;
            Html = html;
            Title = title;
            Shape = shape;
            Svg = svg;
            TextToImage = textToImage;
            ImageToVideo = imageToVideo;
            TextToSpeech = textToSpeech;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TextToSpeech as object ??
            ImageToVideo as object ??
            TextToImage as object ??
            Svg as object ??
            Shape as object ??
            Title as object ??
            Html as object ??
            RichCaption as object ??
            Caption as object ??
            Luma as object ??
            Audio as object ??
            RichText as object ??
            Text as object ??
            Image as object ??
            Video as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Video?.ToString() ??
            Image?.ToString() ??
            Text?.ToString() ??
            RichText?.ToString() ??
            Audio?.ToString() ??
            Luma?.ToString() ??
            Caption?.ToString() ??
            RichCaption?.ToString() ??
            Html?.ToString() ??
            Title?.ToString() ??
            Shape?.ToString() ??
            Svg?.ToString() ??
            TextToImage?.ToString() ??
            ImageToVideo?.ToString() ??
            TextToSpeech?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVideo && !IsImage && !IsText && !IsRichText && !IsAudio && !IsLuma && !IsCaption && !IsRichCaption && !IsHtml && !IsTitle && !IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && IsImage && !IsText && !IsRichText && !IsAudio && !IsLuma && !IsCaption && !IsRichCaption && !IsHtml && !IsTitle && !IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && IsText && !IsRichText && !IsAudio && !IsLuma && !IsCaption && !IsRichCaption && !IsHtml && !IsTitle && !IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && IsRichText && !IsAudio && !IsLuma && !IsCaption && !IsRichCaption && !IsHtml && !IsTitle && !IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && !IsRichText && IsAudio && !IsLuma && !IsCaption && !IsRichCaption && !IsHtml && !IsTitle && !IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && !IsRichText && !IsAudio && IsLuma && !IsCaption && !IsRichCaption && !IsHtml && !IsTitle && !IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && !IsRichText && !IsAudio && !IsLuma && IsCaption && !IsRichCaption && !IsHtml && !IsTitle && !IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && !IsRichText && !IsAudio && !IsLuma && !IsCaption && IsRichCaption && !IsHtml && !IsTitle && !IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && !IsRichText && !IsAudio && !IsLuma && !IsCaption && !IsRichCaption && IsHtml && !IsTitle && !IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && !IsRichText && !IsAudio && !IsLuma && !IsCaption && !IsRichCaption && !IsHtml && IsTitle && !IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && !IsRichText && !IsAudio && !IsLuma && !IsCaption && !IsRichCaption && !IsHtml && !IsTitle && IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && !IsRichText && !IsAudio && !IsLuma && !IsCaption && !IsRichCaption && !IsHtml && !IsTitle && !IsShape && IsSvg && !IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && !IsRichText && !IsAudio && !IsLuma && !IsCaption && !IsRichCaption && !IsHtml && !IsTitle && !IsShape && !IsSvg && IsTextToImage && !IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && !IsRichText && !IsAudio && !IsLuma && !IsCaption && !IsRichCaption && !IsHtml && !IsTitle && !IsShape && !IsSvg && !IsTextToImage && IsImageToVideo && !IsTextToSpeech || !IsVideo && !IsImage && !IsText && !IsRichText && !IsAudio && !IsLuma && !IsCaption && !IsRichCaption && !IsHtml && !IsTitle && !IsShape && !IsSvg && !IsTextToImage && !IsImageToVideo && IsTextToSpeech;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.VideoAsset?, TResult>? video = null,
            global::System.Func<global::G.ImageAsset?, TResult>? image = null,
            global::System.Func<global::G.TextAsset?, TResult>? text = null,
            global::System.Func<global::G.RichTextAsset?, TResult>? richText = null,
            global::System.Func<global::G.AudioAsset?, TResult>? audio = null,
            global::System.Func<global::G.LumaAsset?, TResult>? luma = null,
            global::System.Func<global::G.CaptionAsset?, TResult>? caption = null,
            global::System.Func<global::G.RichCaptionAsset?, TResult>? richCaption = null,
            global::System.Func<global::G.HtmlAsset?, TResult>? html = null,
            global::System.Func<global::G.TitleAsset?, TResult>? title = null,
            global::System.Func<global::G.ShapeAsset?, TResult>? shape = null,
            global::System.Func<global::G.SvgAsset?, TResult>? svg = null,
            global::System.Func<global::G.TextToImageAsset?, TResult>? textToImage = null,
            global::System.Func<global::G.ImageToVideoAsset?, TResult>? imageToVideo = null,
            global::System.Func<global::G.TextToSpeechAsset?, TResult>? textToSpeech = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideo && video != null)
            {
                return video(Video!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsRichText && richText != null)
            {
                return richText(RichText!);
            }
            else if (IsAudio && audio != null)
            {
                return audio(Audio!);
            }
            else if (IsLuma && luma != null)
            {
                return luma(Luma!);
            }
            else if (IsCaption && caption != null)
            {
                return caption(Caption!);
            }
            else if (IsRichCaption && richCaption != null)
            {
                return richCaption(RichCaption!);
            }
            else if (IsHtml && html != null)
            {
                return html(Html!);
            }
            else if (IsTitle && title != null)
            {
                return title(Title!);
            }
            else if (IsShape && shape != null)
            {
                return shape(Shape!);
            }
            else if (IsSvg && svg != null)
            {
                return svg(Svg!);
            }
            else if (IsTextToImage && textToImage != null)
            {
                return textToImage(TextToImage!);
            }
            else if (IsImageToVideo && imageToVideo != null)
            {
                return imageToVideo(ImageToVideo!);
            }
            else if (IsTextToSpeech && textToSpeech != null)
            {
                return textToSpeech(TextToSpeech!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.VideoAsset?>? video = null,
            global::System.Action<global::G.ImageAsset?>? image = null,
            global::System.Action<global::G.TextAsset?>? text = null,
            global::System.Action<global::G.RichTextAsset?>? richText = null,
            global::System.Action<global::G.AudioAsset?>? audio = null,
            global::System.Action<global::G.LumaAsset?>? luma = null,
            global::System.Action<global::G.CaptionAsset?>? caption = null,
            global::System.Action<global::G.RichCaptionAsset?>? richCaption = null,
            global::System.Action<global::G.HtmlAsset?>? html = null,
            global::System.Action<global::G.TitleAsset?>? title = null,
            global::System.Action<global::G.ShapeAsset?>? shape = null,
            global::System.Action<global::G.SvgAsset?>? svg = null,
            global::System.Action<global::G.TextToImageAsset?>? textToImage = null,
            global::System.Action<global::G.ImageToVideoAsset?>? imageToVideo = null,
            global::System.Action<global::G.TextToSpeechAsset?>? textToSpeech = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideo)
            {
                video?.Invoke(Video!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsRichText)
            {
                richText?.Invoke(RichText!);
            }
            else if (IsAudio)
            {
                audio?.Invoke(Audio!);
            }
            else if (IsLuma)
            {
                luma?.Invoke(Luma!);
            }
            else if (IsCaption)
            {
                caption?.Invoke(Caption!);
            }
            else if (IsRichCaption)
            {
                richCaption?.Invoke(RichCaption!);
            }
            else if (IsHtml)
            {
                html?.Invoke(Html!);
            }
            else if (IsTitle)
            {
                title?.Invoke(Title!);
            }
            else if (IsShape)
            {
                shape?.Invoke(Shape!);
            }
            else if (IsSvg)
            {
                svg?.Invoke(Svg!);
            }
            else if (IsTextToImage)
            {
                textToImage?.Invoke(TextToImage!);
            }
            else if (IsImageToVideo)
            {
                imageToVideo?.Invoke(ImageToVideo!);
            }
            else if (IsTextToSpeech)
            {
                textToSpeech?.Invoke(TextToSpeech!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Video,
                typeof(global::G.VideoAsset),
                Image,
                typeof(global::G.ImageAsset),
                Text,
                typeof(global::G.TextAsset),
                RichText,
                typeof(global::G.RichTextAsset),
                Audio,
                typeof(global::G.AudioAsset),
                Luma,
                typeof(global::G.LumaAsset),
                Caption,
                typeof(global::G.CaptionAsset),
                RichCaption,
                typeof(global::G.RichCaptionAsset),
                Html,
                typeof(global::G.HtmlAsset),
                Title,
                typeof(global::G.TitleAsset),
                Shape,
                typeof(global::G.ShapeAsset),
                Svg,
                typeof(global::G.SvgAsset),
                TextToImage,
                typeof(global::G.TextToImageAsset),
                ImageToVideo,
                typeof(global::G.ImageToVideoAsset),
                TextToSpeech,
                typeof(global::G.TextToSpeechAsset),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Asset other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.VideoAsset?>.Default.Equals(Video, other.Video) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageAsset?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TextAsset?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RichTextAsset?>.Default.Equals(RichText, other.RichText) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AudioAsset?>.Default.Equals(Audio, other.Audio) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LumaAsset?>.Default.Equals(Luma, other.Luma) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CaptionAsset?>.Default.Equals(Caption, other.Caption) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RichCaptionAsset?>.Default.Equals(RichCaption, other.RichCaption) &&
                global::System.Collections.Generic.EqualityComparer<global::G.HtmlAsset?>.Default.Equals(Html, other.Html) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TitleAsset?>.Default.Equals(Title, other.Title) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ShapeAsset?>.Default.Equals(Shape, other.Shape) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SvgAsset?>.Default.Equals(Svg, other.Svg) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TextToImageAsset?>.Default.Equals(TextToImage, other.TextToImage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageToVideoAsset?>.Default.Equals(ImageToVideo, other.ImageToVideo) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TextToSpeechAsset?>.Default.Equals(TextToSpeech, other.TextToSpeech) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Asset obj1, Asset obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Asset>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Asset obj1, Asset obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Asset o && Equals(o);
        }
    }
}
