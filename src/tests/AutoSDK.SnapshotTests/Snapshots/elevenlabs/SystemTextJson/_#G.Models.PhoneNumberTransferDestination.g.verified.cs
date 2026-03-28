//HintName: G.Models.PhoneNumberTransferDestination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumberTransferDestination
    {
        /// <summary>
        /// Default Value: phone
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberTransferDestination" /> class.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="type">
        /// Default Value: phone
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumberTransferDestination(
            string phoneNumber,
            string? type)
        {
            this.Type = type;
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberTransferDestination" /> class.
        /// </summary>
        public PhoneNumberTransferDestination()
        {
        }
    }
}