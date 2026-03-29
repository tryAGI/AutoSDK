//HintName: G.Models.ConversationFlowComponentBeginTagDisplayPosition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Display position for the begin tag in the frontend
    /// </summary>
    public sealed partial class ConversationFlowComponentBeginTagDisplayPosition
    {
        /// <summary>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        public double? X { get; set; }

        /// <summary>
        /// Example: 200
        /// </summary>
        /// <example>200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        public double? Y { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationFlowComponentBeginTagDisplayPosition" /> class.
        /// </summary>
        /// <param name="x">
        /// Example: 100
        /// </param>
        /// <param name="y">
        /// Example: 200
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationFlowComponentBeginTagDisplayPosition(
            double? x,
            double? y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationFlowComponentBeginTagDisplayPosition" /> class.
        /// </summary>
        public ConversationFlowComponentBeginTagDisplayPosition()
        {
        }
    }
}