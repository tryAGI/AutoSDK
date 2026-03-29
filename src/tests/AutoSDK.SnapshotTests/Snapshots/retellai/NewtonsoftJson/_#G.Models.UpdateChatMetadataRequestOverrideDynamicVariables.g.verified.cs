//HintName: G.Models.UpdateChatMetadataRequestOverrideDynamicVariables.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Override dynamic varaibles represented as key-value pairs of strings. Setting this will override or add the dynamic variables set in the agent during the call. Only need to set the delta where you want to override, no need to set the entire dynamic variables object. Setting this to null will remove any existing override.<br/>
    /// Example: {"additional_discount":"15%"}
    /// </summary>
    public sealed partial class UpdateChatMetadataRequestOverrideDynamicVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}