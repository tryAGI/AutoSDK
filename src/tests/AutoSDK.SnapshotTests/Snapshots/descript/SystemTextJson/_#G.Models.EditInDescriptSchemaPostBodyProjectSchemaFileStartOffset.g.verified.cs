//HintName: G.Models.EditInDescriptSchemaPostBodyProjectSchemaFileStartOffset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The amount of time into the Project's timeline this audio or video file should start at.
    /// </summary>
    public sealed partial class EditInDescriptSchemaPostBodyProjectSchemaFileStartOffset
    {
        /// <summary>
        /// Float number of seconds into the timeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        public double? Seconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditInDescriptSchemaPostBodyProjectSchemaFileStartOffset" /> class.
        /// </summary>
        /// <param name="seconds">
        /// Float number of seconds into the timeline.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditInDescriptSchemaPostBodyProjectSchemaFileStartOffset(
            double? seconds)
        {
            this.Seconds = seconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditInDescriptSchemaPostBodyProjectSchemaFileStartOffset" /> class.
        /// </summary>
        public EditInDescriptSchemaPostBodyProjectSchemaFileStartOffset()
        {
        }
    }
}