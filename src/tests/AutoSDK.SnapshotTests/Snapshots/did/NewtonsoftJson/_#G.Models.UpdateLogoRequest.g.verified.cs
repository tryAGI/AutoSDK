//HintName: G.Models.UpdateLogoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateLogoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logo", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] Logo { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logoname", Required = global::Newtonsoft.Json.Required.Always)]
        public string Logoname { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top", Required = global::Newtonsoft.Json.Required.Always)]
        public string Top { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("left", Required = global::Newtonsoft.Json.Required.Always)]
        public string Left { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLogoRequest" /> class.
        /// </summary>
        /// <param name="logo"></param>
        /// <param name="logoname"></param>
        /// <param name="top"></param>
        /// <param name="left"></param>
        public UpdateLogoRequest(
            byte[] logo,
            string logoname,
            string top,
            string left)
        {
            this.Logo = logo ?? throw new global::System.ArgumentNullException(nameof(logo));
            this.Logoname = logoname ?? throw new global::System.ArgumentNullException(nameof(logoname));
            this.Top = top ?? throw new global::System.ArgumentNullException(nameof(top));
            this.Left = left ?? throw new global::System.ArgumentNullException(nameof(left));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLogoRequest" /> class.
        /// </summary>
        public UpdateLogoRequest()
        {
        }
    }
}