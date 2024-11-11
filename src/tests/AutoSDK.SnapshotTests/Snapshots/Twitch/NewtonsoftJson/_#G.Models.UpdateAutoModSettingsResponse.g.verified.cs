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
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AutoModSettings> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAutoModSettingsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of AutoMod settings. The list contains a single object that contains all the AutoMod settings.
        /// </param>
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