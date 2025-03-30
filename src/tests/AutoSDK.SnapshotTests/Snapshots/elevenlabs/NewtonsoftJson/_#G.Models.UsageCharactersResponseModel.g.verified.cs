//HintName: G.Models.UsageCharactersResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageCharactersResponseModel
    {
        /// <summary>
        /// The time axis with unix timestamps for each day.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> Time { get; set; } = default!;

        /// <summary>
        /// The usage of each breakdown type along the time axis.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<int>> Usage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageCharactersResponseModel" /> class.
        /// </summary>
        /// <param name="time">
        /// The time axis with unix timestamps for each day.
        /// </param>
        /// <param name="usage">
        /// The usage of each breakdown type along the time axis.
        /// </param>
        public UsageCharactersResponseModel(
            global::System.Collections.Generic.IList<int> time,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<int>> usage)
        {
            this.Time = time ?? throw new global::System.ArgumentNullException(nameof(time));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageCharactersResponseModel" /> class.
        /// </summary>
        public UsageCharactersResponseModel()
        {
        }
    }
}