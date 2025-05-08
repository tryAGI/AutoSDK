//HintName: G.Models.EvalPythonGrader.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A PythonGrader object that runs a python script on the input.
    /// </summary>
    public sealed partial class EvalPythonGrader
    {
        /// <summary>
        /// The object type, which is always `python`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalPythonGraderTypeJsonConverter))]
        public global::G.EvalPythonGraderType Type { get; set; }

        /// <summary>
        /// The name of the grader.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The source code of the python script.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// The threshold for the score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pass_threshold")]
        public double? PassThreshold { get; set; }

        /// <summary>
        /// The image tag to use for the python script.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_tag")]
        public string? ImageTag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalPythonGrader" /> class.
        /// </summary>
        /// <param name="type">
        /// The object type, which is always `python`.
        /// </param>
        /// <param name="name">
        /// The name of the grader.
        /// </param>
        /// <param name="source">
        /// The source code of the python script.
        /// </param>
        /// <param name="passThreshold">
        /// The threshold for the score.
        /// </param>
        /// <param name="imageTag">
        /// The image tag to use for the python script.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalPythonGrader(
            string name,
            string source,
            global::G.EvalPythonGraderType type,
            double? passThreshold,
            string? imageTag)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Type = type;
            this.PassThreshold = passThreshold;
            this.ImageTag = imageTag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalPythonGrader" /> class.
        /// </summary>
        public EvalPythonGrader()
        {
        }
    }
}