//HintName: G.Models.VisionFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that uses Palmyra Vision to analyze images and documents. Supports JPG, PNG, PDF, and TXT files up to 7MB each.
    /// </summary>
    public sealed partial class VisionFunction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.VisionToolRequestFileVariable> Variables { get; set; }

        /// <summary>
        /// The model to use for image analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VisionFunctionModelJsonConverter))]
        public global::G.VisionFunctionModel Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionFunction" /> class.
        /// </summary>
        /// <param name="variables"></param>
        /// <param name="model">
        /// The model to use for image analysis.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisionFunction(
            global::System.Collections.Generic.IList<global::G.VisionToolRequestFileVariable> variables,
            global::G.VisionFunctionModel model)
        {
            this.Variables = variables ?? throw new global::System.ArgumentNullException(nameof(variables));
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisionFunction" /> class.
        /// </summary>
        public VisionFunction()
        {
        }
    }
}