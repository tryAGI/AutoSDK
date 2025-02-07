//HintName: G.Models.ScalingConfigCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class ScalingConfigCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimum_nodes")]
        public int? MinimumNodes { get; set; }

        /// <summary>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum_nodes")]
        public int? MaximumNodes { get; set; }

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ScalingConfigTypeJsonConverter))]
        public global::G.ScalingConfigType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Args { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScalingConfigCreate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="minimumNodes">
        /// Default Value: 0
        /// </param>
        /// <param name="maximumNodes">
        /// Default Value: 100
        /// </param>
        /// <param name="type">
        /// An enumeration.
        /// </param>
        /// <param name="args"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScalingConfigCreate(
            string name,
            object args,
            int? minimumNodes,
            int? maximumNodes,
            global::G.ScalingConfigType type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
            this.MinimumNodes = minimumNodes;
            this.MaximumNodes = maximumNodes;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScalingConfigCreate" /> class.
        /// </summary>
        public ScalingConfigCreate()
        {
        }
    }
}