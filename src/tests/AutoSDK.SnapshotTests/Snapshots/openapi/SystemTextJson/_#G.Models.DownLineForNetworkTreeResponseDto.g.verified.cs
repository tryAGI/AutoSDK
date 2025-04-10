//HintName: G.Models.DownLineForNetworkTreeResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DownLineForNetworkTreeResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public global::G.DownLineForNetworkTreeItemDto? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        public global::G.DownLineForNetworkTreeItemDto? Left { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right")]
        public global::G.DownLineForNetworkTreeItemDto? Right { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leftLeft")]
        public global::G.DownLineForNetworkTreeItemDto? LeftLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leftRight")]
        public global::G.DownLineForNetworkTreeItemDto? LeftRight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rightLeft")]
        public global::G.DownLineForNetworkTreeItemDto? RightLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rightRight")]
        public global::G.DownLineForNetworkTreeItemDto? RightRight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DownLineForNetworkTreeResponseDto" /> class.
        /// </summary>
        /// <param name="seed"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="leftLeft"></param>
        /// <param name="leftRight"></param>
        /// <param name="rightLeft"></param>
        /// <param name="rightRight"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DownLineForNetworkTreeResponseDto(
            global::G.DownLineForNetworkTreeItemDto? seed,
            global::G.DownLineForNetworkTreeItemDto? left,
            global::G.DownLineForNetworkTreeItemDto? right,
            global::G.DownLineForNetworkTreeItemDto? leftLeft,
            global::G.DownLineForNetworkTreeItemDto? leftRight,
            global::G.DownLineForNetworkTreeItemDto? rightLeft,
            global::G.DownLineForNetworkTreeItemDto? rightRight)
        {
            this.Seed = seed;
            this.Left = left;
            this.Right = right;
            this.LeftLeft = leftLeft;
            this.LeftRight = leftRight;
            this.RightLeft = rightLeft;
            this.RightRight = rightRight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DownLineForNetworkTreeResponseDto" /> class.
        /// </summary>
        public DownLineForNetworkTreeResponseDto()
        {
        }
    }
}