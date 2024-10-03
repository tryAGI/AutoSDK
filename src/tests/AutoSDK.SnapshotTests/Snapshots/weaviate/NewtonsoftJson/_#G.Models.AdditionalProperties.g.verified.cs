//HintName: G.Models.AdditionalProperties.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// (Response only) Additional meta information about a single object.
    /// </summary>
    public sealed partial class AdditionalProperties
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties2 { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}