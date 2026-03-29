//HintName: G.Models.UpdateAlertBannerActiveRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAlertBannerActiveRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Active { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public double Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAlertBannerActiveRequest" /> class.
        /// </summary>
        /// <param name="active"></param>
        /// <param name="id"></param>
        public UpdateAlertBannerActiveRequest(
            bool active,
            double id)
        {
            this.Active = active;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAlertBannerActiveRequest" /> class.
        /// </summary>
        public UpdateAlertBannerActiveRequest()
        {
        }
    }
}