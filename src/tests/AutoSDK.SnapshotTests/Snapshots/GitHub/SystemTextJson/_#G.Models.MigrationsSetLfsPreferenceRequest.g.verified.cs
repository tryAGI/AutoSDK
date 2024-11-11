//HintName: G.Models.MigrationsSetLfsPreferenceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MigrationsSetLfsPreferenceRequest
    {
        /// <summary>
        /// Whether to store large files during the import. `opt_in` means large files will be stored using Git LFS. `opt_out` means large files will be removed during the import.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_lfs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MigrationsSetLfsPreferenceRequestUseLfsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MigrationsSetLfsPreferenceRequestUseLfs UseLfs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationsSetLfsPreferenceRequest" /> class.
        /// </summary>
        /// <param name="useLfs">
        /// Whether to store large files during the import. `opt_in` means large files will be stored using Git LFS. `opt_out` means large files will be removed during the import.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MigrationsSetLfsPreferenceRequest(
            global::G.MigrationsSetLfsPreferenceRequestUseLfs useLfs)
        {
            this.UseLfs = useLfs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationsSetLfsPreferenceRequest" /> class.
        /// </summary>
        public MigrationsSetLfsPreferenceRequest()
        {
        }
    }
}