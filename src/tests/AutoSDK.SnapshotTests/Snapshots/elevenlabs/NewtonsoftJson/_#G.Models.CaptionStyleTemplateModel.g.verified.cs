//HintName: G.Models.CaptionStyleTemplateModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CaptionStyleTemplateModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requires_high_fps")]
        public bool? RequiresHighFps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionStyleTemplateModel" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="label"></param>
        /// <param name="requiresHighFps">
        /// Default Value: false
        /// </param>
        public CaptionStyleTemplateModel(
            string key,
            string label,
            bool? requiresHighFps)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.RequiresHighFps = requiresHighFps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionStyleTemplateModel" /> class.
        /// </summary>
        public CaptionStyleTemplateModel()
        {
        }
    }
}