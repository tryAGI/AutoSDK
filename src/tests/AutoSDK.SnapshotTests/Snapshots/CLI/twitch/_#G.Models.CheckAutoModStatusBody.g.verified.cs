//HintName: G.Models.CheckAutoModStatusBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckAutoModStatusBody
    {
        /// <summary>
        /// The list of messages to check. The list must contain at least one message and may contain up to a maximum of 100 messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CheckAutoModStatusBodyDataItem> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAutoModStatusBody" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of messages to check. The list must contain at least one message and may contain up to a maximum of 100 messages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckAutoModStatusBody(
            global::System.Collections.Generic.IList<global::G.CheckAutoModStatusBodyDataItem> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAutoModStatusBody" /> class.
        /// </summary>
        public CheckAutoModStatusBody()
        {
        }
    }
}