﻿//HintName: G.Models.Runner.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The id of the runner group.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("runner_group_id")]
        public int? RunnerGroupId { get; set; }

        /// <summary>
        /// The name of the runner.<br/>
        /// Example: iMac
        /// </summary>
        /// <example>iMac</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The Operating System of the runner.<br/>
        /// Example: macos
        /// </summary>
        /// <example>macos</example>
        [global::Newtonsoft.Json.JsonProperty("os", Required = global::Newtonsoft.Json.Required.Always)]
        public string Os { get; set; } = default!;

        /// <summary>
        /// The status of the runner.<br/>
        /// Example: online
        /// </summary>
        /// <example>online</example>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("busy", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Busy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RunnerLabel> Labels { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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