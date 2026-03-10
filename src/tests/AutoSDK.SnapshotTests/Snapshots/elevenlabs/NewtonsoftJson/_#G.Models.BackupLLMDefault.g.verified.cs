//HintName: G.Models.BackupLLMDefault.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BackupLLMDefault
    {
        /// <summary>
        /// Default Value: default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preference")]
        public string? Preference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupLLMDefault" /> class.
        /// </summary>
        /// <param name="preference">
        /// Default Value: default
        /// </param>
        public BackupLLMDefault(
            string? preference)
        {
            this.Preference = preference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupLLMDefault" /> class.
        /// </summary>
        public BackupLLMDefault()
        {
        }
    }
}