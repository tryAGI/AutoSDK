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
        [global::Newtonsoft.Json.JsonProperty("use_lfs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MigrationsSetLfsPreferenceRequestUseLfs UseLfs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationsSetLfsPreferenceRequest" /> class.
        /// </summary>
        /// <param name="useLfs">
        /// Whether to store large files during the import. `opt_in` means large files will be stored using Git LFS. `opt_out` means large files will be removed during the import.
        /// </param>
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