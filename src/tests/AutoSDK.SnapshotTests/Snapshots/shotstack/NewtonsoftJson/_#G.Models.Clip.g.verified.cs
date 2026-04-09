//HintName: G.Models.Clip.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A clip is a container for a specific type of asset, i.e. a title, image, video, audio or html. You use a Clip to define when an asset will display on the timeline, how long it will play for and transitions, filters and effects to apply to it.
    /// </summary>
    public sealed partial class Clip
    {
        /// <summary>
        /// The type of asset to display for the duration of the Clip, i.e. a video clip or an image. Choose from one of the available asset types below.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("asset", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Asset Asset { get; set; } = default!;

        /// <summary>
        /// The start position of the Clip on the timeline.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<double?, string> Start { get; set; } = default!;

        /// <summary>
        /// The duration the Clip should play for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("length", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<double?, string> Length { get; set; } = default!;

        /// <summary>
        /// Set how the asset should be scaled to fit the viewport using one of the following options: <br/>
        ///   &lt;ul&gt;<br/>
        ///     &lt;li&gt;`crop` &lt;b&gt;(default)&lt;/b&gt; - scale the asset to fill the viewport while maintaining the aspect ratio. The asset will be cropped if it exceeds the bounds of the viewport.&lt;/li&gt;<br/>
        ///     &lt;li&gt;`cover` - stretch the asset to fill the viewport without maintaining the aspect ratio.&lt;/li&gt;<br/>
        ///     &lt;li&gt;`contain` - fit the entire asset within the viewport while maintaining the original aspect ratio.&lt;/li&gt;<br/>
        ///     &lt;li&gt;`none` - preserves the original asset dimensions and does not apply any scaling.&lt;/li&gt;<br/>
        ///   &lt;/ul&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fit")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ClipFitJsonConverter))]
        public global::G.ClipFit? Fit { get; set; }

        /// <summary>
        /// Scale the asset to a fraction of the viewport size - i.e. setting the scale to 0.5 will scale asset to half the size of the viewport. This is useful for picture-in-picture video and scaling images such as logos and watermarks. Use a number or an array of [Tween](./#tocs_tween) objects to create a custom animation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scale")]
        public global::G.OneOf<float?, global::System.Collections.Generic.IList<global::G.Tween>>? Scale { get; set; }

        /// <summary>
        /// Set the width of the clip bounding box in pixels. This constrains the width of the clip, overriding the default behavior where clips fill the viewport width.<br/>
        /// Example: 800
        /// </summary>
        /// <example>800</example>
        [global::Newtonsoft.Json.JsonProperty("width")]
        public float? Width { get; set; }

        /// <summary>
        /// Set the height of the clip bounding box in pixels. This constrains the height of the clip, overriding the default behavior where clips fill the viewport height.<br/>
        /// Example: 600
        /// </summary>
        /// <example>600</example>
        [global::Newtonsoft.Json.JsonProperty("height")]
        public float? Height { get; set; }

        /// <summary>
        /// Place the asset in one of nine predefined positions of the viewport. This is most effective for when the asset is scaled and you want to position the element to a specific position. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`top` - top (center)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`topRight` - top right&lt;/li&gt;<br/>
        ///   &lt;li&gt;`right` - right (center)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`bottomRight` - bottom right&lt;/li&gt;<br/>
        ///   &lt;li&gt;`bottom` - bottom (center)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`bottomLeft` - bottom left&lt;/li&gt;<br/>
        ///   &lt;li&gt;`left` - left (center)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`topLeft` - top left&lt;/li&gt;<br/>
        ///   &lt;li&gt;`center` - center&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ClipPositionJsonConverter))]
        public global::G.ClipPosition? Position { get; set; }

        /// <summary>
        /// Offsets the position of an asset horizontally or vertically by a relative distance.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offset")]
        public global::G.Offset? Offset { get; set; }

        /// <summary>
        /// In and out transitions for a clip - i.e. fade in and fade out
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transition")]
        public global::G.Transition? Transition { get; set; }

        /// <summary>
        /// A motion effect to apply to the Clip. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`zoomIn` - slow zoom in&lt;/li&gt;<br/>
        ///   &lt;li&gt;`zoomOut` - slow zoom out&lt;/li&gt;<br/>
        ///   &lt;li&gt;`slideLeft` - slow slide (pan) left&lt;/li&gt;<br/>
        ///   &lt;li&gt;`slideRight` - slow slide (pan) right&lt;/li&gt;<br/>
        ///   &lt;li&gt;`slideUp` - slow slide (pan) up&lt;/li&gt;<br/>
        ///   &lt;li&gt;`slideDown` - slow slide (pan) down&lt;/li&gt;<br/>
        /// &lt;/ul&gt; The motion effect speed can also be controlled by appending `Fast` or `Slow` to the effect, e.g. `zoomInFast` or `slideRightSlow`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("effect")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ClipEffectJsonConverter))]
        public global::G.ClipEffect? Effect { get; set; }

        /// <summary>
        /// A filter effect to apply to the Clip. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`none` - no filter applied&lt;/li&gt;<br/>
        ///   &lt;li&gt;`blur` - blur the scene&lt;/li&gt;<br/>
        ///   &lt;li&gt;`boost` - boost contrast and saturation&lt;/li&gt;<br/>
        ///   &lt;li&gt;`contrast` - increase contrast&lt;/li&gt;<br/>
        ///   &lt;li&gt;`darken` - darken the scene&lt;/li&gt;<br/>
        ///   &lt;li&gt;`greyscale` - remove colour&lt;/li&gt;<br/>
        ///   &lt;li&gt;`lighten` - lighten the scene&lt;/li&gt;<br/>
        ///   &lt;li&gt;`muted` - reduce saturation and contrast&lt;/li&gt;<br/>
        ///   &lt;li&gt;`negative` - negative colors&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: greyscale
        /// </summary>
        /// <example>greyscale</example>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ClipFilterJsonConverter))]
        public global::G.ClipFilter? Filter { get; set; }

        /// <summary>
        /// Offset an asset on the horizontal axis (left or right). Use a number or an array of [Tween](./#tocs_tween) objects to create a custom animation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("opacity")]
        public global::G.OneOf<double?, global::System.Collections.Generic.IList<global::G.Tween>>? Opacity { get; set; }

        /// <summary>
        /// Apply one or more transformations to a clip. Transformations alter the visual properties of a clip and can be combined to create new shapes and effects.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transform")]
        public global::G.Transformation? Transform { get; set; }

        /// <summary>
        /// A unique identifier for this clip that can be used to reference it from other clips using the `alias://` protocol in asset sources. This is useful for features like auto-captioning where a caption asset needs to reference the audio from another clip.<br/>
        /// Example: MY_VIDEO_CLIP
        /// </summary>
        /// <example>MY_VIDEO_CLIP</example>
        [global::Newtonsoft.Json.JsonProperty("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Clip" /> class.
        /// </summary>
        /// <param name="asset">
        /// The type of asset to display for the duration of the Clip, i.e. a video clip or an image. Choose from one of the available asset types below.
        /// </param>
        /// <param name="start">
        /// The start position of the Clip on the timeline.
        /// </param>
        /// <param name="length">
        /// The duration the Clip should play for.
        /// </param>
        /// <param name="fit">
        /// Set how the asset should be scaled to fit the viewport using one of the following options: <br/>
        ///   &lt;ul&gt;<br/>
        ///     &lt;li&gt;`crop` &lt;b&gt;(default)&lt;/b&gt; - scale the asset to fill the viewport while maintaining the aspect ratio. The asset will be cropped if it exceeds the bounds of the viewport.&lt;/li&gt;<br/>
        ///     &lt;li&gt;`cover` - stretch the asset to fill the viewport without maintaining the aspect ratio.&lt;/li&gt;<br/>
        ///     &lt;li&gt;`contain` - fit the entire asset within the viewport while maintaining the original aspect ratio.&lt;/li&gt;<br/>
        ///     &lt;li&gt;`none` - preserves the original asset dimensions and does not apply any scaling.&lt;/li&gt;<br/>
        ///   &lt;/ul&gt;
        /// </param>
        /// <param name="scale">
        /// Scale the asset to a fraction of the viewport size - i.e. setting the scale to 0.5 will scale asset to half the size of the viewport. This is useful for picture-in-picture video and scaling images such as logos and watermarks. Use a number or an array of [Tween](./#tocs_tween) objects to create a custom animation.
        /// </param>
        /// <param name="width">
        /// Set the width of the clip bounding box in pixels. This constrains the width of the clip, overriding the default behavior where clips fill the viewport width.<br/>
        /// Example: 800
        /// </param>
        /// <param name="height">
        /// Set the height of the clip bounding box in pixels. This constrains the height of the clip, overriding the default behavior where clips fill the viewport height.<br/>
        /// Example: 600
        /// </param>
        /// <param name="position">
        /// Place the asset in one of nine predefined positions of the viewport. This is most effective for when the asset is scaled and you want to position the element to a specific position. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`top` - top (center)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`topRight` - top right&lt;/li&gt;<br/>
        ///   &lt;li&gt;`right` - right (center)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`bottomRight` - bottom right&lt;/li&gt;<br/>
        ///   &lt;li&gt;`bottom` - bottom (center)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`bottomLeft` - bottom left&lt;/li&gt;<br/>
        ///   &lt;li&gt;`left` - left (center)&lt;/li&gt;<br/>
        ///   &lt;li&gt;`topLeft` - top left&lt;/li&gt;<br/>
        ///   &lt;li&gt;`center` - center&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </param>
        /// <param name="offset">
        /// Offsets the position of an asset horizontally or vertically by a relative distance.
        /// </param>
        /// <param name="transition">
        /// In and out transitions for a clip - i.e. fade in and fade out
        /// </param>
        /// <param name="effect">
        /// A motion effect to apply to the Clip. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`zoomIn` - slow zoom in&lt;/li&gt;<br/>
        ///   &lt;li&gt;`zoomOut` - slow zoom out&lt;/li&gt;<br/>
        ///   &lt;li&gt;`slideLeft` - slow slide (pan) left&lt;/li&gt;<br/>
        ///   &lt;li&gt;`slideRight` - slow slide (pan) right&lt;/li&gt;<br/>
        ///   &lt;li&gt;`slideUp` - slow slide (pan) up&lt;/li&gt;<br/>
        ///   &lt;li&gt;`slideDown` - slow slide (pan) down&lt;/li&gt;<br/>
        /// &lt;/ul&gt; The motion effect speed can also be controlled by appending `Fast` or `Slow` to the effect, e.g. `zoomInFast` or `slideRightSlow`.
        /// </param>
        /// <param name="filter">
        /// A filter effect to apply to the Clip. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`none` - no filter applied&lt;/li&gt;<br/>
        ///   &lt;li&gt;`blur` - blur the scene&lt;/li&gt;<br/>
        ///   &lt;li&gt;`boost` - boost contrast and saturation&lt;/li&gt;<br/>
        ///   &lt;li&gt;`contrast` - increase contrast&lt;/li&gt;<br/>
        ///   &lt;li&gt;`darken` - darken the scene&lt;/li&gt;<br/>
        ///   &lt;li&gt;`greyscale` - remove colour&lt;/li&gt;<br/>
        ///   &lt;li&gt;`lighten` - lighten the scene&lt;/li&gt;<br/>
        ///   &lt;li&gt;`muted` - reduce saturation and contrast&lt;/li&gt;<br/>
        ///   &lt;li&gt;`negative` - negative colors&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: greyscale
        /// </param>
        /// <param name="opacity">
        /// Offset an asset on the horizontal axis (left or right). Use a number or an array of [Tween](./#tocs_tween) objects to create a custom animation.
        /// </param>
        /// <param name="transform">
        /// Apply one or more transformations to a clip. Transformations alter the visual properties of a clip and can be combined to create new shapes and effects.
        /// </param>
        /// <param name="alias">
        /// A unique identifier for this clip that can be used to reference it from other clips using the `alias://` protocol in asset sources. This is useful for features like auto-captioning where a caption asset needs to reference the audio from another clip.<br/>
        /// Example: MY_VIDEO_CLIP
        /// </param>
        public Clip(
            global::G.Asset asset,
            global::G.OneOf<double?, string> start,
            global::G.OneOf<double?, string> length,
            global::G.ClipFit? fit,
            global::G.OneOf<float?, global::System.Collections.Generic.IList<global::G.Tween>>? scale,
            float? width,
            float? height,
            global::G.ClipPosition? position,
            global::G.Offset? offset,
            global::G.Transition? transition,
            global::G.ClipEffect? effect,
            global::G.ClipFilter? filter,
            global::G.OneOf<double?, global::System.Collections.Generic.IList<global::G.Tween>>? opacity,
            global::G.Transformation? transform,
            string? alias)
        {
            this.Asset = asset;
            this.Start = start;
            this.Length = length;
            this.Fit = fit;
            this.Scale = scale;
            this.Width = width;
            this.Height = height;
            this.Position = position;
            this.Offset = offset;
            this.Transition = transition;
            this.Effect = effect;
            this.Filter = filter;
            this.Opacity = opacity;
            this.Transform = transform;
            this.Alias = alias;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Clip" /> class.
        /// </summary>
        public Clip()
        {
        }
    }
}