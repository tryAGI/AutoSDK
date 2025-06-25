//HintName: G.Models.VoicesCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoicesCreateRequest
    {
        /// <summary>
        /// An audio file containing a sample of the voice to clone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// An audio file containing a sample of the voice to clone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Name for the cloned voice. Must be unique within your account.<br/>
        /// Example: My Custom Voice
        /// </summary>
        /// <example>My Custom Voice</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional description for the voice. If not provided, a default description will be generated.<br/>
        /// Example: Voice recorded on Jan 1, 2024
        /// </summary>
        /// <example>Voice recorded on Jan 1, 2024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicesCreateRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// An audio file containing a sample of the voice to clone.
        /// </param>
        /// <param name="filename">
        /// An audio file containing a sample of the voice to clone.
        /// </param>
        /// <param name="name">
        /// Name for the cloned voice. Must be unique within your account.<br/>
        /// Example: My Custom Voice
        /// </param>
        /// <param name="description">
        /// Optional description for the voice. If not provided, a default description will be generated.<br/>
        /// Example: Voice recorded on Jan 1, 2024
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoicesCreateRequest(
            byte[] file,
            string filename,
            string name,
            string? description)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicesCreateRequest" /> class.
        /// </summary>
        public VoicesCreateRequest()
        {
        }
    }
}