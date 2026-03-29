//HintName: G.Models.InterruptRequireInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InterruptRequireInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("infos")]
        public global::System.Collections.Generic.IList<string>? Infos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InterruptRequireInfo" /> class.
        /// </summary>
        /// <param name="infos"></param>
        public InterruptRequireInfo(
            global::System.Collections.Generic.IList<string>? infos)
        {
            this.Infos = infos;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InterruptRequireInfo" /> class.
        /// </summary>
        public InterruptRequireInfo()
        {
        }
    }
}