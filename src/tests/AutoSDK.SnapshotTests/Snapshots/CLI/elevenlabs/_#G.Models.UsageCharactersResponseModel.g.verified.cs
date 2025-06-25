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
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Time { get; set; }

        /// <summary>
        /// The usage of each breakdown type along the time axis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<double>> Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageCharactersResponseModel(
            global::System.Collections.Generic.IList<int> time,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<double>> usage)
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