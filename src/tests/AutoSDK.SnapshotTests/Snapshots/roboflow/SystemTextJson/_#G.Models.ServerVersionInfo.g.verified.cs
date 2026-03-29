//HintName: G.Models.ServerVersionInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Server version information.<br/>
    /// Attributes:<br/>
    ///     name (str): Server name.<br/>
    ///     version (str): Server version.<br/>
    ///     uuid (str): Server UUID.
    /// </summary>
    public sealed partial class ServerVersionInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerVersionInfo" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="uuid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerVersionInfo(
            string name,
            string version,
            string uuid)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Uuid = uuid ?? throw new global::System.ArgumentNullException(nameof(uuid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerVersionInfo" /> class.
        /// </summary>
        public ServerVersionInfo()
        {
        }
    }
}