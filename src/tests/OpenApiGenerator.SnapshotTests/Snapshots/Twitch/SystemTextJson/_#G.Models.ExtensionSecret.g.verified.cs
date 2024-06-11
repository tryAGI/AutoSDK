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
        [global::System.Text.Json.Serialization.JsonPropertyName("format_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FormatVersion { get; set; }

        /// <summary>
        /// The list of secrets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ExtensionSecretSecrets> Secrets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}