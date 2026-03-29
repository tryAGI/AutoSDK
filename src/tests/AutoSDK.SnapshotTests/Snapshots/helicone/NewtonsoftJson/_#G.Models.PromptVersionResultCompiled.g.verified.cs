//HintName: G.Models.PromptVersionResultCompiled.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersionResultCompiled
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minor_version", Required = global::Newtonsoft.Json.Required.Always)]
        public double MinorVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("major_version", Required = global::Newtonsoft.Json.Required.Always)]
        public double MajorVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_v2", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptV2 { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_compiled", Required = global::Newtonsoft.Json.Required.Always)]
        public object PromptCompiled { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionResultCompiled" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="minorVersion"></param>
        /// <param name="majorVersion"></param>
        /// <param name="promptV2"></param>
        /// <param name="model"></param>
        /// <param name="promptCompiled"></param>
        public PromptVersionResultCompiled(
            string id,
            double minorVersion,
            double majorVersion,
            string promptV2,
            string model,
            object promptCompiled)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MinorVersion = minorVersion;
            this.MajorVersion = majorVersion;
            this.PromptV2 = promptV2 ?? throw new global::System.ArgumentNullException(nameof(promptV2));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.PromptCompiled = promptCompiled ?? throw new global::System.ArgumentNullException(nameof(promptCompiled));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionResultCompiled" /> class.
        /// </summary>
        public PromptVersionResultCompiled()
        {
        }
    }
}