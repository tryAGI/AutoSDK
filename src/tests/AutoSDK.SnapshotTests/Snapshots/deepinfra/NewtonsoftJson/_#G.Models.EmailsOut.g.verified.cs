//HintName: G.Models.EmailsOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmailsOut
    {
        /// <summary>
        /// List of emails verified by theauthenticaiton provider
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emails", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Emails { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailsOut" /> class.
        /// </summary>
        /// <param name="emails">
        /// List of emails verified by theauthenticaiton provider
        /// </param>
        public EmailsOut(
            global::System.Collections.Generic.IList<string> emails)
        {
            this.Emails = emails ?? throw new global::System.ArgumentNullException(nameof(emails));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailsOut" /> class.
        /// </summary>
        public EmailsOut()
        {
        }
    }
}