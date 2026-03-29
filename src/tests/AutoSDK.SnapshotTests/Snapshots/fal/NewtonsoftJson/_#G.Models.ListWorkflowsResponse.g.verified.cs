//HintName: G.Models.ListWorkflowsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing workflow data with pagination support
    /// </summary>
    public sealed partial class ListWorkflowsResponse
    {
        /// <summary>
        /// Array of workflow items<br/>
        /// Example: [{"name":"my-image-workflow","title":"My Image Generation Workflow","user_nickname":"johndoe","created_at":"2024-01-15T10:30:00Z","thumbnail_url":"https://fal.ai/workflows/thumb_abc123.png","description":"Generate high-quality images using FLUX model","tags":["image-generation","ai","flux"],"endpoint_ids":["fal-ai/flux/dev","fal-ai/face-swap"]}]
        /// </summary>
        /// <example>[{"name":"my-image-workflow","title":"My Image Generation Workflow","user_nickname":"johndoe","created_at":"2024-01-15T10:30:00Z","thumbnail_url":"https://fal.ai/workflows/thumb_abc123.png","description":"Generate high-quality images using FLUX model","tags":["image-generation","ai","flux"],"endpoint_ids":["fal-ai/flux/dev","fal-ai/face-swap"]}]</example>
        [global::Newtonsoft.Json.JsonProperty("workflows", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ListWorkflowsResponseWorkflow> Workflows { get; set; } = default!;

        /// <summary>
        /// Cursor for the next page of results, null if no more pages<br/>
        /// Example: eyJvZmZzZXQiOjEwfQ==
        /// </summary>
        /// <example>eyJvZmZzZXQiOjEwfQ==</example>
        [global::Newtonsoft.Json.JsonProperty("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Whether more results are available<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Total number of workflows matching the query<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorkflowsResponse" /> class.
        /// </summary>
        /// <param name="workflows">
        /// Array of workflow items<br/>
        /// Example: [{"name":"my-image-workflow","title":"My Image Generation Workflow","user_nickname":"johndoe","created_at":"2024-01-15T10:30:00Z","thumbnail_url":"https://fal.ai/workflows/thumb_abc123.png","description":"Generate high-quality images using FLUX model","tags":["image-generation","ai","flux"],"endpoint_ids":["fal-ai/flux/dev","fal-ai/face-swap"]}]
        /// </param>
        /// <param name="hasMore">
        /// Whether more results are available<br/>
        /// Example: true
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for the next page of results, null if no more pages<br/>
        /// Example: eyJvZmZzZXQiOjEwfQ==
        /// </param>
        /// <param name="total">
        /// Total number of workflows matching the query<br/>
        /// Example: 42
        /// </param>
        public ListWorkflowsResponse(
            global::System.Collections.Generic.IList<global::G.ListWorkflowsResponseWorkflow> workflows,
            bool hasMore,
            string? nextCursor,
            int? total)
        {
            this.Workflows = workflows ?? throw new global::System.ArgumentNullException(nameof(workflows));
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorkflowsResponse" /> class.
        /// </summary>
        public ListWorkflowsResponse()
        {
        }
    }
}