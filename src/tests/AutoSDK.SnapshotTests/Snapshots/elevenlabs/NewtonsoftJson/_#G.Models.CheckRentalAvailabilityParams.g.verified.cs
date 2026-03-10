//HintName: G.Models.CheckRentalAvailabilityParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckRentalAvailabilityParams
    {
        /// <summary>
        /// Default Value: check_rental_availability
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckRentalAvailabilityParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: check_rental_availability
        /// </param>
        public CheckRentalAvailabilityParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckRentalAvailabilityParams" /> class.
        /// </summary>
        public CheckRentalAvailabilityParams()
        {
        }
    }
}