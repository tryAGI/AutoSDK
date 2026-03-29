//HintName: G.Models.PerceptionLayer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PerceptionLayer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("perception_model")]
        public string? PerceptionModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ambient_awareness_queries")]
        public global::System.Collections.Generic.IList<string>? AmbientAwarenessQueries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visual_awareness_queries")]
        public global::System.Collections.Generic.IList<string>? VisualAwarenessQueries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("perception_analysis_queries")]
        public global::System.Collections.Generic.IList<string>? PerceptionAnalysisQueries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_awareness_queries")]
        public global::System.Collections.Generic.IList<string>? AudioAwarenessQueries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visual_tool_prompt")]
        public string? VisualToolPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visual_tools")]
        public global::System.Collections.Generic.IList<global::G.ToolDefinition>? VisualTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_tool_prompt")]
        public string? AudioToolPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_tools")]
        public global::System.Collections.Generic.IList<global::G.ToolDefinition>? AudioTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PerceptionLayer" /> class.
        /// </summary>
        /// <param name="perceptionModel"></param>
        /// <param name="ambientAwarenessQueries"></param>
        /// <param name="visualAwarenessQueries"></param>
        /// <param name="perceptionAnalysisQueries"></param>
        /// <param name="audioAwarenessQueries"></param>
        /// <param name="visualToolPrompt"></param>
        /// <param name="visualTools"></param>
        /// <param name="audioToolPrompt"></param>
        /// <param name="audioTools"></param>
        public PerceptionLayer(
            string? perceptionModel,
            global::System.Collections.Generic.IList<string>? ambientAwarenessQueries,
            global::System.Collections.Generic.IList<string>? visualAwarenessQueries,
            global::System.Collections.Generic.IList<string>? perceptionAnalysisQueries,
            global::System.Collections.Generic.IList<string>? audioAwarenessQueries,
            string? visualToolPrompt,
            global::System.Collections.Generic.IList<global::G.ToolDefinition>? visualTools,
            string? audioToolPrompt,
            global::System.Collections.Generic.IList<global::G.ToolDefinition>? audioTools)
        {
            this.PerceptionModel = perceptionModel;
            this.AmbientAwarenessQueries = ambientAwarenessQueries;
            this.VisualAwarenessQueries = visualAwarenessQueries;
            this.PerceptionAnalysisQueries = perceptionAnalysisQueries;
            this.AudioAwarenessQueries = audioAwarenessQueries;
            this.VisualToolPrompt = visualToolPrompt;
            this.VisualTools = visualTools;
            this.AudioToolPrompt = audioToolPrompt;
            this.AudioTools = audioTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerceptionLayer" /> class.
        /// </summary>
        public PerceptionLayer()
        {
        }
    }
}