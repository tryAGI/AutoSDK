//HintName: G.Models.InferencePrediction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InferencePrediction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public string? File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::G.ModelsPredictions? Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InferencePrediction" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="models"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InferencePrediction(
            string? file,
            global::G.ModelsPredictions? models)
        {
            this.File = file;
            this.Models = models;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InferencePrediction" /> class.
        /// </summary>
        public InferencePrediction()
        {
        }
    }
}