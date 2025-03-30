//HintName: G.Models.GetVoicesResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetVoicesResponseModel
    {
        /// <summary>
        /// A list of available voices.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.VoiceResponseModel> Voices { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesResponseModel" /> class.
        /// </summary>
        /// <param name="voices">
        /// A list of available voices.
        /// </param>
        public GetVoicesResponseModel(
            global::System.Collections.Generic.IList<global::G.VoiceResponseModel> voices)
        {
            this.Voices = voices ?? throw new global::System.ArgumentNullException(nameof(voices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesResponseModel" /> class.
        /// </summary>
        public GetVoicesResponseModel()
        {
        }
    }
}