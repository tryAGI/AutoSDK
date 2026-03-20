//HintName: G.IInstructionsClient.UpdateInstruction.g.cs
#nullable enable

namespace G
{
    public partial interface IInstructionsClient
    {

        /// <summary>
        /// Update instruction<br/>
        /// Update an existing instruction's template, metadata, and configuration. Updated templates may include Velocity variables such as `$tools` or metadata references. Each update creates a new version, allowing agents to continue using existing versions until explicitly changed.<br/>
        /// ::info Version Management<br/>
        /// Agents referencing a specific version continue to use it until updated. Agents without a pinned version always use the latest.<br/>
        /// :::<br/>
        /// ## Disable an instruction<br/>
        /// This endpoint can also be used to disable an instruction without deleting it.<br/>
        /// :::warning<br/>
        /// Disabling an instruction prevents it from being added to new agents, but agents already using it continue to operate normally.<br/>
        /// :::
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="instructionId">
        /// The unique identifier for an instruction.<br/>
        /// Example: ins_customer_support_init
        /// </param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Instruction> UpdateInstructionAsync(
            string instructionId,

            global::G.UpdateInstructionRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update instruction<br/>
        /// Update an existing instruction's template, metadata, and configuration. Updated templates may include Velocity variables such as `$tools` or metadata references. Each update creates a new version, allowing agents to continue using existing versions until explicitly changed.<br/>
        /// ::info Version Management<br/>
        /// Agents referencing a specific version continue to use it until updated. Agents without a pinned version always use the latest.<br/>
        /// :::<br/>
        /// ## Disable an instruction<br/>
        /// This endpoint can also be used to disable an instruction without deleting it.<br/>
        /// :::warning<br/>
        /// Disabling an instruction prevents it from being added to new agents, but agents already using it continue to operate normally.<br/>
        /// :::
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="instructionId">
        /// The unique identifier for an instruction.<br/>
        /// Example: ins_customer_support_init
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Instruction> UpdateInstructionAsync(
            string instructionId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}