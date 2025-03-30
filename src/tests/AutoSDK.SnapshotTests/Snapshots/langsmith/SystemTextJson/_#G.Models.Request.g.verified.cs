//HintName: G.Models.Request.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request
    {
        /// <summary>
        /// The Example info as JSON. Can have fields 'metadata', 'split', 'use_source_run_io', 'source_run_id', 'created_at', 'modified_at'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("{example_id}")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] x_exampleId_ { get; set; }

        /// <summary>
        /// The Example info as JSON. Can have fields 'metadata', 'split', 'use_source_run_io', 'source_run_id', 'created_at', 'modified_at'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("{example_id}name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string x_exampleId_name { get; set; }

        /// <summary>
        /// The Example inputs as JSON
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("{example_id}.inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] x_exampleId_Inputs { get; set; }

        /// <summary>
        /// The Example inputs as JSON
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("{example_id}.inputsname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string x_exampleId_Inputsname { get; set; }

        /// <summary>
        /// THe Example outputs as JSON
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("{example_id}.outputs")]
        public byte[]? x_exampleId_Outputs { get; set; }

        /// <summary>
        /// THe Example outputs as JSON
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("{example_id}.outputsname")]
        public string? x_exampleId_Outputsname { get; set; }

        /// <summary>
        /// File attachment named {name}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("{example_id}.attachments.{name}")]
        public byte[]? x_exampleId_Attachments_name_ { get; set; }

        /// <summary>
        /// File attachment named {name}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("{example_id}.attachments.{name}name")]
        public string? x_exampleId_Attachments_name_name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request" /> class.
        /// </summary>
        /// <param name="x_exampleId_">
        /// The Example info as JSON. Can have fields 'metadata', 'split', 'use_source_run_io', 'source_run_id', 'created_at', 'modified_at'
        /// </param>
        /// <param name="x_exampleId_name">
        /// The Example info as JSON. Can have fields 'metadata', 'split', 'use_source_run_io', 'source_run_id', 'created_at', 'modified_at'
        /// </param>
        /// <param name="x_exampleId_Inputs">
        /// The Example inputs as JSON
        /// </param>
        /// <param name="x_exampleId_Inputsname">
        /// The Example inputs as JSON
        /// </param>
        /// <param name="x_exampleId_Outputs">
        /// THe Example outputs as JSON
        /// </param>
        /// <param name="x_exampleId_Outputsname">
        /// THe Example outputs as JSON
        /// </param>
        /// <param name="x_exampleId_Attachments_name_">
        /// File attachment named {name}
        /// </param>
        /// <param name="x_exampleId_Attachments_name_name">
        /// File attachment named {name}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request(
            byte[] x_exampleId_,
            string x_exampleId_name,
            byte[] x_exampleId_Inputs,
            string x_exampleId_Inputsname,
            byte[]? x_exampleId_Outputs,
            string? x_exampleId_Outputsname,
            byte[]? x_exampleId_Attachments_name_,
            string? x_exampleId_Attachments_name_name)
        {
            this.x_exampleId_ = x_exampleId_ ?? throw new global::System.ArgumentNullException(nameof(x_exampleId_));
            this.x_exampleId_name = x_exampleId_name ?? throw new global::System.ArgumentNullException(nameof(x_exampleId_name));
            this.x_exampleId_Inputs = x_exampleId_Inputs ?? throw new global::System.ArgumentNullException(nameof(x_exampleId_Inputs));
            this.x_exampleId_Inputsname = x_exampleId_Inputsname ?? throw new global::System.ArgumentNullException(nameof(x_exampleId_Inputsname));
            this.x_exampleId_Outputs = x_exampleId_Outputs;
            this.x_exampleId_Outputsname = x_exampleId_Outputsname;
            this.x_exampleId_Attachments_name_ = x_exampleId_Attachments_name_;
            this.x_exampleId_Attachments_name_name = x_exampleId_Attachments_name_name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request" /> class.
        /// </summary>
        public Request()
        {
        }
    }
}