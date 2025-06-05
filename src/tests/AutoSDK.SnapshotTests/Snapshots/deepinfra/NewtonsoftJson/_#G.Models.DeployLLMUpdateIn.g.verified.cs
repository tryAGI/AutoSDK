//HintName: G.Models.DeployLLMUpdateIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeployLLMUpdateIn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("settings", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ScaleSettings Settings { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployLLMUpdateIn" /> class.
        /// </summary>
        /// <param name="settings"></param>
        public DeployLLMUpdateIn(
            global::G.ScaleSettings settings)
        {
            this.Settings = settings ?? throw new global::System.ArgumentNullException(nameof(settings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployLLMUpdateIn" /> class.
        /// </summary>
        public DeployLLMUpdateIn()
        {
        }
    }
}