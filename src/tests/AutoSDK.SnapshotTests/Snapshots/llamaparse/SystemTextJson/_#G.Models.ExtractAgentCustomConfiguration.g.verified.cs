//HintName: G.Models.ExtractAgentCustomConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Custom configuration type for the extraction agent. Currently supports 'default'.
    /// </summary>
    public sealed partial class ExtractAgentCustomConfiguration
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}