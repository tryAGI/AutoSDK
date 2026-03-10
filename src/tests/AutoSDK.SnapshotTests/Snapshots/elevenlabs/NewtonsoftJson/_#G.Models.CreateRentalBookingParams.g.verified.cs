//HintName: G.Models.CreateRentalBookingParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRentalBookingParams
    {
        /// <summary>
        /// Default Value: create_rental_booking
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRentalBookingParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: create_rental_booking
        /// </param>
        public CreateRentalBookingParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRentalBookingParams" /> class.
        /// </summary>
        public CreateRentalBookingParams()
        {
        }
    }
}