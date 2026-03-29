//HintName: G.Models.GenerateApplicationDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateApplicationDelta
    {
        /// <summary>
        /// The name of the output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The main text output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// A list of stages that show the 'thinking process'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stages")]
        public global::System.Collections.Generic.IList<global::G.GenerateApplicationChunkStage>? Stages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateApplicationDelta" /> class.
        /// </summary>
        /// <param name="title">
        /// The name of the output.
        /// </param>
        /// <param name="content">
        /// The main text output.
        /// </param>
        /// <param name="stages">
        /// A list of stages that show the 'thinking process'.
        /// </param>
        public GenerateApplicationDelta(
            string? title,
            string? content,
            global::System.Collections.Generic.IList<global::G.GenerateApplicationChunkStage>? stages)
        {
            this.Title = title;
            this.Content = content;
            this.Stages = stages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateApplicationDelta" /> class.
        /// </summary>
        public GenerateApplicationDelta()
        {
        }
    }
}