//HintName: G.Models.UpdateUserExtensionsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateUserExtensionsResponse
    {
        /// <summary>
        /// The extensions that the broadcaster updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UpdateUserExtensionsResponseData Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserExtensionsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The extensions that the broadcaster updated.
        /// </param>
        public UpdateUserExtensionsResponse(
            global::G.UpdateUserExtensionsResponseData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserExtensionsResponse" /> class.
        /// </summary>
        public UpdateUserExtensionsResponse()
        {
        }
    }
}