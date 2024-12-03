//HintName: G.Models.NodePoolCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class NodePoolCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accelerators")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Accelerator> Accelerators { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spot")]
        public bool? Spot { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodePoolCreate" /> class.
        /// </summary>
        /// <param name="accelerators"></param>
        /// <param name="spot">
        /// Default Value: true
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public NodePoolCreate(
            global::System.Collections.Generic.IList<global::G.Accelerator> accelerators,
            bool? spot)
        {
            this.Accelerators = accelerators ?? throw new global::System.ArgumentNullException(nameof(accelerators));
            this.Spot = spot;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodePoolCreate" /> class.
        /// </summary>
        public NodePoolCreate()
        {
        }
    }
}