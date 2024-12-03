//HintName: G.Models.GetUserExtensionsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUserExtensionsResponse
    {
        /// <summary>
        /// The list of extensions that the user has installed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.UserExtension> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserExtensionsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of extensions that the user has installed.
        /// </param>
        public GetUserExtensionsResponse(
            global::System.Collections.Generic.IList<global::G.UserExtension> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserExtensionsResponse" /> class.
        /// </summary>
        public GetUserExtensionsResponse()
        {
        }
    }
}