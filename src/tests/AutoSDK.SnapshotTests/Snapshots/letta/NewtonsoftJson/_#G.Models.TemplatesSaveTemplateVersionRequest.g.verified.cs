//HintName: G.Models.TemplatesSaveTemplateVersionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesSaveTemplateVersionRequest
    {
        /// <summary>
        /// If true, the environment variables will be preserved in the template version when migrating agents
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preserve_environment_variables_on_migration")]
        public bool? PreserveEnvironmentVariablesOnMigration { get; set; }

        /// <summary>
        /// If true, the core memories will be preserved in the template version when migrating agents
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preserve_core_memories_on_migration")]
        public bool? PreserveCoreMemoriesOnMigration { get; set; }

        /// <summary>
        /// If true, existing agent folders/sources will be preserved and merged with template sources during migration. If false, agent sources will be replaced with template sources.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preserve_sources_on_migration")]
        public bool? PreserveSourcesOnMigration { get; set; }

        /// <summary>
        /// Strategy for reconciling memory blocks during migration: "reconcile-all" deletes blocks not in the template, "preserve-deleted" keeps them. Defaults to "preserve-deleted".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("block_reconciliation_strategy")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TemplatesSaveTemplateVersionRequestBlockReconciliationStrategyJsonConverter))]
        public global::G.TemplatesSaveTemplateVersionRequestBlockReconciliationStrategy? BlockReconciliationStrategy { get; set; }

        /// <summary>
        /// If true, existing agents attached to this template will be migrated to the new template version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("migrate_agents")]
        public bool? MigrateAgents { get; set; }

        /// <summary>
        /// A message to describe the changes made in this template version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesSaveTemplateVersionRequest" /> class.
        /// </summary>
        /// <param name="preserveEnvironmentVariablesOnMigration">
        /// If true, the environment variables will be preserved in the template version when migrating agents
        /// </param>
        /// <param name="preserveCoreMemoriesOnMigration">
        /// If true, the core memories will be preserved in the template version when migrating agents
        /// </param>
        /// <param name="preserveSourcesOnMigration">
        /// If true, existing agent folders/sources will be preserved and merged with template sources during migration. If false, agent sources will be replaced with template sources.
        /// </param>
        /// <param name="blockReconciliationStrategy">
        /// Strategy for reconciling memory blocks during migration: "reconcile-all" deletes blocks not in the template, "preserve-deleted" keeps them. Defaults to "preserve-deleted".
        /// </param>
        /// <param name="migrateAgents">
        /// If true, existing agents attached to this template will be migrated to the new template version
        /// </param>
        /// <param name="message">
        /// A message to describe the changes made in this template version
        /// </param>
        public TemplatesSaveTemplateVersionRequest(
            bool? preserveEnvironmentVariablesOnMigration,
            bool? preserveCoreMemoriesOnMigration,
            bool? preserveSourcesOnMigration,
            global::G.TemplatesSaveTemplateVersionRequestBlockReconciliationStrategy? blockReconciliationStrategy,
            bool? migrateAgents,
            string? message)
        {
            this.PreserveEnvironmentVariablesOnMigration = preserveEnvironmentVariablesOnMigration;
            this.PreserveCoreMemoriesOnMigration = preserveCoreMemoriesOnMigration;
            this.PreserveSourcesOnMigration = preserveSourcesOnMigration;
            this.BlockReconciliationStrategy = blockReconciliationStrategy;
            this.MigrateAgents = migrateAgents;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesSaveTemplateVersionRequest" /> class.
        /// </summary>
        public TemplatesSaveTemplateVersionRequest()
        {
        }
    }
}