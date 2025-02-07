//HintName: G.Models.UnarchiveFTModelOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnarchiveFTModelOut
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnarchiveFTModelOutObjectJsonConverter))]
        public global::G.UnarchiveFTModelOutObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnarchiveFTModelOut" /> class.
        /// </summary>
        /// <param name="archived">
        /// Default Value: false
        /// </param>
        /// <param name="id"></param>
        /// <param name="object">
        /// Default Value: model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnarchiveFTModelOut(
            string id,
            bool? archived,
            global::G.UnarchiveFTModelOutObject? @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Archived = archived;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnarchiveFTModelOut" /> class.
        /// </summary>
        public UnarchiveFTModelOut()
        {
        }
    }
}