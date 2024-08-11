//HintName: G.Models.CheermoteTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheermoteTier
    {
        /// <summary>
        /// The minimum number of Bits that you must cheer at this tier level. The maximum number of Bits that you can cheer at this level is determined by the required minimum Bits of the next tier level minus 1\. For example, if `min_bits` is 1 and `min_bits` for the next tier is 100, the Bits range for this tier level is 1 through 99\. The minimum Bits value of the last tier is the maximum number of Bits you can cheer using this Cheermote. For example, 10000.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_bits", Required = global::Newtonsoft.Json.Required.Always)]
        public int MinBits { get; set; } = default!;

        /// <summary>
        /// The tier level. Possible tiers are:  <br/>
        ///   <br/>
        /// * 1<br/>
        /// * 100<br/>
        /// * 500<br/>
        /// * 1000<br/>
        /// * 5000<br/>
        /// * 10000<br/>
        /// * 100000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CheermoteTierId Id { get; set; } = default!;

        /// <summary>
        /// The hex code of the color associated with this tier level (for example, #979797).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("color", Required = global::Newtonsoft.Json.Required.Always)]
        public string Color { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("images", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CheermoteImages? Images { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether users can cheer at this tier level.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_cheer", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanCheer { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether this tier level is shown in the Bits card. Is **true** if this tier level is shown in the Bits card.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_in_bits_card", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ShowInBitsCard { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}