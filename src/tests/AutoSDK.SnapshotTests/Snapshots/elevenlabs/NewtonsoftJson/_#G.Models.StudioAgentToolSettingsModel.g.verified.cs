//HintName: G.Models.StudioAgentToolSettingsModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StudioAgentToolSettingsModel
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("skip_confirmation")]
        public bool? SkipConfirmation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StudioAgentToolSettingsModel" /> class.
        /// </summary>
        /// <param name="skipConfirmation">
        /// Default Value: false
        /// </param>
        public StudioAgentToolSettingsModel(
            bool? skipConfirmation)
        {
            this.SkipConfirmation = skipConfirmation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StudioAgentToolSettingsModel" /> class.
        /// </summary>
        public StudioAgentToolSettingsModel()
        {
        }
    }
}