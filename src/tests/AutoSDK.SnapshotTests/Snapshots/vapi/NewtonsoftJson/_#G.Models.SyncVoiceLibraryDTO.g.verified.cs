//HintName: G.Models.SyncVoiceLibraryDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SyncVoiceLibraryDTO
    {
        /// <summary>
        /// List of providers you want to sync.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providers")]
        public global::System.Collections.Generic.IList<global::G.SyncVoiceLibraryDTOProvider>? Providers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncVoiceLibraryDTO" /> class.
        /// </summary>
        /// <param name="providers">
        /// List of providers you want to sync.
        /// </param>
        public SyncVoiceLibraryDTO(
            global::System.Collections.Generic.IList<global::G.SyncVoiceLibraryDTOProvider>? providers)
        {
            this.Providers = providers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncVoiceLibraryDTO" /> class.
        /// </summary>
        public SyncVoiceLibraryDTO()
        {
        }
    }
}