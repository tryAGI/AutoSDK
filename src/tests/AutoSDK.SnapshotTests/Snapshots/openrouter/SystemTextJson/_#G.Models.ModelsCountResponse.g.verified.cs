//HintName: G.Models.ModelsCountResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model count data
    /// </summary>
    public sealed partial class ModelsCountResponse
    {
        /// <summary>
        /// Model count data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModelsCountResponseData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsCountResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Model count data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsCountResponse(
            global::G.ModelsCountResponseData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsCountResponse" /> class.
        /// </summary>
        public ModelsCountResponse()
        {
        }
    }
}