//HintName: G.Models.EmailFileRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmailFileRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileURI", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileURI { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attachmentFileName", Required = global::Newtonsoft.Json.Required.Always)]
        public string AttachmentFileName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emailAddress", Required = global::Newtonsoft.Json.Required.Always)]
        public string EmailAddress { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subject", Required = global::Newtonsoft.Json.Required.Always)]
        public string Subject { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailFileRequest" /> class.
        /// </summary>
        /// <param name="fileURI"></param>
        /// <param name="attachmentFileName"></param>
        /// <param name="emailAddress"></param>
        /// <param name="subject"></param>
        public EmailFileRequest(
            string fileURI,
            string attachmentFileName,
            string emailAddress,
            string subject)
        {
            this.FileURI = fileURI ?? throw new global::System.ArgumentNullException(nameof(fileURI));
            this.AttachmentFileName = attachmentFileName ?? throw new global::System.ArgumentNullException(nameof(attachmentFileName));
            this.EmailAddress = emailAddress ?? throw new global::System.ArgumentNullException(nameof(emailAddress));
            this.Subject = subject ?? throw new global::System.ArgumentNullException(nameof(subject));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailFileRequest" /> class.
        /// </summary>
        public EmailFileRequest()
        {
        }
    }
}