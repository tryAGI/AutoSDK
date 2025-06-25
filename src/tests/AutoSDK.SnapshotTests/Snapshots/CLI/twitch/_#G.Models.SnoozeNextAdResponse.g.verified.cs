﻿//HintName: G.Models.SnoozeNextAdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SnoozeNextAdResponse
    {
        /// <summary>
        /// A list that contains information about the channel’s snoozes and next upcoming ad after successfully snoozing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SnoozeNextAdResponseDataItem> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SnoozeNextAdResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains information about the channel’s snoozes and next upcoming ad after successfully snoozing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SnoozeNextAdResponse(
            global::System.Collections.Generic.IList<global::G.SnoozeNextAdResponseDataItem> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnoozeNextAdResponse" /> class.
        /// </summary>
        public SnoozeNextAdResponse()
        {
        }
    }
}