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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The text content of the stage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// A list of sources (URLs) that that stage used to process that particular step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<string>? Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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