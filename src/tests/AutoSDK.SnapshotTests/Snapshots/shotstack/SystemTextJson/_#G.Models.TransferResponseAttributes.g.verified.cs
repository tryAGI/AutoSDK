//HintName: G.Models.TransferResponseAttributes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The transfer request attributes inlcudling the user specified ID and status. Returned with [TransferResponseData](#tocs_transferresponsedata).
    /// </summary>
    public sealed partial class TransferResponseAttributes
    {
        /// <summary>
        /// The user provided ID for the asset<br/>
        /// Example: 018e8937-5015-75ee-aab6-03f214981133
        /// </summary>
        /// <example>018e8937-5015-75ee-aab6-03f214981133</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The attributes of the asset transfer including the status.<br/>
        /// Example: 5ca6hu7s9k
        /// </summary>
        /// <example>5ca6hu7s9k</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string? Owner { get; set; }

        /// <summary>
        /// The status of the asset transfer. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`queued` - the transfer request has been queued&lt;/li&gt;<br/>
        ///   &lt;li&gt;`failed` - the transfer request failed&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: queued
        /// </summary>
        /// <example>queued</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransferResponseAttributesStatusJsonConverter))]
        public global::G.TransferResponseAttributesStatus? Status { get; set; }

        /// <summary>
        /// The time the asset transfer was created.<br/>
        /// Example: 2023-09-28T11:17:32.226Z
        /// </summary>
        /// <example>2023-09-28T11:17:32.226Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public string? Created { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferResponseAttributes" /> class.
        /// </summary>
        /// <param name="id">
        /// The user provided ID for the asset<br/>
        /// Example: 018e8937-5015-75ee-aab6-03f214981133
        /// </param>
        /// <param name="owner">
        /// The attributes of the asset transfer including the status.<br/>
        /// Example: 5ca6hu7s9k
        /// </param>
        /// <param name="status">
        /// The status of the asset transfer. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`queued` - the transfer request has been queued&lt;/li&gt;<br/>
        ///   &lt;li&gt;`failed` - the transfer request failed&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: queued
        /// </param>
        /// <param name="created">
        /// The time the asset transfer was created.<br/>
        /// Example: 2023-09-28T11:17:32.226Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferResponseAttributes(
            string? id,
            string? owner,
            global::G.TransferResponseAttributesStatus? status,
            string? created)
        {
            this.Id = id;
            this.Owner = owner;
            this.Status = status;
            this.Created = created;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferResponseAttributes" /> class.
        /// </summary>
        public TransferResponseAttributes()
        {
        }
    }
}