//HintName: G.Models.VolumeAndToken.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VolumeAndToken
    {
        /// <summary>
        /// ID of the volume
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("volumeID", Required = global::Newtonsoft.Json.Required.Always)]
        public string VolumeID { get; set; } = default!;

        /// <summary>
        /// Name of the volume
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Auth token to use for interacting with volume content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeAndToken" /> class.
        /// </summary>
        /// <param name="volumeID">
        /// ID of the volume
        /// </param>
        /// <param name="name">
        /// Name of the volume
        /// </param>
        /// <param name="token">
        /// Auth token to use for interacting with volume content
        /// </param>
        public VolumeAndToken(
            string volumeID,
            string name,
            string token)
        {
            this.VolumeID = volumeID ?? throw new global::System.ArgumentNullException(nameof(volumeID));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeAndToken" /> class.
        /// </summary>
        public VolumeAndToken()
        {
        }
    }
}