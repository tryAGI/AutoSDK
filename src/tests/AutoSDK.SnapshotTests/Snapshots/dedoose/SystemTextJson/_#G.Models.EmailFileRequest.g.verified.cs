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
        [global::System.Text.Json.Serialization.JsonPropertyName("fileURI")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileURI { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachmentFileName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AttachmentFileName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emailAddress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmailAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Subject { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailFileRequest" /> class.
        /// </summary>
        /// <param name="fileURI"></param>
        /// <param name="attachmentFileName"></param>
        /// <param name="emailAddress"></param>
        /// <param name="subject"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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