//HintName: G.Models.OpenGetBotData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenGetBotData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::G.BotSimpleInfo>? Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenGetBotData" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="total"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenGetBotData(
            global::System.Collections.Generic.IList<global::G.BotSimpleInfo>? items,
            int? total)
        {
            this.Items = items;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenGetBotData" /> class.
        /// </summary>
        public OpenGetBotData()
        {
        }
    }
}