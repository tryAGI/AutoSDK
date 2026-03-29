//HintName: G.Models.GenerateApplicationChunkStage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateApplicationChunkStage
    {
        /// <summary>
        /// The unique identifier for the stage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The text content of the stage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// A list of sources (URLs) that that stage used to process that particular step.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sources")]
        public global::System.Collections.Generic.IList<string>? Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateApplicationChunkStage" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the stage.
        /// </param>
        /// <param name="content">
        /// The text content of the stage.
        /// </param>
        /// <param name="sources">
        /// A list of sources (URLs) that that stage used to process that particular step.
        /// </param>
        public GenerateApplicationChunkStage(
            global::System.Guid id,
            string content,
            global::System.Collections.Generic.IList<string>? sources)
        {
            this.Id = id;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Sources = sources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateApplicationChunkStage" /> class.
        /// </summary>
        public GenerateApplicationChunkStage()
        {
        }
    }
}