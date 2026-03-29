//HintName: G.Models.EditInDescriptSchemaPostBodyProjectSchemaFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"name":"Jane\u0027s studio recording","uri":"https://descriptusercontent.com/jane.wav?signature=d182bca64bf94a1483d2fd16b579f955","start_offset":{"seconds":10}}
    /// </summary>
    public sealed partial class EditInDescriptSchemaPostBodyProjectSchemaFile
    {
        /// <summary>
        /// A name for the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A public/pre-signed uri to the audio or video asset, see supported media specifications section.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// The amount of time into the Project's timeline this audio or video file should start at.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_offset")]
        public global::G.EditInDescriptSchemaPostBodyProjectSchemaFileStartOffset? StartOffset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditInDescriptSchemaPostBodyProjectSchemaFile" /> class.
        /// </summary>
        /// <param name="uri">
        /// A public/pre-signed uri to the audio or video asset, see supported media specifications section.
        /// </param>
        /// <param name="name">
        /// A name for the file.
        /// </param>
        /// <param name="startOffset">
        /// The amount of time into the Project's timeline this audio or video file should start at.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditInDescriptSchemaPostBodyProjectSchemaFile(
            string uri,
            string? name,
            global::G.EditInDescriptSchemaPostBodyProjectSchemaFileStartOffset? startOffset)
        {
            this.Name = name;
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.StartOffset = startOffset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditInDescriptSchemaPostBodyProjectSchemaFile" /> class.
        /// </summary>
        public EditInDescriptSchemaPostBodyProjectSchemaFile()
        {
        }
    }
}