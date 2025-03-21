//HintName: G.Models.Metadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
    /// useful for storing additional information about the object in a structured<br/>
    /// format, and querying for objects via API or the dashboard. <br/>
    /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
    /// with a maximum length of 512 characters.
    /// </summary>
    public sealed partial class Metadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}