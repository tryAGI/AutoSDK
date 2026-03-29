//HintName: G.Models.PhoneNumberHookCallRinging.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumberHookCallRinging
    {
        /// <summary>
        /// This is the event to trigger the hook on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PhoneNumberHookCallRingingOnJsonConverter))]
        public global::G.PhoneNumberHookCallRingingOn On { get; set; }

        /// <summary>
        /// Optional filters to decide when to trigger the hook. Currently supports filtering by caller country code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::G.PhoneNumberCallRingingHookFilter>? Filters { get; set; }

        /// <summary>
        /// Only the first action will be executed. Additional actions will be ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OneOf<global::G.TransferPhoneNumberHookAction, global::G.SayPhoneNumberHookAction>> Do { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberHookCallRinging" /> class.
        /// </summary>
        /// <param name="do">
        /// Only the first action will be executed. Additional actions will be ignored.
        /// </param>
        /// <param name="on">
        /// This is the event to trigger the hook on
        /// </param>
        /// <param name="filters">
        /// Optional filters to decide when to trigger the hook. Currently supports filtering by caller country code.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumberHookCallRinging(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.TransferPhoneNumberHookAction, global::G.SayPhoneNumberHookAction>> @do,
            global::G.PhoneNumberHookCallRingingOn on,
            global::System.Collections.Generic.IList<global::G.PhoneNumberCallRingingHookFilter>? filters)
        {
            this.On = on;
            this.Filters = filters;
            this.Do = @do ?? throw new global::System.ArgumentNullException(nameof(@do));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberHookCallRinging" /> class.
        /// </summary>
        public PhoneNumberHookCallRinging()
        {
        }
    }
}