//HintName: G.Models.TableGenerationSpecModelParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional parameters for the specified model used when generating the table summary.<br/>
    /// Example: {"temperature":0,"max_tokens":512}
    /// </summary>
    public sealed partial class TableGenerationSpecModelParameters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}