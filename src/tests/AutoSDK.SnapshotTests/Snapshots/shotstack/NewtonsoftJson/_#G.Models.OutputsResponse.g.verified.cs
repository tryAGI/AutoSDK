//HintName: G.Models.OutputsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The list of outputs generated from the source file. Currently supports renditions which are versions of the source file with different transformations applied.
    /// </summary>
    public sealed partial class OutputsResponse
    {
        /// <summary>
        /// The list of renditions generated from the source file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("renditions")]
        public global::System.Collections.Generic.IList<global::G.RenditionResponseAttributes>? Renditions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputsResponse" /> class.
        /// </summary>
        /// <param name="renditions">
        /// The list of renditions generated from the source file.
        /// </param>
        public OutputsResponse(
            global::System.Collections.Generic.IList<global::G.RenditionResponseAttributes>? renditions)
        {
            this.Renditions = renditions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputsResponse" /> class.
        /// </summary>
        public OutputsResponse()
        {
        }
    }
}