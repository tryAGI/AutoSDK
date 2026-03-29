//HintName: G.Models.PhoneNumberSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumberSummary
    {
        /// <summary>
        /// The ID of the phone number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The phone number with country code included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Number { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberSummary" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the phone number.
        /// </param>
        /// <param name="number">
        /// The phone number with country code included.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumberSummary(
            string id,
            string number)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Number = number ?? throw new global::System.ArgumentNullException(nameof(number));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberSummary" /> class.
        /// </summary>
        public PhoneNumberSummary()
        {
        }
    }
}