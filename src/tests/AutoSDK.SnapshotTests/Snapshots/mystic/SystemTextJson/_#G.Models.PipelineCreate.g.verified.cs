//HintName: G.Models.PipelineCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class PipelineCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.IOVariable> InputVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.IOVariable> OutputVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accelerators")]
        public global::System.Collections.Generic.IList<global::G.Accelerator>? Accelerators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster")]
        public global::G.PipelineClusterConfig? Cluster { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scaling_config")]
        public string? ScalingConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public object? Extras { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineCreate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="image"></param>
        /// <param name="inputVariables"></param>
        /// <param name="outputVariables"></param>
        /// <param name="accelerators"></param>
        /// <param name="cluster"></param>
        /// <param name="scalingConfig"></param>
        /// <param name="description"></param>
        /// <param name="readme"></param>
        /// <param name="extras"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineCreate(
            string name,
            string image,
            global::System.Collections.Generic.IList<global::G.IOVariable> inputVariables,
            global::System.Collections.Generic.IList<global::G.IOVariable> outputVariables,
            global::System.Collections.Generic.IList<global::G.Accelerator>? accelerators,
            global::G.PipelineClusterConfig? cluster,
            string? scalingConfig,
            string? description,
            string? readme,
            object? extras)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.InputVariables = inputVariables ?? throw new global::System.ArgumentNullException(nameof(inputVariables));
            this.OutputVariables = outputVariables ?? throw new global::System.ArgumentNullException(nameof(outputVariables));
            this.Accelerators = accelerators;
            this.Cluster = cluster;
            this.ScalingConfig = scalingConfig;
            this.Description = description;
            this.Readme = readme;
            this.Extras = extras;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineCreate" /> class.
        /// </summary>
        public PipelineCreate()
        {
        }
    }
}