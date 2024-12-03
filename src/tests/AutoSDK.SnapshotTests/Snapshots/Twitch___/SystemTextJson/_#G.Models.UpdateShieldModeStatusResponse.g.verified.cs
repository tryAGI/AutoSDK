//HintName: G.Models.UpdateShieldModeStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateShieldModeStatusResponse
    {
        /// <summary>
        /// A list that contains a single object with the broadcaster’s updated Shield Mode status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.UpdateShieldModeStatusResponseDataItem> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateShieldModeStatusResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains a single object with the broadcaster’s updated Shield Mode status.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateShieldModeStatusResponse(
            global::System.Collections.Generic.IList<global::G.UpdateShieldModeStatusResponseDataItem> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateShieldModeStatusResponse" /> class.
        /// </summary>
        public UpdateShieldModeStatusResponse()
        {
        }
    }
}