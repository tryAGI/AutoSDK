//HintName: G.Models.ModelPriceMapCreateSchema.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Model price map create schema.
    /// </summary>
    public sealed partial class ModelPriceMapCreateSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Default Value: [model, model_name, model_id, model_path, endpoint_name]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("match_path")]
        public global::System.Collections.Generic.IList<string>? MatchPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("match_pattern", Required = global::Newtonsoft.Json.Required.Always)]
        public string MatchPattern { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<double?, string> PromptCost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<double?, string> CompletionCost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPriceMapCreateSchema" /> class.
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
        public ModelPriceMapCreateSchema(
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
        /// Initializes a new instance of the <see cref="ModelPriceMapCreateSchema" /> class.
        /// </summary>
        public ModelPriceMapCreateSchema()
        {
        }
    }
}