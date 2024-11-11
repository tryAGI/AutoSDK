//HintName: G.Models.UpdateRedemptionStatusBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateRedemptionStatusBody
    {
        /// <summary>
        /// The status to set the redemption to. Possible values are:  <br/>
        ///   <br/>
        /// * CANCELED<br/>
        /// * FULFILLED<br/>
        ///   <br/>
        /// Setting the status to CANCELED refunds the user’s channel points.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UpdateRedemptionStatusBodyStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRedemptionStatusBody" /> class.
        /// </summary>
        /// <param name="status">
        /// The status to set the redemption to. Possible values are:  <br/>
        ///   <br/>
        /// * CANCELED<br/>
        /// * FULFILLED<br/>
        ///   <br/>
        /// Setting the status to CANCELED refunds the user’s channel points.
        /// </param>
        public UpdateRedemptionStatusBody(
            global::G.UpdateRedemptionStatusBodyStatus status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRedemptionStatusBody" /> class.
        /// </summary>
        public UpdateRedemptionStatusBody()
        {
        }
    }
}