//HintName: G.Models.TemplateBuildStartV2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateBuildStartV2
    {
        /// <summary>
        /// Image to use as a base for the template build
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fromImage")]
        public string? FromImage { get; set; }

        /// <summary>
        /// Template to use as a base for the template build
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fromTemplate")]
        public string? FromTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fromImageRegistry")]
        public global::G.FromImageRegistry? FromImageRegistry { get; set; }

        /// <summary>
        /// Whether the whole build should be forced to run regardless of the cache<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("force")]
        public bool? Force { get; set; }

        /// <summary>
        /// List of steps to execute in the template build<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("steps")]
        public global::System.Collections.Generic.IList<global::G.TemplateStep>? Steps { get; set; }

        /// <summary>
        /// Start command to execute in the template after the build
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startCmd")]
        public string? StartCmd { get; set; }

        /// <summary>
        /// Ready check command to execute in the template after the build
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readyCmd")]
        public string? ReadyCmd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateBuildStartV2" /> class.
        /// </summary>
        /// <param name="fromImage">
        /// Image to use as a base for the template build
        /// </param>
        /// <param name="fromTemplate">
        /// Template to use as a base for the template build
        /// </param>
        /// <param name="fromImageRegistry"></param>
        /// <param name="force">
        /// Whether the whole build should be forced to run regardless of the cache<br/>
        /// Default Value: false
        /// </param>
        /// <param name="steps">
        /// List of steps to execute in the template build<br/>
        /// Default Value: []
        /// </param>
        /// <param name="startCmd">
        /// Start command to execute in the template after the build
        /// </param>
        /// <param name="readyCmd">
        /// Ready check command to execute in the template after the build
        /// </param>
        public TemplateBuildStartV2(
            string? fromImage,
            string? fromTemplate,
            global::G.FromImageRegistry? fromImageRegistry,
            bool? force,
            global::System.Collections.Generic.IList<global::G.TemplateStep>? steps,
            string? startCmd,
            string? readyCmd)
        {
            this.FromImage = fromImage;
            this.FromTemplate = fromTemplate;
            this.FromImageRegistry = fromImageRegistry;
            this.Force = force;
            this.Steps = steps;
            this.StartCmd = startCmd;
            this.ReadyCmd = readyCmd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateBuildStartV2" /> class.
        /// </summary>
        public TemplateBuildStartV2()
        {
        }
    }
}