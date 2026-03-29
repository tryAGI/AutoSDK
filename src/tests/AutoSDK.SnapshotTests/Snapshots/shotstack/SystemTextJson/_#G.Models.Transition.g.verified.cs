//HintName: G.Models.Transition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// In and out transitions for a clip - i.e. fade in and fade out
    /// </summary>
    public sealed partial class Transition
    {
        /// <summary>
        /// The transition in. Available transitions are:<br/>
        ///   &lt;ul&gt;<br/>
        ///     &lt;li&gt;`fade` - fade in&lt;/li&gt;<br/>
        ///     &lt;li&gt;`reveal` - reveal from left to right&lt;/li&gt;<br/>
        ///     &lt;li&gt;`wipeLeft` - fade across screen to the left&lt;/li&gt;<br/>
        ///     &lt;li&gt;`wipeRight` - fade across screen to the right&lt;/li&gt;<br/>
        ///     &lt;li&gt;`slideLeft` - move slightly left and fade in&lt;/li&gt;<br/>
        ///     &lt;li&gt;`slideRight` - move slightly right and fade in&lt;/li&gt;<br/>
        ///     &lt;li&gt;`slideUp` - move slightly up and fade in&lt;/li&gt;<br/>
        ///     &lt;li&gt;`slideDown` - move slightly down and fade in&lt;/li&gt;<br/>
        ///     &lt;li&gt;`carouselLeft` - slide in from right to left&lt;/li&gt;<br/>
        ///     &lt;li&gt;`carouselRight` - slide in from left to right&lt;/li&gt;<br/>
        ///     &lt;li&gt;`carouselUp` - slide in from bottom to top&lt;/li&gt;<br/>
        ///     &lt;li&gt;`carouselDown` - slide in from top to bottom&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleTopRight` - rotate in from top right&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleRightTop` - rotate in from right top&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleRightBottom` - rotate in from right bottom&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleBottomRight` - rotate in from bottom right&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleBottomLeft` - rotate in from bottom left&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleLeftBottom` - rotate in from left bottom&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleLeftTop` - rotate in from left top&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleTopLeft` - rotate in from top left&lt;/li&gt;<br/>
        ///     &lt;li&gt;`zoom` - fast zoom in&lt;/li&gt;<br/>
        ///   &lt;/ul&gt;<br/>
        /// The transition speed can also be controlled by appending `Fast` or `Slow` to the transition, e.g. `fadeFast` or `CarouselLeftSlow`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransitionInJsonConverter))]
        public global::G.TransitionIn? In { get; set; }

        /// <summary>
        /// The transition out. Available transitions are:<br/>
        ///   &lt;ul&gt;<br/>
        ///     &lt;li&gt;`fade` - fade out&lt;/li&gt;<br/>
        ///     &lt;li&gt;`reveal` - reveal from right to left&lt;/li&gt;<br/>
        ///     &lt;li&gt;`wipeLeft` - fade across screen to the left&lt;/li&gt;<br/>
        ///     &lt;li&gt;`wipeRight` - fade across screen to the right&lt;/li&gt;<br/>
        ///     &lt;li&gt;`slideLeft` - move slightly left and fade out&lt;/li&gt;<br/>
        ///     &lt;li&gt;`slideRight` - move slightly right and fade out&lt;/li&gt;<br/>
        ///     &lt;li&gt;`slideUp` - move slightly up and fade out&lt;/li&gt;<br/>
        ///     &lt;li&gt;`slideDown` - move slightly down and fade out&lt;/li&gt;<br/>
        ///     &lt;li&gt;`carouselLeft` - slide out from right to left&lt;/li&gt;<br/>
        ///     &lt;li&gt;`carouselRight` - slide out from left to right&lt;/li&gt;<br/>
        ///     &lt;li&gt;`carouselUp` - slide out from bottom to top&lt;/li&gt;<br/>
        ///     &lt;li&gt;`carouselDown` - slide out from top  to bottom&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleTopRight` - rotate out from top right&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleRightTop` - rotate out from right top&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleRightBottom` - rotate out from right bottom&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleBottomRight` - rotate out from bottom right&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleBottomLeft` - rotate out from bottom left&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleLeftBottom` - rotate out from left bottom&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleLeftTop` - rotate out from left top&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleTopLeft` - rotate out from top left&lt;/li&gt;<br/>
        ///     &lt;li&gt;`zoom` - fast zoom out&lt;/li&gt;<br/>
        ///   &lt;/ul&gt;<br/>
        /// The transition speed can also be controlled by appending `Fast` or `Slow` to the transition, e.g. `fadeFast` or `CarouselLeftSlow`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("out")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransitionOutJsonConverter))]
        public global::G.TransitionOut? Out { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Transition" /> class.
        /// </summary>
        /// <param name="in">
        /// The transition in. Available transitions are:<br/>
        ///   &lt;ul&gt;<br/>
        ///     &lt;li&gt;`fade` - fade in&lt;/li&gt;<br/>
        ///     &lt;li&gt;`reveal` - reveal from left to right&lt;/li&gt;<br/>
        ///     &lt;li&gt;`wipeLeft` - fade across screen to the left&lt;/li&gt;<br/>
        ///     &lt;li&gt;`wipeRight` - fade across screen to the right&lt;/li&gt;<br/>
        ///     &lt;li&gt;`slideLeft` - move slightly left and fade in&lt;/li&gt;<br/>
        ///     &lt;li&gt;`slideRight` - move slightly right and fade in&lt;/li&gt;<br/>
        ///     &lt;li&gt;`slideUp` - move slightly up and fade in&lt;/li&gt;<br/>
        ///     &lt;li&gt;`slideDown` - move slightly down and fade in&lt;/li&gt;<br/>
        ///     &lt;li&gt;`carouselLeft` - slide in from right to left&lt;/li&gt;<br/>
        ///     &lt;li&gt;`carouselRight` - slide in from left to right&lt;/li&gt;<br/>
        ///     &lt;li&gt;`carouselUp` - slide in from bottom to top&lt;/li&gt;<br/>
        ///     &lt;li&gt;`carouselDown` - slide in from top to bottom&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleTopRight` - rotate in from top right&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleRightTop` - rotate in from right top&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleRightBottom` - rotate in from right bottom&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleBottomRight` - rotate in from bottom right&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleBottomLeft` - rotate in from bottom left&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleLeftBottom` - rotate in from left bottom&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleLeftTop` - rotate in from left top&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleTopLeft` - rotate in from top left&lt;/li&gt;<br/>
        ///     &lt;li&gt;`zoom` - fast zoom in&lt;/li&gt;<br/>
        ///   &lt;/ul&gt;<br/>
        /// The transition speed can also be controlled by appending `Fast` or `Slow` to the transition, e.g. `fadeFast` or `CarouselLeftSlow`.
        /// </param>
        /// <param name="out">
        /// The transition out. Available transitions are:<br/>
        ///   &lt;ul&gt;<br/>
        ///     &lt;li&gt;`fade` - fade out&lt;/li&gt;<br/>
        ///     &lt;li&gt;`reveal` - reveal from right to left&lt;/li&gt;<br/>
        ///     &lt;li&gt;`wipeLeft` - fade across screen to the left&lt;/li&gt;<br/>
        ///     &lt;li&gt;`wipeRight` - fade across screen to the right&lt;/li&gt;<br/>
        ///     &lt;li&gt;`slideLeft` - move slightly left and fade out&lt;/li&gt;<br/>
        ///     &lt;li&gt;`slideRight` - move slightly right and fade out&lt;/li&gt;<br/>
        ///     &lt;li&gt;`slideUp` - move slightly up and fade out&lt;/li&gt;<br/>
        ///     &lt;li&gt;`slideDown` - move slightly down and fade out&lt;/li&gt;<br/>
        ///     &lt;li&gt;`carouselLeft` - slide out from right to left&lt;/li&gt;<br/>
        ///     &lt;li&gt;`carouselRight` - slide out from left to right&lt;/li&gt;<br/>
        ///     &lt;li&gt;`carouselUp` - slide out from bottom to top&lt;/li&gt;<br/>
        ///     &lt;li&gt;`carouselDown` - slide out from top  to bottom&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleTopRight` - rotate out from top right&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleRightTop` - rotate out from right top&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleRightBottom` - rotate out from right bottom&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleBottomRight` - rotate out from bottom right&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleBottomLeft` - rotate out from bottom left&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleLeftBottom` - rotate out from left bottom&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleLeftTop` - rotate out from left top&lt;/li&gt;<br/>
        ///     &lt;li&gt;`shuffleTopLeft` - rotate out from top left&lt;/li&gt;<br/>
        ///     &lt;li&gt;`zoom` - fast zoom out&lt;/li&gt;<br/>
        ///   &lt;/ul&gt;<br/>
        /// The transition speed can also be controlled by appending `Fast` or `Slow` to the transition, e.g. `fadeFast` or `CarouselLeftSlow`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Transition(
            global::G.TransitionIn? @in,
            global::G.TransitionOut? @out)
        {
            this.In = @in;
            this.Out = @out;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transition" /> class.
        /// </summary>
        public Transition()
        {
        }
    }
}