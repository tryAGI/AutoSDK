//HintName: G.Models.ModelPriceMapUpdateSchema.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Model price map update schema.
    /// </summary>
    public sealed partial class ModelPriceMapUpdateSchema
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
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Default Value: [model, model_name, model_id, model_path, endpoint_name]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match_path")]
        public global::System.Collections.Generic.IList<string>? MatchPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match_pattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MatchPattern { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cost")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<double?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<double?, string> PromptCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_cost")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<double?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<double?, string> CompletionCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPriceMapUpdateSchema" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startTime"></param>
        /// <param name="matchPath">
        /// Default Value: [model, model_name, model_id, model_path, endpoint_name]
        /// </param>
        /// <param name="matchPattern"></param>
        /// <param name="promptCost"></param>
        /// <param name="completionCost"></param>
        /// <param name="provider"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ModelPriceMapUpdateSchema(
            string name,
            string matchPattern,
            global::G.AnyOf<double?, string> promptCost,
            global::G.AnyOf<double?, string> completionCost,
            global::System.DateTime? startTime,
            global::System.Collections.Generic.IList<string>? matchPath,
            string? provider)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.MatchPattern = matchPattern ?? throw new global::System.ArgumentNullException(nameof(matchPattern));
            this.PromptCost = promptCost;
            this.CompletionCost = completionCost;
            this.StartTime = startTime;
            this.MatchPath = matchPath;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPriceMapUpdateSchema" /> class.
        /// </summary>
        public ModelPriceMapUpdateSchema()
        {
        }
    }
}