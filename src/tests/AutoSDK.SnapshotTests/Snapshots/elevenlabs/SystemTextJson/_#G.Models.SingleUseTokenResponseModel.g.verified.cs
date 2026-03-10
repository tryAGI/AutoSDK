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
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleUseTokenResponseModel" /> class.
        /// </summary>
        /// <param name="token">
        /// A time bound single use token that expires after 15 minutes. Will be consumed on use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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