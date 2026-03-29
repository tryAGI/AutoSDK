//HintName: G.Models.CallFilterDataStorageSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter by data storage setting.
    /// </summary>
    public sealed partial class CallFilterDataStorageSetting
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::System.Collections.Generic.IList<global::G.CallFilterDataStorageSettingValueItem>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallFilterDataStorageSetting" /> class.
        /// </summary>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallFilterDataStorageSetting(
            global::System.Collections.Generic.IList<global::G.CallFilterDataStorageSettingValueItem>? value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallFilterDataStorageSetting" /> class.
        /// </summary>
        public CallFilterDataStorageSetting()
        {
        }
    }
}