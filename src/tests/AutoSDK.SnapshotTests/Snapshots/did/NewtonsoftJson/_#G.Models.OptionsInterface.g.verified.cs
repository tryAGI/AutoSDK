//HintName: G.Models.OptionsInterface.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OptionsInterface
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom")]
        public global::G.OptionsInterfaceCustom? Custom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsInterface" /> class.
        /// </summary>
        /// <param name="temperature"></param>
        /// <param name="custom"></param>
        public OptionsInterface(
            double? temperature,
            global::G.OptionsInterfaceCustom? custom)
        {
            this.Temperature = temperature;
            this.Custom = custom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsInterface" /> class.
        /// </summary>
        public OptionsInterface()
        {
        }
    }
}