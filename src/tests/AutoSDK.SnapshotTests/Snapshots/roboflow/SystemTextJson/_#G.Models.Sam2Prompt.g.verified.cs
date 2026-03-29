//HintName: G.Models.Sam2Prompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Sam2Prompt
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("box")]
        public global::G.Box? Box { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points")]
        public global::System.Collections.Generic.IList<global::G.PointInput>? Points { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam2Prompt" /> class.
        /// </summary>
        /// <param name="box"></param>
        /// <param name="points"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Sam2Prompt(
            global::G.Box? box,
            global::System.Collections.Generic.IList<global::G.PointInput>? points)
        {
            this.Box = box;
            this.Points = points;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam2Prompt" /> class.
        /// </summary>
        public Sam2Prompt()
        {
        }
    }
}