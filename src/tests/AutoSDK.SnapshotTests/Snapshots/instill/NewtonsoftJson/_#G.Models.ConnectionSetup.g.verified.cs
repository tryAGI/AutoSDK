//HintName: G.Models.ConnectionSetup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Connection details. This field is required on creation, optional on view.<br/>
    /// When viewing the connection details, the setup values will be redacted.
    /// </summary>
    public sealed partial class ConnectionSetup
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}