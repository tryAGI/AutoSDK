//HintName: G.Models.ChecksUpdateRequestAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChecksUpdateRequestAction
    {
        /// <summary>
        /// The text to be displayed on a button in the web UI. The maximum size is 20 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// A short explanation of what this action would do. The maximum size is 40 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// A reference for the action on the integrator's system. The maximum size is 20 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("identifier", Required = global::Newtonsoft.Json.Required.Always)]
        public string Identifier { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}