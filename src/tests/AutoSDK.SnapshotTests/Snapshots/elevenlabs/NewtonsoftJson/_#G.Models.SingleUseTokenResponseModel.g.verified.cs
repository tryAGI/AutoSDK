//HintName: G.Models.SingleUseTokenResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"token":"sutkn_1234567890"}
    /// </summary>
    public sealed partial class SingleUseTokenResponseModel
    {
        /// <summary>
        /// A time bound single use token that expires after 15 minutes. Will be consumed on use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleUseTokenResponseModel" /> class.
        /// </summary>
        /// <param name="token">
        /// A time bound single use token that expires after 15 minutes. Will be consumed on use.
        /// </param>
        public SingleUseTokenResponseModel(
            string token)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleUseTokenResponseModel" /> class.
        /// </summary>
        public SingleUseTokenResponseModel()
        {
        }
    }
}