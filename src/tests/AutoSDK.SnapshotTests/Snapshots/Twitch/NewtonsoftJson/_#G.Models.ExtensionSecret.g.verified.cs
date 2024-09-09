//HintName: G.Models.ExtensionSecret.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtensionSecret
    {
        /// <summary>
        /// The version number that identifies this definition of the secret’s data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format_version", Required = global::Newtonsoft.Json.Required.Always)]
        public int FormatVersion { get; set; } = default!;

        /// <summary>
        /// The list of secrets.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secrets", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExtensionSecretSecret> Secrets { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}