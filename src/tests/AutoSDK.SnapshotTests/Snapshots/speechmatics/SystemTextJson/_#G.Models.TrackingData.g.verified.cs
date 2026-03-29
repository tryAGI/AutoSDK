//HintName: G.Models.TrackingData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"title":"ACME Q12018 Earnings Call","reference":"/data/clients/ACME/statements/segs/2018Q1-seg8","tags":["quick-review","segment"],"details":{"client":"ACME Corp","segment":8,"seg_start":963.201,"seg_end":1091.481}}
    /// </summary>
    public sealed partial class TrackingData
    {
        /// <summary>
        /// The title of the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// External system reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference")]
        public string? Reference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Customer-defined JSON structure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public object? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingData" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the job.
        /// </param>
        /// <param name="reference">
        /// External system reference.
        /// </param>
        /// <param name="tags"></param>
        /// <param name="details">
        /// Customer-defined JSON structure.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackingData(
            string? title,
            string? reference,
            global::System.Collections.Generic.IList<string>? tags,
            object? details)
        {
            this.Title = title;
            this.Reference = reference;
            this.Tags = tags;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingData" /> class.
        /// </summary>
        public TrackingData()
        {
        }
    }
}