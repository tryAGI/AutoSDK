//HintName: G.Models.Runner.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A self hosted runner
    /// </summary>
    public sealed partial class Runner
    {
        /// <summary>
        /// The id of the runner.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The id of the runner group.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_group_id")]
        public int? RunnerGroupId { get; set; }

        /// <summary>
        /// The name of the runner.<br/>
        /// Example: iMac
        /// </summary>
        /// <example>iMac</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The Operating System of the runner.<br/>
        /// Example: macos
        /// </summary>
        /// <example>macos</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("os")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Os { get; set; }

        /// <summary>
        /// The status of the runner.<br/>
        /// Example: online
        /// </summary>
        /// <example>online</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("busy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Busy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.RunnerLabel> Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Runner" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the runner.<br/>
        /// Example: 5
        /// </param>
        /// <param name="runnerGroupId">
        /// The id of the runner group.<br/>
        /// Example: 1
        /// </param>
        /// <param name="name">
        /// The name of the runner.<br/>
        /// Example: iMac
        /// </param>
        /// <param name="os">
        /// The Operating System of the runner.<br/>
        /// Example: macos
        /// </param>
        /// <param name="status">
        /// The status of the runner.<br/>
        /// Example: online
        /// </param>
        /// <param name="busy"></param>
        /// <param name="labels"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Runner(
            int id,
            string name,
            string os,
            string status,
            bool busy,
            global::System.Collections.Generic.IList<global::G.RunnerLabel> labels,
            int? runnerGroupId)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Os = os ?? throw new global::System.ArgumentNullException(nameof(os));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Busy = busy;
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.RunnerGroupId = runnerGroupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Runner" /> class.
        /// </summary>
        public Runner()
        {
        }
    }
}