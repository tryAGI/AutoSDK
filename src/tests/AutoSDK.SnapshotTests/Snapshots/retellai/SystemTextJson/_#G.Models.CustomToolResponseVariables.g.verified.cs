//HintName: G.Models.CustomToolResponseVariables.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A mapping of variable names to JSON paths in the response body. These values will be extracted from the response and made available as dynamic variables for use.<br/>
    /// Example: {"user_name":"data.user.name"}
    /// </summary>
    public sealed partial class CustomToolResponseVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}