//HintName: G.Models.ExtendedExperimentData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtendedExperimentData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_prompt_version", Required = global::Newtonsoft.Json.Required.Always)]
        public string OriginalPromptVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("copied_original_prompt_version")]
        public string? CopiedOriginalPromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_keys")]
        public global::System.Collections.Generic.IList<string>? InputKeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rows", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExperimentV2Row> Rows { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedExperimentData" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="originalPromptVersion"></param>
        /// <param name="createdAt"></param>
        /// <param name="rows"></param>
        /// <param name="copiedOriginalPromptVersion"></param>
        /// <param name="inputKeys"></param>
        public ExtendedExperimentData(
            string id,
            string name,
            string originalPromptVersion,
            string createdAt,
            global::System.Collections.Generic.IList<global::G.ExperimentV2Row> rows,
            string? copiedOriginalPromptVersion,
            global::System.Collections.Generic.IList<string>? inputKeys)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OriginalPromptVersion = originalPromptVersion ?? throw new global::System.ArgumentNullException(nameof(originalPromptVersion));
            this.CopiedOriginalPromptVersion = copiedOriginalPromptVersion;
            this.InputKeys = inputKeys;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Rows = rows ?? throw new global::System.ArgumentNullException(nameof(rows));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedExperimentData" /> class.
        /// </summary>
        public ExtendedExperimentData()
        {
        }
    }
}