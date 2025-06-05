//HintName: G.Models.UsageOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("months", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.UsageMonth> Months { get; set; } = default!;

        /// <summary>
        /// The first month for this account
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initial_month", Required = global::Newtonsoft.Json.Required.Always)]
        public string InitialMonth { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageOut" /> class.
        /// </summary>
        /// <param name="months"></param>
        /// <param name="initialMonth">
        /// The first month for this account
        /// </param>
        public UsageOut(
            global::System.Collections.Generic.IList<global::G.UsageMonth> months,
            string initialMonth)
        {
            this.Months = months ?? throw new global::System.ArgumentNullException(nameof(months));
            this.InitialMonth = initialMonth ?? throw new global::System.ArgumentNullException(nameof(initialMonth));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageOut" /> class.
        /// </summary>
        public UsageOut()
        {
        }
    }
}