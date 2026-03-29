//HintName: G.Models.RichTextGradient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Gradient properties for text fill.
    /// </summary>
    public sealed partial class RichTextGradient
    {
        /// <summary>
        /// The type of gradient.<br/>
        /// Default Value: linear<br/>
        /// Example: linear
        /// </summary>
        /// <example>linear</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RichTextGradientType? Type { get; set; }

        /// <summary>
        /// The angle of the gradient in degrees (for linear gradients). Must be between 0 and 360.<br/>
        /// Default Value: 0<br/>
        /// Example: 45
        /// </summary>
        /// <example>45</example>
        [global::Newtonsoft.Json.JsonProperty("angle")]
        public double? Angle { get; set; }

        /// <summary>
        /// Gradient color stops. Must have at least 2 stops.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stops", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RichTextGradientStop> Stops { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextGradient" /> class.
        /// </summary>
        /// <param name="stops">
        /// Gradient color stops. Must have at least 2 stops.
        /// </param>
        /// <param name="type">
        /// The type of gradient.<br/>
        /// Default Value: linear<br/>
        /// Example: linear
        /// </param>
        /// <param name="angle">
        /// The angle of the gradient in degrees (for linear gradients). Must be between 0 and 360.<br/>
        /// Default Value: 0<br/>
        /// Example: 45
        /// </param>
        public RichTextGradient(
            global::System.Collections.Generic.IList<global::G.RichTextGradientStop> stops,
            global::G.RichTextGradientType? type,
            double? angle)
        {
            this.Type = type;
            this.Angle = angle;
            this.Stops = stops ?? throw new global::System.ArgumentNullException(nameof(stops));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextGradient" /> class.
        /// </summary>
        public RichTextGradient()
        {
        }
    }
}