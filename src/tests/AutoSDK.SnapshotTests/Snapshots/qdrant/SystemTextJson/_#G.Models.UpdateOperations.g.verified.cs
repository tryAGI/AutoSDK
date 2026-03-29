//HintName: G.Models.UpdateOperations.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateOperations
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.UpdateOperation> Operations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOperations" /> class.
        /// </summary>
        /// <param name="operations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateOperations(
            global::System.Collections.Generic.IList<global::G.UpdateOperation> operations)
        {
            this.Operations = operations ?? throw new global::System.ArgumentNullException(nameof(operations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOperations" /> class.
        /// </summary>
        public UpdateOperations()
        {
        }
    }
}