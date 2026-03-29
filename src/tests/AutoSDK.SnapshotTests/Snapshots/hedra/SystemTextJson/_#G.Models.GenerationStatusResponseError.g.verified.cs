//HintName: G.Models.GenerationStatusResponseError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Generation error if any. Value is not present unless the status of the generation is 'error' and error_message field is not present.
    /// </summary>
    public sealed partial class GenerationStatusResponseError
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}