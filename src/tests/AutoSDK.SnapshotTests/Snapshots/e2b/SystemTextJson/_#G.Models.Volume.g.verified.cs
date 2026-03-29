//HintName: G.Models.Volume.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Volume
    {
        /// <summary>
        /// ID of the volume
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumeID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VolumeID { get; set; }

        /// <summary>
        /// Name of the volume
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Volume" /> class.
        /// </summary>
        /// <param name="volumeID">
        /// ID of the volume
        /// </param>
        /// <param name="name">
        /// Name of the volume
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Volume(
            string volumeID,
            string name)
        {
            this.VolumeID = volumeID ?? throw new global::System.ArgumentNullException(nameof(volumeID));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Volume" /> class.
        /// </summary>
        public Volume()
        {
        }
    }
}