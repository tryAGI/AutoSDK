//HintName: G.Models.PhoneNumberCallRingingHookFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumberCallRingingHookFilter
    {
        /// <summary>
        /// This is the type of filter - matches when the specified field starts with any of the given prefixes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PhoneNumberCallRingingHookFilterTypeJsonConverter))]
        public global::G.PhoneNumberCallRingingHookFilterType Type { get; set; }

        /// <summary>
        /// The field to check. Currently only "number" (the caller's phone number) is supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PhoneNumberCallRingingHookFilterKeyJsonConverter))]
        public global::G.PhoneNumberCallRingingHookFilterKey Key { get; set; }

        /// <summary>
        /// Array of prefixes to match. Do not include the + prefix. Inbound calls from numbers starting with any of these prefixes will trigger the hook actions.<br/>
        /// Example: [7, 86, 91]
        /// </summary>
        /// <example>[7, 86, 91]</example>
        [global::Newtonsoft.Json.JsonProperty("startsWith", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> StartsWith { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberCallRingingHookFilter" /> class.
        /// </summary>
        /// <param name="startsWith">
        /// Array of prefixes to match. Do not include the + prefix. Inbound calls from numbers starting with any of these prefixes will trigger the hook actions.<br/>
        /// Example: [7, 86, 91]
        /// </param>
        /// <param name="type">
        /// This is the type of filter - matches when the specified field starts with any of the given prefixes
        /// </param>
        /// <param name="key">
        /// The field to check. Currently only "number" (the caller's phone number) is supported.
        /// </param>
        public PhoneNumberCallRingingHookFilter(
            global::System.Collections.Generic.IList<string> startsWith,
            global::G.PhoneNumberCallRingingHookFilterType type,
            global::G.PhoneNumberCallRingingHookFilterKey key)
        {
            this.Type = type;
            this.Key = key;
            this.StartsWith = startsWith ?? throw new global::System.ArgumentNullException(nameof(startsWith));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberCallRingingHookFilter" /> class.
        /// </summary>
        public PhoneNumberCallRingingHookFilter()
        {
        }
    }
}