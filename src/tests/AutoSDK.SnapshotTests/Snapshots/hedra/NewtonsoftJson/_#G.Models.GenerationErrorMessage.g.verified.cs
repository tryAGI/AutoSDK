//HintName: G.Models.GenerationErrorMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error message. Value is not present unless the status of the generation is 'error' and error field is not present.
    /// </summary>
    public sealed partial class GenerationErrorMessage
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}