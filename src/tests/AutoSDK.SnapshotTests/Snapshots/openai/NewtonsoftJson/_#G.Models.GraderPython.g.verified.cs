//HintName: G.Models.GraderPython.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A PythonGrader object that runs a python script on the input.
    /// </summary>
    public sealed partial class GraderPython
    {
        /// <summary>
        /// The object type, which is always `python`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.GraderPythonType Type { get; set; }

        /// <summary>
        /// The name of the grader.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The source code of the python script.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public string Source { get; set; } = default!;

        /// <summary>
        /// The image tag to use for the python script.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_tag")]
        public string? ImageTag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraderPython" /> class.
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
        /// <param name="imageTag">
        /// The image tag to use for the python script.
        /// </param>
        public GraderPython(
            string name,
            string source,
            global::G.GraderPythonType type,
            string? imageTag)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Type = type;
            this.ImageTag = imageTag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraderPython" /> class.
        /// </summary>
        public GraderPython()
        {
        }
    }
}