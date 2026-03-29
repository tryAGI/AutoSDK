//HintName: G.IInstructionsClient.Create.g.cs
#nullable enable

namespace G
{
    public partial interface IInstructionsClient
    {
        /// <summary>
        /// Create instruction<br/>
        /// Create a new instruction that defines how an agent should behave, reason, and respond. Instructions act as system-level guidelines that shape the agent's tone, style, constraints, and tool usage.<br/>
        /// Instructions support dynamic content using the Apache Velocity templating engine. Velocity variables allow instructions to reference runtime context:<br/>
        /// - `\$\tools`: The list of tools available to the agent.<br/>
        /// - `\$\{session.metadata.field}`: Session-level metadata (user context, permissions, preferences).<br/>
        /// - `\$\{agent.metadata.field}`: Agent-level metadata (configuration or environment).<br/>
        /// Example tool iteration:<br/>
        /// ```velocity<br/>
        /// You have access to the following tools:<br/>
        /// \#foreach(\$\tool in $tools)<br/>
        ///   - \$\{tool.name}: \$\{tool.description}<br/>
        /// #end<br/>
        /// ```<br/>
        /// :::tip Tips for effective instruction design<br/>
        /// Instructions are one of the most critical parts of an agent's design. Best practices vary by model, but at a minimum you should provide clear guidance on what tools are available, what output format is desired, and what steps to follow for common queries. Instructions typically need to be iterated on and tested over time.<br/>
        /// For guidance on writing effective instructions, see:<br/>
        /// - [Claude Prompt Engineering](https://platform.claude.com/docs/en/build-with-claude/prompt-engineering/overview)<br/>
        /// - [OpenAI Prompt Engineering](https://platform.openai.com/docs/guides/prompt-engineering)<br/>
        /// :::<br/>
        /// Metadata can personalize behavior at runtime. For example:<br/>
        /// ```velocity<br/>
        /// Hello ${session.metadata.user_name}, how can I help with ${session.metadata.department} today?<br/>
        /// ```<br/>
        /// **Example request:**<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "name": "Customer Support Tone and Style Guide",<br/>
        ///   "description": "Defines tone and behavior for customer interactions.",<br/>
        ///   "template": "You are a customer support agent for the ${session.metadata.department} department.",<br/>
        ///   "enabled": true,<br/>
        ///   "metadata": {<br/>
        ///     "owner": "customer-support-team",<br/>
        ///     "version": "1.0.0"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// A successful response returns the full instruction definition, including its unique ID, version, and timestamps.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Instruction> CreateAsync(

            global::G.CreateInstructionRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}