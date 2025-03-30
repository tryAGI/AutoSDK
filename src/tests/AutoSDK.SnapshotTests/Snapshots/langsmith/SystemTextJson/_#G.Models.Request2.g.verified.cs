//HintName: G.Models.Request2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request2
    {
        /// <summary>
        /// The Example update info as JSON. Can have fields 'metadata', 'split'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("{example_id}")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] x_exampleId_ { get; set; }

        /// <summary>
        /// The Example update info as JSON. Can have fields 'metadata', 'split'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("{example_id}name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string x_exampleId_name { get; set; }

        /// <summary>
        /// The updated Example inputs as JSON
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("{example_id}.inputs")]
        public byte[]? x_exampleId_Inputs { get; set; }

        /// <summary>
        /// The updated Example inputs as JSON
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("{example_id}.inputsname")]
        public string? x_exampleId_Inputsname { get; set; }

        /// <summary>
        /// The updated Example outputs as JSON
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("{example_id}.outputs")]
        public byte[]? x_exampleId_Outputs { get; set; }

        /// <summary>
        /// The updated Example outputs as JSON
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("{example_id}.outputsname")]
        public string? x_exampleId_Outputsname { get; set; }

        /// <summary>
        /// JSON describing attachment operations (retain, rename)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("{example_id}.attachments_operations")]
        public byte[]? x_exampleId_AttachmentsOperations { get; set; }

        /// <summary>
        /// JSON describing attachment operations (retain, rename)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("{example_id}.attachments_operationsname")]
        public string? x_exampleId_AttachmentsOperationsname { get; set; }

        /// <summary>
        /// New file attachment named {name}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("{example_id}.attachment.{name}")]
        public byte[]? x_exampleId_Attachment_name_ { get; set; }

        /// <summary>
        /// New file attachment named {name}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("{example_id}.attachment.{name}name")]
        public string? x_exampleId_Attachment_name_name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request2" /> class.
        /// </summary>
        /// <param name="x_exampleId_">
        /// The Example update info as JSON. Can have fields 'metadata', 'split'
        /// </param>
        /// <param name="x_exampleId_name">
        /// The Example update info as JSON. Can have fields 'metadata', 'split'
        /// </param>
        /// <param name="x_exampleId_Inputs">
        /// The updated Example inputs as JSON
        /// </param>
        /// <param name="x_exampleId_Inputsname">
        /// The updated Example inputs as JSON
        /// </param>
        /// <param name="x_exampleId_Outputs">
        /// The updated Example outputs as JSON
        /// </param>
        /// <param name="x_exampleId_Outputsname">
        /// The updated Example outputs as JSON
        /// </param>
        /// <param name="x_exampleId_AttachmentsOperations">
        /// JSON describing attachment operations (retain, rename)
        /// </param>
        /// <param name="x_exampleId_AttachmentsOperationsname">
        /// JSON describing attachment operations (retain, rename)
        /// </param>
        /// <param name="x_exampleId_Attachment_name_">
        /// New file attachment named {name}
        /// </param>
        /// <param name="x_exampleId_Attachment_name_name">
        /// New file attachment named {name}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request2(
            byte[] x_exampleId_,
            string x_exampleId_name,
            byte[]? x_exampleId_Inputs,
            string? x_exampleId_Inputsname,
            byte[]? x_exampleId_Outputs,
            string? x_exampleId_Outputsname,
            byte[]? x_exampleId_AttachmentsOperations,
            string? x_exampleId_AttachmentsOperationsname,
            byte[]? x_exampleId_Attachment_name_,
            string? x_exampleId_Attachment_name_name)
        {
            this.x_exampleId_ = x_exampleId_ ?? throw new global::System.ArgumentNullException(nameof(x_exampleId_));
            this.x_exampleId_name = x_exampleId_name ?? throw new global::System.ArgumentNullException(nameof(x_exampleId_name));
            this.x_exampleId_Inputs = x_exampleId_Inputs;
            this.x_exampleId_Inputsname = x_exampleId_Inputsname;
            this.x_exampleId_Outputs = x_exampleId_Outputs;
            this.x_exampleId_Outputsname = x_exampleId_Outputsname;
            this.x_exampleId_AttachmentsOperations = x_exampleId_AttachmentsOperations;
            this.x_exampleId_AttachmentsOperationsname = x_exampleId_AttachmentsOperationsname;
            this.x_exampleId_Attachment_name_ = x_exampleId_Attachment_name_;
            this.x_exampleId_Attachment_name_name = x_exampleId_Attachment_name_name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request2" /> class.
        /// </summary>
        public Request2()
        {
        }
    }
}