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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_prompt_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalPromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copied_original_prompt_version")]
        public string? CopiedOriginalPromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_keys")]
        public global::System.Collections.Generic.IList<string>? InputKeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ExperimentV2Row> Rows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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