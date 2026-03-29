//HintName: G.Models.ModelsListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List of available models
    /// </summary>
    public sealed partial class ModelsListResponse
    {
        /// <summary>
        /// List of available models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Model> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of available models
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsListResponse(
            global::System.Collections.Generic.IList<global::G.Model> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsListResponse" /> class.
        /// </summary>
        public ModelsListResponse()
        {
        }
    }
}