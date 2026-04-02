//HintName: G.JsonConverters.Nodes.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class NodesJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Nodes>
    {
        /// <inheritdoc />
        public override global::G.Nodes Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AgentWorkflowRequestModelNodesDiscriminator>(ref readerCopy, options);

            global::G.WorkflowStartNodeModelInput? start = default;
            if (discriminator?.Type == global::G.AgentWorkflowRequestModelNodesDiscriminatorType.Start)
            {
                start = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowStartNodeModelInput>(ref reader, options);
            }
            global::G.WorkflowEndNodeModelInput? end = default;
            if (discriminator?.Type == global::G.AgentWorkflowRequestModelNodesDiscriminatorType.End)
            {
                end = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowEndNodeModelInput>(ref reader, options);
            }
            global::G.WorkflowPhoneNumberNodeModelInput? phoneNumber = default;
            if (discriminator?.Type == global::G.AgentWorkflowRequestModelNodesDiscriminatorType.PhoneNumber)
            {
                phoneNumber = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowPhoneNumberNodeModelInput>(ref reader, options);
            }
            global::G.WorkflowOverrideAgentNodeModelInput? overrideAgent = default;
            if (discriminator?.Type == global::G.AgentWorkflowRequestModelNodesDiscriminatorType.OverrideAgent)
            {
                overrideAgent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowOverrideAgentNodeModelInput>(ref reader, options);
            }
            global::G.WorkflowStandaloneAgentNodeModelInput? standaloneAgent = default;
            if (discriminator?.Type == global::G.AgentWorkflowRequestModelNodesDiscriminatorType.StandaloneAgent)
            {
                standaloneAgent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowStandaloneAgentNodeModelInput>(ref reader, options);
            }
            global::G.WorkflowToolNodeModelInput? tool = default;
            if (discriminator?.Type == global::G.AgentWorkflowRequestModelNodesDiscriminatorType.Tool)
            {
                tool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowToolNodeModelInput>(ref reader, options);
            }

            var __value = new global::G.Nodes(
                discriminator?.Type,
                start,

                end,

                phoneNumber,

                overrideAgent,

                standaloneAgent,

                tool
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Nodes value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsStart)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Start, typeof(global::G.WorkflowStartNodeModelInput), options);
            }
            else if (value.IsEnd)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.End, typeof(global::G.WorkflowEndNodeModelInput), options);
            }
            else if (value.IsPhoneNumber)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PhoneNumber, typeof(global::G.WorkflowPhoneNumberNodeModelInput), options);
            }
            else if (value.IsOverrideAgent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OverrideAgent, typeof(global::G.WorkflowOverrideAgentNodeModelInput), options);
            }
            else if (value.IsStandaloneAgent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StandaloneAgent, typeof(global::G.WorkflowStandaloneAgentNodeModelInput), options);
            }
            else if (value.IsTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeof(global::G.WorkflowToolNodeModelInput), options);
            }
        }
    }
}