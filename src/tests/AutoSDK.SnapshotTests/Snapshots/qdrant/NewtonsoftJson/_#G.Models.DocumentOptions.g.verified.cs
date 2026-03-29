//HintName: G.Models.DocumentOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Additional options for the model, will be passed to the inference service as-is. See model cards for available options.
    /// </summary>
    public sealed partial class DocumentOptions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}