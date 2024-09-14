//HintName: G.Models.Cheermote.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Cheermote
    {
        /// <summary>
        /// The name portion of the Cheermote string that you use in chat to cheer Bits. The full Cheermote string is the concatenation of {prefix} + {number of Bits}. For example, if the prefix is “Cheer” and you want to cheer 100 Bits, the full Cheermote string is Cheer100\. When the Cheermote string is entered in chat, Twitch converts it to the image associated with the Bits tier that was cheered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prefix { get; set; }

        /// <summary>
        /// A list of tier levels that the Cheermote supports. Each tier identifies the range of Bits that you can cheer at that tier level and an image that graphically identifies the tier level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tiers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CheermoteTier> Tiers { get; set; }

        /// <summary>
        /// The type of Cheermote. Possible values are:  <br/>
        ///   <br/>
        /// * global\_first\_party — A Twitch-defined Cheermote that is shown in the Bits card.<br/>
        /// * global\_third\_party — A Twitch-defined Cheermote that is not shown in the Bits card.<br/>
        /// * channel\_custom — A broadcaster-defined Cheermote.<br/>
        /// * display\_only — Do not use; for internal use only.<br/>
        /// * sponsored — A sponsor-defined Cheermote. When used, the sponsor adds additional Bits to the amount that the user cheered. For example, if the user cheered Terminator100, the broadcaster might receive 110 Bits, which includes the sponsor's 10 Bits contribution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CheermoteTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CheermoteType Type { get; set; }

        /// <summary>
        /// The order that the Cheermotes are shown in the Bits card. The numbers may not be consecutive. For example, the numbers may jump from 1 to 7 to 13\. The order numbers are unique within a Cheermote type (for example, global\_first\_party) but may not be unique amongst all Cheermotes in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Order { get; set; }

        /// <summary>
        /// The date and time, in RFC3339 format, when this Cheermote was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastUpdated { get; set; }

        /// <summary>
        /// A Boolean value that indicates whether this Cheermote provides a charitable contribution match during charity campaigns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_charitable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsCharitable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}