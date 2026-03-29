//HintName: G.Models.Tween.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Use a Tween to [animate properties over time](/docs/guide/architecting-an-application/animations/). The following properties are currently supported and can be animated:<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;Opacity - animate the transparency of a clip.&lt;/li&gt;<br/>
    ///     &lt;li&gt;Offset - animate the x and y position of a clip.&lt;/li&gt;<br/>
    ///     &lt;li&gt;Rotation - animate the rotation of a clip.&lt;/li&gt;<br/>
    ///     &lt;li&gt;Skew - animate the horizontal and vertical shearing effect.&lt;/li&gt;<br/>
    ///     &lt;li&gt;Volume - animate the audio volume of a clip.&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;
    /// </summary>
    public sealed partial class Tween
    {
        /// <summary>
        /// The initial property value at the start of the animation.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("from")]
        public object? From { get; set; }

        /// <summary>
        /// The final property value at the end of the animation.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("to")]
        public object? To { get; set; }

        /// <summary>
        /// The time in seconds when the animation starts, relative to the clip, not the timeline.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("start")]
        public double? Start { get; set; }

        /// <summary>
        /// The duration of the animation in seconds.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::Newtonsoft.Json.JsonProperty("length")]
        public double? Length { get; set; }

        /// <summary>
        /// The interpolation method to use for the animation. Available options are: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`linear` - a linear interpolation between the start and end values.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`bezier` - a bezier curve interpolation between the start and end values.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`constant` - an interpolation where the property instantly jumps from the start to the end value, without any gradual transition.&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: bezier
        /// </summary>
        /// <example>bezier</example>
        [global::Newtonsoft.Json.JsonProperty("interpolation")]
        public global::G.TweenInterpolation? Interpolation { get; set; }

        /// <summary>
        /// The easing function to use for the animation. Easing controls the rate of change of the animated value, allowing for more natural motion by speeding up or slowing down the animation at different points. Only applicable if interpolation is set to `bezier`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("easing")]
        public global::G.TweenEasing? Easing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Tween" /> class.
        /// </summary>
        /// <param name="from">
        /// The initial property value at the start of the animation.<br/>
        /// Example: 0
        /// </param>
        /// <param name="to">
        /// The final property value at the end of the animation.<br/>
        /// Example: 1
        /// </param>
        /// <param name="start">
        /// The time in seconds when the animation starts, relative to the clip, not the timeline.<br/>
        /// Example: 0
        /// </param>
        /// <param name="length">
        /// The duration of the animation in seconds.<br/>
        /// Example: 3
        /// </param>
        /// <param name="interpolation">
        /// The interpolation method to use for the animation. Available options are: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`linear` - a linear interpolation between the start and end values.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`bezier` - a bezier curve interpolation between the start and end values.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`constant` - an interpolation where the property instantly jumps from the start to the end value, without any gradual transition.&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: bezier
        /// </param>
        /// <param name="easing">
        /// The easing function to use for the animation. Easing controls the rate of change of the animated value, allowing for more natural motion by speeding up or slowing down the animation at different points. Only applicable if interpolation is set to `bezier`.
        /// </param>
        public Tween(
            object? from,
            object? to,
            double? start,
            double? length,
            global::G.TweenInterpolation? interpolation,
            global::G.TweenEasing? easing)
        {
            this.From = from;
            this.To = to;
            this.Start = start;
            this.Length = length;
            this.Interpolation = interpolation;
            this.Easing = easing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tween" /> class.
        /// </summary>
        public Tween()
        {
        }
    }
}