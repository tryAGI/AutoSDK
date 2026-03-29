//HintName: G.Models.DeleteOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PointsSelectorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PointsSelector Delete { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteOperation" /> class.
        /// </summary>
        /// <param name="delete"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteOperation(
            global::G.PointsSelector delete)
        {
            this.Delete = delete;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteOperation" /> class.
        /// </summary>
        public DeleteOperation()
        {
        }
    }
}