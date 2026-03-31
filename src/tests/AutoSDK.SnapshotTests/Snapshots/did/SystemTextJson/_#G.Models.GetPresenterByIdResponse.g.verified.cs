//HintName: G.Models.GetPresenterByIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPresenterByIdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presenters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetPresenterByIdResponsePresenter> Presenters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPresenterByIdResponse" /> class.
        /// </summary>
        /// <param name="presenters"></param>
        /// <param name="token"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPresenterByIdResponse(
            global::System.Collections.Generic.IList<global::G.GetPresenterByIdResponsePresenter> presenters,
            string? token)
        {
            this.Presenters = presenters ?? throw new global::System.ArgumentNullException(nameof(presenters));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPresenterByIdResponse" /> class.
        /// </summary>
        public GetPresenterByIdResponse()
        {
        }
    }
}