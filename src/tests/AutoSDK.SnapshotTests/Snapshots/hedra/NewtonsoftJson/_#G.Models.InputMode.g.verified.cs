//HintName: G.Models.InputMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A named input mode grouping mutually exclusive input slots.<br/>
    /// Each mode represents a distinct way to use the model (e.g., image_to_video<br/>
    /// vs first_last_frame_to_video). The frontend selects one mode at a time and<br/>
    /// presents only that mode's slots.<br/>
    /// The text_to_video mode (no input files) is always implicitly available<br/>
    /// for VIDEO type models and is never included in the inputs list.
    /// </summary>
    public sealed partial class InputMode
    {
        /// <summary>
        /// Mode name identifying this input combination (e.g., 'image_to_video', 'first_last_frame_to_video', 'reference_to_video', 'video_to_video').
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode", Required = global::Newtonsoft.Json.Required.Always)]
        public string Mode { get; set; } = default!;

        /// <summary>
        /// Ordered list of input slots available in this mode.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slots", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.InputSlot> Slots { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMode" /> class.
        /// </summary>
        /// <param name="mode">
        /// Mode name identifying this input combination (e.g., 'image_to_video', 'first_last_frame_to_video', 'reference_to_video', 'video_to_video').
        /// </param>
        /// <param name="slots">
        /// Ordered list of input slots available in this mode.
        /// </param>
        public InputMode(
            string mode,
            global::System.Collections.Generic.IList<global::G.InputSlot> slots)
        {
            this.Mode = mode ?? throw new global::System.ArgumentNullException(nameof(mode));
            this.Slots = slots ?? throw new global::System.ArgumentNullException(nameof(slots));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMode" /> class.
        /// </summary>
        public InputMode()
        {
        }
    }
}