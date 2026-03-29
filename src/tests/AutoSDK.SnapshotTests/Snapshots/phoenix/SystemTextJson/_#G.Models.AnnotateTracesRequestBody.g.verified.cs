//HintName: G.Models.AnnotateTracesRequestBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnnotateTracesRequestBody
    {
        /// <summary>
        /// The trace annotations to be upserted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TraceAnnotationData> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotateTracesRequestBody" /> class.
        /// </summary>
        /// <param name="data">
        /// The trace annotations to be upserted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotateTracesRequestBody(
            global::System.Collections.Generic.IList<global::G.TraceAnnotationData> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotateTracesRequestBody" /> class.
        /// </summary>
        public AnnotateTracesRequestBody()
        {
        }
    }
}