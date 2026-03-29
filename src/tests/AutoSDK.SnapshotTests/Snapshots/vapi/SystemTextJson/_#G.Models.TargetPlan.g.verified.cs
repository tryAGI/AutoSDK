//HintName: G.Models.TargetPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TargetPlan
    {
        /// <summary>
        /// This is the phone number that is being tested.<br/>
        /// During the actual test, it'll be called and the assistant attached to it will pick up and be tested.<br/>
        /// To test an assistant directly, send assistantId instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumberId")]
        public string? PhoneNumberId { get; set; }

        /// <summary>
        /// This can be any phone number (even not on Vapi).<br/>
        /// During the actual test, it'll be called.<br/>
        /// To test a Vapi number, send phoneNumberId. To test an assistant directly, send assistantId instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
        public global::G.TestSuitePhoneNumber? PhoneNumber { get; set; }

        /// <summary>
        /// This is the assistant being tested.<br/>
        /// During the actual test, it'll invoked directly.<br/>
        /// To test the assistant over phone number, send phoneNumberId instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// This is the assistant overrides applied to assistantId before it is tested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantOverrides")]
        public global::G.AssistantOverrides? AssistantOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TargetPlan" /> class.
        /// </summary>
        /// <param name="phoneNumberId">
        /// This is the phone number that is being tested.<br/>
        /// During the actual test, it'll be called and the assistant attached to it will pick up and be tested.<br/>
        /// To test an assistant directly, send assistantId instead.
        /// </param>
        /// <param name="phoneNumber">
        /// This can be any phone number (even not on Vapi).<br/>
        /// During the actual test, it'll be called.<br/>
        /// To test a Vapi number, send phoneNumberId. To test an assistant directly, send assistantId instead.
        /// </param>
        /// <param name="assistantId">
        /// This is the assistant being tested.<br/>
        /// During the actual test, it'll invoked directly.<br/>
        /// To test the assistant over phone number, send phoneNumberId instead.
        /// </param>
        /// <param name="assistantOverrides">
        /// This is the assistant overrides applied to assistantId before it is tested.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TargetPlan(
            string? phoneNumberId,
            global::G.TestSuitePhoneNumber? phoneNumber,
            string? assistantId,
            global::G.AssistantOverrides? assistantOverrides)
        {
            this.PhoneNumberId = phoneNumberId;
            this.PhoneNumber = phoneNumber;
            this.AssistantId = assistantId;
            this.AssistantOverrides = assistantOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TargetPlan" /> class.
        /// </summary>
        public TargetPlan()
        {
        }
    }
}