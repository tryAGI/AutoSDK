//HintName: G.Models.BackupLLMOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BackupLLMOverride
    {
        /// <summary>
        /// Default Value: override
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preference")]
        public string? Preference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("order", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Llm> Order { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupLLMOverride" /> class.
        /// </summary>
        /// <param name="preference">
        /// Default Value: override
        /// </param>
        /// <param name="order"></param>
        public BackupLLMOverride(
            global::System.Collections.Generic.IList<global::G.Llm> order,
            string? preference)
        {
            this.Order = order ?? throw new global::System.ArgumentNullException(nameof(order));
            this.Preference = preference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupLLMOverride" /> class.
        /// </summary>
        public BackupLLMOverride()
        {
        }
    }
}