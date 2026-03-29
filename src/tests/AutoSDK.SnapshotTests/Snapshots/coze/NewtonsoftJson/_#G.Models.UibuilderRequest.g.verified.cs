//HintName: G.Models.UibuilderRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UibuilderRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("appId", Required = global::Newtonsoft.Json.Required.Always)]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("container")]
        public string? Container { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ui")]
        public global::G.UibuilderRequestUi? Ui { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userInfo")]
        public global::G.UibuilderRequestUserInfo? UserInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UibuilderRequest" /> class.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="token"></param>
        /// <param name="container"></param>
        /// <param name="ui"></param>
        /// <param name="userInfo"></param>
        public UibuilderRequest(
            string appId,
            string token,
            string? container,
            global::G.UibuilderRequestUi? ui,
            global::G.UibuilderRequestUserInfo? userInfo)
        {
            this.AppId = appId ?? throw new global::System.ArgumentNullException(nameof(appId));
            this.Container = container;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Ui = ui;
            this.UserInfo = userInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UibuilderRequest" /> class.
        /// </summary>
        public UibuilderRequest()
        {
        }
    }
}