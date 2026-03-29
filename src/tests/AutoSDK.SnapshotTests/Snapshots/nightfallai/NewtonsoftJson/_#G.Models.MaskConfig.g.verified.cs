//HintName: G.Models.MaskConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MaskConfig
    {
        /// <summary>
        /// Default Value: *
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maskingChar")]
        public string? MaskingChar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("charsToIgnore")]
        public global::System.Collections.Generic.IList<string>? CharsToIgnore { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numCharsToLeaveUnmasked")]
        public int? NumCharsToLeaveUnmasked { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maskLeftToRight")]
        public bool? MaskLeftToRight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MaskConfig" /> class.
        /// </summary>
        /// <param name="maskingChar">
        /// Default Value: *
        /// </param>
        /// <param name="charsToIgnore"></param>
        /// <param name="numCharsToLeaveUnmasked">
        /// Default Value: 0
        /// </param>
        /// <param name="maskLeftToRight">
        /// Default Value: false
        /// </param>
        public MaskConfig(
            string? maskingChar,
            global::System.Collections.Generic.IList<string>? charsToIgnore,
            int? numCharsToLeaveUnmasked,
            bool? maskLeftToRight)
        {
            this.MaskingChar = maskingChar;
            this.CharsToIgnore = charsToIgnore;
            this.NumCharsToLeaveUnmasked = numCharsToLeaveUnmasked;
            this.MaskLeftToRight = maskLeftToRight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaskConfig" /> class.
        /// </summary>
        public MaskConfig()
        {
        }
    }
}