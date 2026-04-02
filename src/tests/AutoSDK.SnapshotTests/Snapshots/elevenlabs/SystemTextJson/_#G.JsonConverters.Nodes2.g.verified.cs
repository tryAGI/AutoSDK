//HintName: G.JsonConverters.Nodes2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Nodes2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Nodes2>
    {
        /// <inheritdoc />
        public override global::G.Nodes2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AgentWorkflowResponseModelNodesDiscriminator>(ref readerCopy, options);

            global::G.WorkflowStartNodeModelOutput? start = default;
            if (discriminator?.Type == global::G.AgentWorkflowResponseModelNodesDiscriminatorType.Start)
            {
                start = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowStartNodeModelOutput>(ref reader, options);
            }
            global::G.WorkflowEndNodeModelOutput? end = default;
            if (discriminator?.Type == global::G.AgentWorkflowResponseModelNodesDiscriminatorType.End)
            {
                end = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowEndNodeModelOutput>(ref reader, options);
            }
            global::G.WorkflowPhoneNumberNodeModelOutput? phoneNumber = default;
            if (discriminator?.Type == global::G.AgentWorkflowResponseModelNodesDiscriminatorType.PhoneNumber)
            {
                phoneNumber = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowPhoneNumberNodeModelOutput>(ref reader, options);
            }
            global::G.WorkflowOverrideAgentNodeModelOutput? overrideAgent = default;
            if (discriminator?.Type == global::G.AgentWorkflowResponseModelNodesDiscriminatorType.OverrideAgent)
            {
                overrideAgent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowOverrideAgentNodeModelOutput>(ref reader, options);
            }
            global::G.WorkflowStandaloneAgentNodeModelOutput? standaloneAgent = default;
            if (discriminator?.Type == global::G.AgentWorkflowResponseModelNodesDiscriminatorType.StandaloneAgent)
            {
                standaloneAgent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowStandaloneAgentNodeModelOutput>(ref reader, options);
            }
            global::G.WorkflowToolNodeModelOutput? tool = default;
            if (discriminator?.Type == global::G.AgentWorkflowResponseModelNodesDiscriminatorType.Tool)
            {
                tool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WorkflowToolNodeModelOutput>(ref reader, options);
            }

            var __value = new global::G.Nodes2(
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
            global::G.Nodes2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsStart)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Start, typeof(global::G.WorkflowStartNodeModelOutput), options);
            }
            else if (value.IsEnd)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.End, typeof(global::G.WorkflowEndNodeModelOutput), options);
            }
            else if (value.IsPhoneNumber)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PhoneNumber, typeof(global::G.WorkflowPhoneNumberNodeModelOutput), options);
            }
            else if (value.IsOverrideAgent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OverrideAgent, typeof(global::G.WorkflowOverrideAgentNodeModelOutput), options);
            }
            else if (value.IsStandaloneAgent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StandaloneAgent, typeof(global::G.WorkflowStandaloneAgentNodeModelOutput), options);
            }
            else if (value.IsTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeof(global::G.WorkflowToolNodeModelOutput), options);
            }
        }
    }
}