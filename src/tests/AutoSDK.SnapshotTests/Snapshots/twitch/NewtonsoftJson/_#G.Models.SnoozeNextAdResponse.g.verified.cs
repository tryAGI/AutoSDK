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
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SnoozeNextAdResponseDataItem> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SnoozeNextAdResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains information about the channel’s snoozes and next upcoming ad after successfully snoozing.
        /// </param>
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