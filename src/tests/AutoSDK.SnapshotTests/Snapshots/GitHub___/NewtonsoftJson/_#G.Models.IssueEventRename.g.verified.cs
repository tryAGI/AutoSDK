//HintName: G.Models.IssueEventRename.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Issue Event Rename
    /// </summary>
    public sealed partial class IssueEventRename
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from", Required = global::Newtonsoft.Json.Required.Always)]
        public string From { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to", Required = global::Newtonsoft.Json.Required.Always)]
        public string To { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueEventRename" /> class.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public IssueEventRename(
            string from,
            string to)
        {
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueEventRename" /> class.
        /// </summary>
        public IssueEventRename()
        {
        }
    }
}