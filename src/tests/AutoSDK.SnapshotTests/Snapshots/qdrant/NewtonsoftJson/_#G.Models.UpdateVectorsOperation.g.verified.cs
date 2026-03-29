//HintName: G.Models.UpdateVectorsOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateVectorsOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("update_vectors", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UpdateVectors UpdateVectors { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVectorsOperation" /> class.
        /// </summary>
        /// <param name="updateVectors"></param>
        public UpdateVectorsOperation(
            global::G.UpdateVectors updateVectors)
        {
            this.UpdateVectors = updateVectors ?? throw new global::System.ArgumentNullException(nameof(updateVectors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVectorsOperation" /> class.
        /// </summary>
        public UpdateVectorsOperation()
        {
        }
    }
}