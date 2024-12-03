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

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionSecret" /> class.
        /// </summary>
        /// <param name="formatVersion">
        /// The version number that identifies this definition of the secret’s data.
        /// </param>
        /// <param name="secrets">
        /// The list of secrets.
        /// </param>
        public ExtensionSecret(
            int formatVersion,
            global::System.Collections.Generic.IList<global::G.ExtensionSecretSecret> secrets)
        {
            this.FormatVersion = formatVersion;
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionSecret" /> class.
        /// </summary>
        public ExtensionSecret()
        {
        }
    }
}