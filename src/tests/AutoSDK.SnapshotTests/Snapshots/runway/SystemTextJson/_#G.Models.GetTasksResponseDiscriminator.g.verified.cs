//HintName: G.Models.GetTasksResponseDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTasksResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTasksResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTasksResponseDiscriminator(
            string? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTasksResponseDiscriminator" /> class.
        /// </summary>
        public GetTasksResponseDiscriminator()
        {
        }
    }
}