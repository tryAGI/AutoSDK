//HintName: G.Models.CatalogRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CatalogRun represents a single execution of a catalog action.
    /// </summary>
    public sealed partial class CatalogRun
    {
        /// <summary>
        /// Unique identifier for each run.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogUid")]
        public string? CatalogUid { get; set; }

        /// <summary>
        /// The file uids.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUids")]
        public global::System.Collections.Generic.IList<string>? FileUids { get; set; }

        /// <summary>
        /// Action of the catalog run.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CatalogRunActionJsonConverter))]
        public global::G.CatalogRunAction? Action { get; set; }

        /// <summary>
        /// Current status of the run.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunStatusJsonConverter))]
        public global::G.RunStatus? Status { get; set; }

        /// <summary>
        /// Origin of the run.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunSourceJsonConverter))]
        public global::G.RunSource? Source { get; set; }

        /// <summary>
        /// Time taken to complete the run in milliseconds.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalDuration")]
        public int? TotalDuration { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runnerId")]
        public string? RunnerId { get; set; }

        /// <summary>
        /// Namespace ID.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespaceId")]
        public string? NamespaceId { get; set; }

        /// <summary>
        /// Run request payload.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// Time when the run started execution.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Time when the run completed.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completeTime")]
        public global::System.DateTime? CompleteTime { get; set; }

        /// <summary>
        /// Error message if the run failed.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Credits used of internal accounting metric.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creditAmount")]
        public float? CreditAmount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogRun" /> class.
        /// </summary>
        /// <param name="uid">
        /// Unique identifier for each run.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="catalogUid">
        /// Included only in responses
        /// </param>
        /// <param name="fileUids">
        /// The file uids.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="action">
        /// Action of the catalog run.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Current status of the run.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="source">
        /// Origin of the run.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalDuration">
        /// Time taken to complete the run in milliseconds.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="runnerId">
        /// Included only in responses
        /// </param>
        /// <param name="namespaceId">
        /// Namespace ID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="payload">
        /// Run request payload.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="startTime">
        /// Time when the run started execution.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="completeTime">
        /// Time when the run completed.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="error">
        /// Error message if the run failed.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="creditAmount">
        /// Credits used of internal accounting metric.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CatalogRun(
            string? uid,
            string? catalogUid,
            global::System.Collections.Generic.IList<string>? fileUids,
            global::G.CatalogRunAction? action,
            global::G.RunStatus? status,
            global::G.RunSource? source,
            int? totalDuration,
            string? runnerId,
            string? namespaceId,
            object? payload,
            global::System.DateTime? startTime,
            global::System.DateTime? completeTime,
            string? error,
            float? creditAmount)
        {
            this.Uid = uid;
            this.CatalogUid = catalogUid;
            this.FileUids = fileUids;
            this.Action = action;
            this.Status = status;
            this.Source = source;
            this.TotalDuration = totalDuration;
            this.RunnerId = runnerId;
            this.NamespaceId = namespaceId;
            this.Payload = payload;
            this.StartTime = startTime;
            this.CompleteTime = completeTime;
            this.Error = error;
            this.CreditAmount = creditAmount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogRun" /> class.
        /// </summary>
        public CatalogRun()
        {
        }
    }
}