//HintName: G.Models.ImportProjectMediaRequestAddComposition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines a composition to create in the project
    /// </summary>
    public sealed partial class ImportProjectMediaRequestAddComposition
    {
        /// <summary>
        /// Name of the composition. If not provided, uses default naming.<br/>
        /// Example: Rough Cut
        /// </summary>
        /// <example>Rough Cut</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Width of the composition in pixels<br/>
        /// Default Value: 1920<br/>
        /// Example: 1920
        /// </summary>
        /// <example>1920</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Height of the composition in pixels<br/>
        /// Default Value: 1080<br/>
        /// Example: 1080
        /// </summary>
        /// <example>1080</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// **[Work in progress]** This property is not yet supported and will be ignored if provided.<br/>
        /// Frame rate for the composition in frames per second.<br/>
        /// Common values: 24, 25, 29.97, 30, 60.<br/>
        /// Default Value: 30<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fps")]
        public double? Fps { get; set; }

        /// <summary>
        /// Ordered list of clips to include in the composition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clips")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ImportProjectMediaRequestAddCompositionClip> Clips { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProjectMediaRequestAddComposition" /> class.
        /// </summary>
        /// <param name="clips">
        /// Ordered list of clips to include in the composition
        /// </param>
        /// <param name="name">
        /// Name of the composition. If not provided, uses default naming.<br/>
        /// Example: Rough Cut
        /// </param>
        /// <param name="width">
        /// Width of the composition in pixels<br/>
        /// Default Value: 1920<br/>
        /// Example: 1920
        /// </param>
        /// <param name="height">
        /// Height of the composition in pixels<br/>
        /// Default Value: 1080<br/>
        /// Example: 1080
        /// </param>
        /// <param name="fps">
        /// **[Work in progress]** This property is not yet supported and will be ignored if provided.<br/>
        /// Frame rate for the composition in frames per second.<br/>
        /// Common values: 24, 25, 29.97, 30, 60.<br/>
        /// Default Value: 30<br/>
        /// Example: 30
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportProjectMediaRequestAddComposition(
            global::System.Collections.Generic.IList<global::G.ImportProjectMediaRequestAddCompositionClip> clips,
            string? name,
            int? width,
            int? height,
            double? fps)
        {
            this.Name = name;
            this.Width = width;
            this.Height = height;
            this.Fps = fps;
            this.Clips = clips ?? throw new global::System.ArgumentNullException(nameof(clips));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProjectMediaRequestAddComposition" /> class.
        /// </summary>
        public ImportProjectMediaRequestAddComposition()
        {
        }
    }
}