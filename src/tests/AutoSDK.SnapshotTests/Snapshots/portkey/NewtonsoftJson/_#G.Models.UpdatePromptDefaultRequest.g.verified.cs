//HintName: G.Models.UpdatePromptDefaultRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePromptDefaultRequest
    {
        /// <summary>
        /// Version Number to set as default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public double Version { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePromptDefaultRequest" /> class.
        /// </summary>
        /// <param name="version">
        /// Version Number to set as default
        /// </param>
        public UpdatePromptDefaultRequest(
            double version)
        {
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePromptDefaultRequest" /> class.
        /// </summary>
        public UpdatePromptDefaultRequest()
        {
        }
    }
}