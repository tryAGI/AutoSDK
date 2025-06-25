//HintName: G.Models.UpdateAutoModSettingsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAutoModSettingsResponse
    {
        /// <summary>
        /// The list of AutoMod settings. The list contains a single object that contains all the AutoMod settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AutoModSettings> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAutoModSettingsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of AutoMod settings. The list contains a single object that contains all the AutoMod settings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAutoModSettingsResponse(
            global::System.Collections.Generic.IList<global::G.AutoModSettings> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAutoModSettingsResponse" /> class.
        /// </summary>
        public UpdateAutoModSettingsResponse()
        {
        }
    }
}