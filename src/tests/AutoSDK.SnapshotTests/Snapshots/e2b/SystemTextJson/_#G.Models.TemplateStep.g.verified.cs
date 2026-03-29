//HintName: G.Models.TemplateStep.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Step in the template build process
    /// </summary>
    public sealed partial class TemplateStep
    {
        /// <summary>
        /// Type of the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Arguments for the step<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        public global::System.Collections.Generic.IList<string>? Args { get; set; }

        /// <summary>
        /// Hash of the files used in the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filesHash")]
        public string? FilesHash { get; set; }

        /// <summary>
        /// Whether the step should be forced to run regardless of the cache<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force")]
        public bool? Force { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateStep" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of the step
        /// </param>
        /// <param name="args">
        /// Arguments for the step<br/>
        /// Default Value: []
        /// </param>
        /// <param name="filesHash">
        /// Hash of the files used in the step
        /// </param>
        /// <param name="force">
        /// Whether the step should be forced to run regardless of the cache<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateStep(
            string type,
            global::System.Collections.Generic.IList<string>? args,
            string? filesHash,
            bool? force)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Args = args;
            this.FilesHash = filesHash;
            this.Force = force;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateStep" /> class.
        /// </summary>
        public TemplateStep()
        {
        }
    }
}