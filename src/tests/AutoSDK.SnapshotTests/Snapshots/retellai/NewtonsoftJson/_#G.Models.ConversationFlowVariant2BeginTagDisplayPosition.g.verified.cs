//HintName: G.Models.ConversationFlowVariant2BeginTagDisplayPosition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Display position for the begin tag in the frontend.
    /// </summary>
    public sealed partial class ConversationFlowVariant2BeginTagDisplayPosition
    {
        /// <summary>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("x")]
        public double? X { get; set; }

        /// <summary>
        /// Example: 200
        /// </summary>
        /// <example>200</example>
        [global::Newtonsoft.Json.JsonProperty("y")]
        public double? Y { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationFlowVariant2BeginTagDisplayPosition" /> class.
        /// </summary>
        /// <param name="x">
        /// Example: 100
        /// </param>
        /// <param name="y">
        /// Example: 200
        /// </param>
        public ConversationFlowVariant2BeginTagDisplayPosition(
            double? x,
            double? y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationFlowVariant2BeginTagDisplayPosition" /> class.
        /// </summary>
        public ConversationFlowVariant2BeginTagDisplayPosition()
        {
        }
    }
}