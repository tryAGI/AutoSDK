//HintName: G.Models.DataPointNumberPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataPointNumberPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Time { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPointNumberPublic" /> class.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="value"></param>
        public DataPointNumberPublic(
            global::System.DateTime time,
            double? value)
        {
            this.Time = time;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPointNumberPublic" /> class.
        /// </summary>
        public DataPointNumberPublic()
        {
        }
    }
}