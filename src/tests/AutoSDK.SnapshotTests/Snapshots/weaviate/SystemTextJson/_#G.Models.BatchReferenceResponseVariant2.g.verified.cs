//HintName: G.Models.BatchReferenceResponseVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchReferenceResponseVariant2
    {
        /// <summary>
        /// Results for this specific reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::G.BatchReferenceResponseVariant2Result? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchReferenceResponseVariant2" /> class.
        /// </summary>
        /// <param name="result">
        /// Results for this specific reference.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BatchReferenceResponseVariant2(
            global::G.BatchReferenceResponseVariant2Result? result)
        {
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchReferenceResponseVariant2" /> class.
        /// </summary>
        public BatchReferenceResponseVariant2()
        {
        }
    }
}